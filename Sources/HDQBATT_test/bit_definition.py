from enum import IntEnum

class BitEnum(IntEnum):
    SE = 0
    FAS = 1
    SS = 2
    CALMODE = 3
    CCA = 4
    BCA = 5
    QMAXUPDATE = 6
    HOSTIE = 7
    SHUTDWN = 8
    HIBERNATE = 9
    FULLSLEEP = 10
    SLEEP = 11
    LDMD = 12
    RUP_DIS = 13
    VOK = 14
    QEN = 15

def check_bit(number, bit_position):
    return (number >> bit_position) & 1
    #return (number & (1 << bit_position)) != 0

data = 0x700F

for bit_position in range(16):
    bit=check_bit(data, bit_position)
    if bit :
        print(f"{BitEnum(bit_position).name} {bit}")
        if bit_position == 7:
            print("Toggle control 1 is triggered.")
            # Burada istediğiniz işlemi gerçekleştirebilirsiniz.
    else:
        print(f"{BitEnum(bit_position).name} {bit}")
