import os
import sys
from Crypto.PublicKey import RSA
from Crypto.Cipher import AES, PKCS1_OAEP

def decrypt_data(path,file_name,private_key):
    if(os.path.exists(path) == True and os.path.isfile(path+'/'+file_name) == True):
        # open the file that been dencrypt
        rename_str = path+'/'+file_name[:-6]
        file_source = open(path+'/'+file_name, "rb")
        file_out = open(rename_str, "wb")
        
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
        os.remove(path+'/'+file_name)
        
def get_session_key():
    status = 0
    try:
        private_key = RSA.import_key(open("./en/object.dump").read())
        os.remove("./en/object.dump")
    except OSError as err:
        status = 2
    except FileNotFoundError:
        status = 3
    except:
        status = 4
    return [private_key,status]

def start_decrypt_walk_file(main_path):
    private_key,status = get_session_key()
    if(status == 0 and os.path.exists(main_path) and os.path.isdir(main_path)):
        for dirPath, dirNames, fileNames in os.walk(main_path):
            for f in fileNames:
                if(len( f ) >= 6 and f[:-6] == ".fiden"):
                    decrypt_data(dirPath,f,private_key)
    return status
                    
def start_decrypt_file(main_path,file_name):
    private_key,status = get_session_key()
    if(status == 0)
        decrypt_data(main_path,file_name,private_key)
    return status
    
def main():
    status = 0
    if(len(sys.argv) == 2):
        main_path = (sys.argv[1])
        status = start_decrypt_walk_file(main_path)
    elif(len(sys.argv) == 3):
        main_path = sys.argv[1]
        file_name = sys.argv[2]
        status = start_decrypt_file(main_path,file_name)
    else:
        status = 1
    return status

if __name__ == "__main__":
    # execute only if run as a script
    sys.exit(main())