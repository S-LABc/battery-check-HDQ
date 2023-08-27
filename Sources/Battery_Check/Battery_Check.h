/**
 * Apple Batarya Kontrolü
 * 
 * iPhone/iPad/iWatch cihazlarının pil denetleyicilerinden veri çekmeyi sağlar
 * Veri alışverişi için HDQ ve I2C olmak üzere iki arayüzü destekler
 * 
 * Telif Hakkı (C) 2019. v1.0 / Roman Sklyar S-LAB
 * ARDUINO V1.8.10'da DERLENMİŞ
 * https://www.ti.com/power-management/battery-management/fuel-gauges/products.html#
 * 
*/
#ifndef APPLE_BATTERY_CHECK_H
#define APPLE_BATTERY_CHECK_H

/**
 * Kontrol Komut Kodları
 * 
 * Kod -   Karakter - Açıklama
 * 65  -   "A"      - HDQ Pil Okuma (eski)
 * 66  -   "B"      - I2C Pil Okuma (yeni)
**/
#define COMPARE_COMMAND_DEC \
  { 65, 66, 67,68 }

// Serial Veri Hızı
#define SERIAL_BAUDRATE 57600

#endif
