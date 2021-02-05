#ifndef APPLE_BATTERY_CHECK_H 
#define APPLE_BATTERY_CHECK_H

/**
 * Коды команд управления 
 * 
 * Код -   Символ - Описание
 * 65  -   "A"    - Чтение АКБ HDQ (старый)
 * 66  -   "B"    - Чтение АКБ I2C (новый)
**/
#define COMPARE_COMMAND_DEC {65, 66}

//Скорость обмена данными по Serial
#define SERIAL_BAUDRATE    57600

#endif
