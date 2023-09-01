def calculate_block_end_address(start_address, offset, block_size):
    # Başlangıç adresi ve ofseti toplayarak toplamı hesapla
    total_address = start_address + offset
    # Toplamı blok boyutuna göre mod alarak kalanı hesapla
    remainder = total_address % block_size
    # Kalanı başlangıç adresine ekle ve sonuç adresini elde et
    result_address = start_address + remainder
    return result_address

# Başlangıç adresi (örnek olarak 0x40)
baslangic_adresi = 0x40
# Ofset değeri (örnek olarak 67)
ofset_degeri = 67
# Blok boyutu (örnek olarak 32)
blok_boyutu = 32

# Hesaplamayı yap ve sonucu onaltılık sistemde yazdır
hesaplanmis_adres = calculate_block_end_address(baslangic_adresi, ofset_degeri, blok_boyutu)
print("Hesaplanmış Adres:", hex(hesaplanmis_adres))
