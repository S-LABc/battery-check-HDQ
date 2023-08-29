#include "HDQ.h"
#include "BATTERY_HDQ.h"


// HDQ Sınıfı Örneği
HDQ BAT(BATTERY_CONNECT_PIN);

// Gerekli tüm standart komut kodlarının dizileri
const byte _std_commands[] = STANDARD_COMMANDS_CODE;
const byte _sub_commands[] = SUB_COMMANDS_CODE;
const byte _ext_commands[] = EXTD_CMD_MANUFACTURE_BLOCK_A_B_C;
uint8_t _block_data[EXTD_CMD_BLOCK_DATA_H - EXTD_CMD_BLOCK_DATA_L];
uint8_t _auth_data[] = { 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF, 0xFE, 0xDC, 0xBA, 0x98, 0x76, 0x54, 0x32, 0x10 };
// Default Full-Access Key: 0x36720414 (Little-Endian: Key 1 - 0x0414, Key 0 - 0x3672)
uint8_t _unseal_key[] = { 0x14, 0x04, 0x72, 0x36 };


// Üst ve alt bayt için değişkenler
static byte _bat_low_byte = 0;
static byte _bat_high_byte = 0;

// Pil Verilerini HDQ Denetleyicisinden Okuma
String Battery_HDQ_Data_Read() {

  // Toplanmış değerler paketi için değişken
  String _temp = EMPTY_STRING;

  // Temel kontrol komut bloğunun işlenmesi(registerlerdan her daim okunabilecek veridir)
  for (uint8_t j = 0; j < sizeof(_std_commands); j += 2) {
    _bat_low_byte = BAT.read(_std_commands[j]);
    _bat_high_byte = BAT.read(_std_commands[j + 1]);
    _temp += String(word(_bat_high_byte, _bat_low_byte)) + SEPARATOR_CHARACTER;
  }

  // Kontrol bloğundaki alt komutların işlenmesi (burada veri aynı registerden okunur ama farklı registerlara önce komut girilir. )
  for (uint8_t i = 0; i < sizeof(_sub_commands); i++) {
    BAT.write(0x00, _sub_commands[i]);
    BAT.write(0x01, 0x00);
    _bat_low_byte = BAT.read(0x00);
    _bat_high_byte = BAT.read(0x01);
    _temp += String(word(_bat_high_byte, _bat_low_byte), HEX) + SEPARATOR_CHARACTER;
  }

  for (uint8_t i = 0; i < sizeof(_ext_commands); i++) {
    _temp += String(getManufacturerInfoBlock(_ext_commands[i])) + SEPARATOR_CHARACTER;
  }


  return _temp;
}

uint8_t calculate_8bit_checksum(String data) {
  uint8_t eightBitSum = 0;
  for (size_t i = 0; i < data.length(); i++) {
    eightBitSum += data.charAt(i);
  }
  uint8_t result = 255 - eightBitSum;
  return result;
}
void pullBlockData(uint8_t str[], uint8_t _bat_low_byte, uint8_t _bat_high_byte) {
  uint8_t count = 0;
  for (uint8_t i = _bat_low_byte; i <= _bat_high_byte; i++) {
    str[count] = BAT.read(i);
    count++;
  }
}
void pushBlockData(const String& data, uint8_t _start_byte, uint8_t _end_byte, uint8_t hash) {
  uint8_t j = 0;
  for (uint8_t i = _start_byte; i <= _end_byte; i++) {
    BAT.write(i, data[j]);
    j++;
    // if ((_end_byte-i) > j) {
    //   BAT.write(i, 0x00);
    // }
  }
  BAT.write(0x60, hash);
}

char* getManufacturerInfoBlock(byte payload) {

  BAT.write(EXTD_CMD_DATA_FLASH_BLOCK, payload);
  pullBlockData(_block_data, EXTD_CMD_BLOCK_DATA_L, EXTD_CMD_BLOCK_DATA_H);
  return (char*)_block_data;
}




