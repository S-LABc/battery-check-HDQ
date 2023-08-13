#include "HDQ.h"
#include "BATTERY_HDQ.h"

// HDQ Sınıfı Örneği
HDQ BAT(BATTERY_CONNECT_PIN);

// Gerekli tüm standart komut kodlarının dizileri
const byte _std_commands [] = STANDARD_COMMANDS_CODE;
const byte _sub_commands [] = SUB_COMMANDS_CODE;

// Üst ve alt bayt için değişkenler
static byte _bat_low_byte = 0;
static byte _bat_high_byte = 0;

// Pil Verilerini HDQ Denetleyicisinden Okuma
String Battery_HDQ_Data_Read() {
  
  // Toplanmış değerler paketi için değişken
  String _temp = EMPTY_STRING;
  
  // Temel kontrol komut bloğunun işlenmesi(registerlerdan her daim okunabilecek veridir)
  for(uint8_t j = 0; j < sizeof(_std_commands); j += 2) {
      _bat_low_byte = BAT.read(_std_commands[j]);
      _bat_high_byte = BAT.read(_std_commands[j + 1]);
      _temp += String(word(_bat_high_byte, _bat_low_byte)) + SEPARATOR_CHARACTER;
    }
    
  // Kontrol bloğundaki alt komutların işlenmesi (burada veri aynı registerden okunur ama farklı registerlara önce komut girilir. )
  for(uint8_t i = 2; i < sizeof(_sub_commands); i++) {
      BAT.write(_sub_commands[1], _sub_commands[i]);
      BAT.write(_sub_commands[0], _sub_commands[1]);
      _bat_low_byte = BAT.read(_sub_commands[1]);
      _bat_high_byte = BAT.read(_sub_commands[2]);
      _temp += String(word(_bat_high_byte, _bat_low_byte), HEX) + SEPARATOR_CHARACTER;
    }
  
  return _temp;
}
