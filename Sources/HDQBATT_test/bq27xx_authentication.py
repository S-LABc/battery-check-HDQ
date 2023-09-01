import hashlib
import hmac

class FuelGaugeAuthentication:
    def __init__(self, key):
        self.key = key

    def calculate_hmac_sha1(self, message):
        hmac_sha1 = hmac.new(self.key, message, hashlib.sha1)
        return hmac_sha1.digest()


if __name__ == "__main__":
    default_key = bytes.fromhex("0123456789ABCDEFFEDCBA9876543210")
    fuel_gauge = FuelGaugeAuthentication(default_key)

    message = b"Sample Message"
    hmac_sha1_result = fuel_gauge.calculate_hmac_sha1(message)
    print(f"HMAC-SHA1: {hmac_sha1_result.hex()}")


