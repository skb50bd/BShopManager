using System;
using System.Text;
using System.Security.Cryptography;

namespace ShopLibrary.Models {
    public static class AES {
        public static string GetSalt(int saltLength = 32) {
            byte[] salt = new byte[saltLength];
            using (RNGCryptoServiceProvider random = new RNGCryptoServiceProvider()) {
                random.GetNonZeroBytes(salt);
            }
            return Convert.ToBase64String(salt);
        }

        public static string Encrypt(string raw, string salt)
        {
            byte[] textBytes             = Encoding.ASCII.GetBytes(raw);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize                = 128;
            aes.KeySize                  = 256;
            aes.Key                      = Encoding.ASCII.GetBytes("EnCt2a4baea437f621aad2d5728f599b");
            aes.IV                       = Encoding.ASCII.GetBytes("BngZmDHZTpqtuapv");
            aes.Padding                  = PaddingMode.PKCS7;
            aes.Mode                     = CipherMode.CBC;

            ICryptoTransform icrypt = aes.CreateEncryptor(aes.Key, aes.IV);

            byte[] enc = icrypt.TransformFinalBlock(textBytes, 0, textBytes.Length);
            icrypt.Dispose();

            return Convert.ToBase64String(enc);
        }
    }
}
