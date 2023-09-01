def print_bits(data):

    for i in range(15, -1, -1):
        bit_value = (data >> i) & 1
        print(bit_value, end='')
    print()


def main():
    data_16_bit = 0x701F  # Örnek olarak 16 bit veri
    data_8_bit = 0x0B     # Örnek olarak 8 bit veri
    
    print_bits(data_16_bit)
    print_bits(data_8_bit)

if __name__ == "__main__":
    main()
