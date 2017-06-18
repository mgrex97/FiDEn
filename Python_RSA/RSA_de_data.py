import os
import sys
from Crypto.PublicKey import RSA
from Crypto.Cipher import AES, PKCS1_OAEP

def decrypt_data(path,file_name,private_key):
    if(os.path.exists(path) == True and os.path.isfile(path+'/'+file_name) == True):
        # open the file that been dencrypt
        rename_str = path+'/'+file_name+".temp"
        os.rename(path+'/'+file_name,rename_str)
        file_source = open(rename_str, "rb")
        file_out = open(path+'/'+file_name, "wb")
        
        enc_session_key, nonce, tag, ciphertext = \
            [ file_source.read(x) for x in (private_key.size_in_bytes(), 16, 16, -1) ]
        # Decrypt the session key with the public RSA key
        cipher_rsa = PKCS1_OAEP.new(private_key)
        session_key = cipher_rsa.decrypt(enc_session_key)

        # Decrypt the data with the AES session key
        cipher_aes = AES.new(session_key, AES.MODE_EAX, nonce)
        data = cipher_aes.decrypt_and_verify(ciphertext, tag)
        file_out.write(data)
        file_out.close()
        file_source.close()
        os.remove(rename_str)
        
def get_session_key():
    private_key = RSA.import_key(open("private.pem").read())
    return private_key

def start_decrypt(main_path):
    private_key = get_session_key()
    if(os.path.exists(main_path) and os.path.isdir(main_path)):
        for dirPath, dirNames, fileNames in os.walk(main_path):
            for f in fileNames:
                decrypt_data(dirPath,f,private_key)

def main():
    if(len(sys.argv) == 2):
        main_path = sys.argv[1]
        start_decrypt(main_path)
        return 0
    else:
        print("傳入參數有誤")
        return 1

if __name__ == "__main__":
    # execute only if run as a script
    sys.exit(main())