String Battery_HDQ_Data_Read_TEST() {

  String _temp = EMPTY_STRING;

  // Control() Subcommands ==> RESET_DATA
  _temp += "Write and Read RESET DATA:";
  BAT.write(0x00, 0x05);  //REG, SUBCMD LBYTE (SADECE 2. DEGER ALT KOMUTTUR YANİ 0x05 RESET DATA DIR)
  BAT.write(0x01, 0x00);  //REG, SUBCMD HBYTE
  _bat_low_byte = BAT.read(0x00);
  _bat_high_byte = BAT.read(0x01);
  _temp += String(word(_bat_high_byte, _bat_low_byte), HEX) + "\n";

  // Standard Commands Flags()
  _temp += "Read FLAGS :";
  _bat_low_byte = BAT.read(0x0A);
  _bat_high_byte = BAT.read(0x0B);
  _temp += String(word(_bat_high_byte, _bat_low_byte), HEX) + "\n";

  // Standard Commands StateOfHealth()
  _temp += "Read SOH:";
  _bat_low_byte = BAT.read(0x2E);
  _bat_high_byte = BAT.read(0x2F);
  _temp += String(word(_bat_high_byte, _bat_low_byte)) + "\n";

  // Standard Commands ChargingCurrent()
  _temp += "Read CC:";
  _bat_low_byte = BAT.read(0x32);
  _bat_high_byte = BAT.read(0x33);
  _temp += String(word(_bat_high_byte, _bat_low_byte)) + "\n";

  // Extended Commands BlockDataCheckSum() Register
  _temp += "Read byte 60(CHK) :";
  byte _read_byte = BAT.read(0x60);
  _temp += String(_read_byte, HEX) + "\n";

  // Extended Commands BlockDataControl() Register
  _temp += "Read byte 61(SEALED) :";
  byte _read_byte2 = BAT.read(0x61);
  _temp += String(_read_byte2, HEX) + "\n";

  _temp += "DATA CTRL: " + String(BAT.read(EXTD_CMD_BLOCK_DATA_CONTROL), HEX) + "\n";
  _temp += "DATA CLSS: " + String(BAT.read(EXTD_CMD_DATA_FLASH_CLASS), HEX) + "\n";
  // pullBlockData(_block_data, EXTD_CMD_BLOCK_DATA_L, EXTD_CMD_BLOCK_DATA_H);
  // _temp += (char*)_block_data;
  // _temp +="\n";

  // UNSEALED BLOCK OKUMA
  // BAT.write(EXTD_CMD_BLOCK_DATA_CONTROL, 0x00);  // PREPARE UNSEALED READ BU KOMUT SEALED MODDA ÇALIŞMAZ
  // BAT.write(EXTD_CMD_DATA_FLASH_CLASS, 0x38);    // DATA SINIFI SEÇİMİ BU KOMUT SEALED MODDA ÇALIŞMAZ
  // BAT.write(EXTD_CMD_DATA_FLASH_BLOCK, 0x01);    // 5.1.1 Accessing The Data Flash
  // pullBlockData(_block_data, EXTD_CMD_BLOCK_DATA_L, EXTD_CMD_BLOCK_DATA_H);
  // _temp += (char*)_block_data;
  // _temp += "\n";

  // 3.4 Executing an Authentication Query
  // 5.1.1 Accessing The Data Flash
  // 5.9 Security Class
  // Yetkilendirme UNSEALED: BlockDataControl()(0x61) register a 0x01 yazarsan yetkili işleme girer.
  // Yetkilendirme SEALED: DataFlashBlock()(0x3F) register a 0x00 yazarsan yetkili işleme girer.
  // Sonra 20-byte yetkilendirme kodu Authenticate() adresine yani (0x40)'tan (0x53)'e kadar olan adrese gönderilir.
  // Geçerli bir toplam kontrol değeri (checksum), AuthenticateChecksum() (0x54) register a yazıldıktan sonra 45ms bekleyip
  // Authenticate() adresleri yani (0x40)'tan (0x53)'e kadar okunup host makinada karşılaştırılmalıdır.
  _temp += "WRITE BLOCKS:\n";
  BAT.write(EXTD_CMD_DATA_FLASH_BLOCK, 0x02);
  pushBlockData("F8Y05020ALBH86CBR", EXTD_CMD_BLOCK_DATA_L, EXTD_CMD_BLOCK_DATA_H, calculate_8bit_checksum("F8Y05020ALBH86CBR"));
  _temp += "CREATED HASH: " + String(calculate_8bit_checksum("F8Y05020ALBH86CBR"), HEX) + "\n";

  delay(100);
  BAT.write(EXTD_CMD_DATA_FLASH_BLOCK, 0x02);
  pullBlockData(_block_data, EXTD_CMD_BLOCK_DATA_L, EXTD_CMD_BLOCK_DATA_H);
  _temp += (char*)_block_data;
  _temp += "\n";
  _temp += "RESPONSE HASH: " + String(BAT.read(0x60), HEX) + "\n";

  return _temp;
}
void Unseal(void) {
  // Default Full-Access Key: 0x36720414 (Little-Endian: Key 1 - 0x0414, Key 0 - 0x3672)
  byte unsealKey[] = { 0x14, 0x04, 0x72, 0x36 };
  // ADRESLER YANLIŞ DÜZELTECEĞİZ PUSHDATA İLE SECURTY DATA CLASSA GIDECEK
  BAT.write(0x00, unsealKey[0]);
  BAT.write(0x01, unsealKey[1]);
  BAT.write(0x00, unsealKey[2]);
  BAT.write(0x01, unsealKey[3]);
  BAT.write(0x00, 0xFF);
  BAT.write(0x01, 0xFF);
  BAT.write(0x00, 0xFF);
  BAT.write(0x01, 0xFF);
}