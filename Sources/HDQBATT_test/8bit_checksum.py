def calculate_8bit_checksum(blockData):
    eightBitSum = sum(blockData) & 0xFF
    result = 255 - eightBitSum
    return result

data1 = "N5591HOP0410BSS8C6FA"
data2 = "F8Y05020ALBH86CBR"
data3 = "MLB:FJ6051200V0GY4RG"

# Verileri byte dizilerine dönüştür
data1_bytes = bytes(data1, 'utf-8')
data2_bytes = bytes(data2, 'utf-8')
data3_bytes = bytes(data3, 'utf-8')

# 8-bit hash değerlerini hesapla
hash1 = calculate_8bit_checksum(data1_bytes)
hash2 = calculate_8bit_checksum(data2_bytes)
hash3 = calculate_8bit_checksum(data3_bytes)

print("Data 1 8-bit Hash:", hex(hash1))
print("Data 2 8-bit Hash:", hex(hash2))
print("Data 3 8-bit Hash:", hex(hash3))
