def pushBlockData(data, start_byte, end_byte, hash_value):
    print("Address\tData")
    
    j = 0
    for i in range(start_byte, end_byte + 1):
        hex_data = data[j].encode('utf-8').hex()
        print(f"0x{i:02X}\t{hex_data}")
        j += 1
    
    hash_hex = bytes([hash_value]).hex()
    print(f"0x60\t{hash_hex}")

# Veriyi simüle et (Unicode karakterler içerebilir)
data = "F8Y05020ALBH86CBR"
hash_value = 0xAB  # Örnek hash değeri

pushBlockData(data, 0x40, 0x5F, hash_value)
