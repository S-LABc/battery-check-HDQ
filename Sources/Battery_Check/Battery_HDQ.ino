#include "HDQ.h"
#include "BATTERY_HDQ.h"


// HDQ Sınıfı Örneği
HDQ BAT(BATTERY_CONNECT_PIN);

// Gerekli tüm standart komut kodlarının dizileri
const byte _std_commands [] = STANDARD_COMMANDS_CODE;
const byte _sub_commands [] = SUB_COMMANDS_CODE;
const byte _ext_commands [] = EXTD_CMD_MANUFACTURE_BLOCK_A_B_C;
uint8_t _block_data[EXTD_CMD_BLOCK_DATA_H - EXTD_CMD_BLOCK_DATA_L]; // Массив для данных из регистров 0x40-0x5f
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
  for(uint8_t i = 0; i < sizeof(_sub_commands); i++) {
      BAT.write(0x00, _sub_commands[i]);
      BAT.write(0x1, 0x00);
      _bat_low_byte = BAT.read(0x00);
      _bat_high_byte = BAT.read(0x01);
      _temp += String(word(_bat_high_byte, _bat_low_byte), HEX) + SEPARATOR_CHARACTER;
    }

   for(uint8_t i = 0; i < sizeof(_ext_commands); i++) {
     _temp += String(getManufacturerInfoBlock(_ext_commands[i])) + SEPARATOR_CHARACTER;
    }
  
  return _temp;
}

/*
 * @brief: получить информацию о производителе. Блок A
 * @return: указатель на массив символов (строка)
 */
char* getManufacturerInfoBlock(byte payload) {
  
  BAT.write(EXTD_CMD_DATA_FLASH_BLOCK, payload);
  pullBlockData(_block_data);

  return (char*)_block_data;
}

/*
 * @brief: получить данные из регистров 0x40...0x5F
 * @param str[]: массив для хранения считанных данных
 */
void pullBlockData(uint8_t str[]) {
  uint8_t count = 0;
  for(uint8_t i = EXTD_CMD_BLOCK_DATA_L; i <= EXTD_CMD_BLOCK_DATA_H; i++) {
    str[count] = BAT.read(i);
    count++;
  }
}






