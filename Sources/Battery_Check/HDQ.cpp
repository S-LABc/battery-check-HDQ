//.CPP LIBRARY CODE

/*
*
* Texas Instruments HDQ implementation for the Arduino API
* (cleft) Matthieu Lalonde 2008 (matth@mlalonde.net)
* Creative Commons BY-SA-NC
*
* http://trac.mlalonde.net/cral/browser/HDQ/
*
* Revision 1
*
*
*/

/* *********
*	USAGE!
************


#include <HDQ.h>

HDQ HDQ(HDQ_DEFAULT_PIN);

uint8_t DC1;
uint8_t DC2;

void setup() {
  Serial.begin(9600);
}

void loop() {

	for (uint8_t jj = 0; jj < 0x3F; jj++) {
		DC1 = HDQ.read(jj);
		DC2 = HDQ.read(jj+1);
		int total = word(DC2, DC1);

		Serial.print("Register 0x");
		Serial.print(jj, HEX);
		Serial.print(": ");
		Serial.println(total);
		jj++;

	}
	delay(2000);
	Serial.println("");
}

*/


extern "C" {
#include <pins_arduino.h> 
}
#include <Arduino.h>
#include "HDQ.h"

#define _HDQ_readPin() (*inputReg & bitmask)>>pin // Change me to inline!*/

// defines for setting and clearing register bits
#ifndef cbi
#define cbi(sfr, bit) (_SFR_BYTE(sfr) &= ~_BV(bit))
#endif
#ifndef sbi
#define sbi(sfr, bit) (_SFR_BYTE(sfr) |= _BV(bit))
#endif

/*
*
* Constructor
* @param pinArg: pin number to attach to
*
*/
HDQ::HDQ(uint8_t pinArg) {
	pin = pinArg;
	port = digitalPinToPort(pin);
	bitmask = digitalPinToBitMask(pin);
	outputReg = portOutputRegister(port);
	inputReg = portInputRegister(port);
	modeReg = portModeRegister(port);
}

/*
*
* sendBreak: writes a break to the HDQ line
*/
void HDQ::doBreak(void) {
	sbi(*modeReg, pin); // Set pin as output

	// Singal a break on the line
	cbi(*outputReg, pin);   // Bring pin low
	delayMicroseconds(HDQ_DELAY_TB);

	// Make sure we leave enough time for the slave to recover
	cbi(*modeReg, pin);     // Release pin
	delayMicroseconds(HDQ_DELAY_TBR);

}

/*
 writeByte: write a raw byte of data to the bus
 @param payload: the byte to send
*/
void HDQ::writeByte(uint8_t payload) {
	sbi(*modeReg, pin); // Set pin as output

	for (uint8_t ii = 0; ii < 8; ii++) {

		// Start bit
		cbi(*outputReg, pin);   // Bring pin low
		delayMicroseconds(HDQ_DELAY_THW1);

		// Toggle the pin for this bit
		if (payload >> ii & 0x01) {	// LSB First
			sbi(*outputReg, pin); // High
		}
		else {
			cbi(*outputReg, pin); // Low
		}

		// Bit time
		delayMicroseconds(HDQ_DELAY_THW0 - HDQ_DELAY_THW1 + 5);

		// Stop bit
		sbi(*outputReg, pin);   // Bring the pin high
		delayMicroseconds(HDQ_DELAY_TCYCH - HDQ_DELAY_THW0);

	}

	// Make sure we leave enough time for the slave to recover
	cbi(*modeReg, pin);     // Release pin
	//delayMicroseconds(HDQ_DELAY_TBR);
	delayMicroseconds(HDQ_DELAY_TCYCH - HDQ_DELAY_THW0);

	return;

}



/*
*
* write: send a payload to the device
* @param reg: the address of the register to write to
* @param payload: data to be sent
* @return: false, unless if verif is set, then
* it will read back the register and
* return true if it matches the payload
*
*/
bool HDQ::write(uint8_t reg, uint8_t payload) {
	// Singal a break 
	HDQ::doBreak();

	// Write the register to write
	HDQ::writeByte((reg |= HDQ_ADDR_MASK_WRITE));

	// Wait for the slave to finish reading the register
	delayMicroseconds((HDQ_DELAY_TRSPS_MAX - HDQ_DELAY_BIT_TOTAL) / 2);

	// Write the payload
	HDQ::writeByte(payload);

	// Wait for the slave to finish writing the payload
	delayMicroseconds((HDQ_DELAY_TRSPS_MAX - HDQ_DELAY_BIT_TOTAL) / 2);

	cbi(*modeReg, pin);     // Release pin

	return true;

}

/*
*
* Write with verification
*
*/
bool HDQ::write(uint8_t reg, uint8_t payload, bool verif) { // Write the payload 
	HDQ::write(reg, payload);

	// Verify the write
	if (payload == HDQ::read(reg)) return true;

	return false;

}

/*
*
* read: read from the device
* @param register: address of the register to read
* @return a uint8_t integer
*
*/
uint8_t HDQ::read(uint8_t reg) {
	uint8_t result = 0;
	uint8_t maxTries = HDQ_DELAY_FAIL_TRIES; // ~128uS at 8Mhz with 8 instructions per loop 

	// Singal a break
	HDQ::doBreak();

	// Write the register to read
	HDQ::writeByte((reg |= HDQ_ADDR_MASK_READ));

	for (uint8_t ii = 0; ii < 8; ii++) {
		// Wait for the slave to toggle a low, or fail
		maxTries = HDQ_DELAY_FAIL_TRIES;
		while (_HDQ_readPin() != 0 && maxTries-- > 0)
			if (maxTries == 1) return 0xFF;

		// Wait until Tdsub and half or one bit has passed
		delayMicroseconds(((HDQ_DELAY_TDW0 - HDQ_DELAY_TDW1) / 2) + HDQ_DELAY_TDW1);
		// Read the bit
		result |= _HDQ_readPin() << ii;

		// Wait until Tssub has passed
		delayMicroseconds(HDQ_DELAY_TCYCD - HDQ_DELAY_TDW0);
	}

	delayMicroseconds(HDQ_DELAY_TB);

	return result;

}