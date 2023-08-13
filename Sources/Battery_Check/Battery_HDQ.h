#ifndef BATTERY_HDQ_H 
#define BATTERY_HDQ_H

// Arduino'da bağlı olan HDQ pil pininin tanımı
#define BATTERY_CONNECT_PIN 5

// GUI için ayrıştırıcı karakter
#define SEPARATOR_CHARACTER '/'

// Boş karakter dizisi
#define EMPTY_STRING ""

/**
 * Standart Komutların Kodları
 * 
 * LOW/HIGH - Açıklama
 * 0x06/0x07 - Sıcaklık (Kelvin)
 * 0x08/0x09 - Gerilim (mV)
 * 0x10/0x11 - Şuanki Kapasite (mAh)
 * 0x12/0x13 - Kullanılabilir Kapasite (mAh)
 * 0x2A/0x2B - Döngü Sayısı
 * 0x2C/0x2D - Şarj Seviyesi (%)
 * 0x3C/0x3D - Fabrika Kapasitesi (mAh) (Genişletilmiş Komut Tablosundan)
**/
#define STANDARD_COMMANDS_CODE {0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x2A, 0x2B, 0x2C, 0x2D, 0x3C, 0x3D}

/**
 * Alt Komutların Kodları
 * 
 * COM  - Açıklama
 * 0x1  - 
 * 0x00 - 
 * 0x01 - Kontrolcü Modeli
 * 0x02 - Yazılım Sürümü
 * 0x03 - Donanım Sürümü
**/
#define SUB_COMMANDS_CODE {0x1, 0x00, 0x01, 0x02, 0x03}

#endif

