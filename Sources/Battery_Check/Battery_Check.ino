/**
 * Apple Batarya Kontrolü
 * 
 * iPhone/iPad/iWatch cihazlarının pil denetleyicilerinden veri çekmeyi sağlar
 * Veri alışverişi için HDQ ve I2C olmak üzere iki arayüzü destekler
 * 
 * Telif Hakkı (C) 2019. v1.0 / Roman Sklyar S-LAB
 * YouTube https://www.youtube.com/channel/UCbkE52YKRphgkvQtdwzQbZQ
 * ARDUINO V1.8.10'da DERLENMİŞ
 *https://www.ti.com/power-management/battery-management/fuel-gauges/products.html#
 * 
*/

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
      Serial.println(Battery_IIC_Data_Read()); // test
    }
  }
  // Tamponu temizleme
  Serial.flush();
}
