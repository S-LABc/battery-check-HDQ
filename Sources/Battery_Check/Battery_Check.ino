#include "BATTERY_CHECK.h"
#include "BATTERY_HDQ.h"

char _serial_input = 0;
char _compare_command[] = COMPARE_COMMAND_DEC;

void setup() {
  Serial.begin(SERIAL_BAUDRATE);
  pinMode(BATTERY_CONNECT_PIN, INPUT);
}

void loop() {
  // Uart (seri iletişim) tamponunda veri olup olmadığını kontrol et
  if (Serial.available() != 0) {
    _serial_input = Serial.read();

    // HDQ protokolü ile veri okuma
    if (_serial_input == _compare_command[0]) {
      Serial.println(Battery_HDQ_Data_Read());
    }

    // I2C protokolü ile veri okuma
    else if (_serial_input == _compare_command[1]) {
      Serial.println(Battery_IIC_Data_Read());  // test
    }
  }
  // Tamponu temizleme
  Serial.flush();
}
