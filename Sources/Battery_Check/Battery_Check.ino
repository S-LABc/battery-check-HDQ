/**
 * Apple Battery Check
 * 
 * Позволяет извлечь данные из контроллеров АКБ от iPhone/iPad/iWatch
 * Поддерживает два интерфейса обмена данными - HDQ и I2C
 * 
 * Copyright (C) 2019. v1.0 / Скляр Роман S-LAB
 * YouTube https://www.youtube.com/channel/UCbkE52YKRphgkvQtdwzQbZQ
 * COMPILED IN ARDUINO V1.8.10
 * 
*/

#include "BATTERY_CHECK.h"
#include "BATTERY_HDQ.h"

char _serial_input = 0;
char _compare_command [] = COMPARE_COMMAND_DEC;

void setup() {
  Serial.begin(SERIAL_BAUDRATE);
  pinMode(BATTERY_CONNECT_PIN, INPUT);
  }

void loop() {
  //Проверка наличия данных в буфере uart
  if(Serial.available() != 0) {
     _serial_input = Serial.read();
     
    //Чтение данных по протоколу HDQ
    if(_serial_input == _compare_command[0]) {
      Serial.println(Battery_HDQ_Data_Read());
    }
    
    //Чтение данных по протоколу I2C
    else if(_serial_input == _compare_command[1]) {
      Serial.println(Battery_IIC_Data_Read()); //тест
    }
  }
  //Очистка буфера
  Serial.flush();
}
