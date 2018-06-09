using System;
using System.Text;
using System.Security.Cryptography;

namespace ShopLibrary.Models {
    public static class AES {
        public static string GetSalt(int saltLength = 32) {
            var salt = new byte[saltLength];
            using (var random = new RNGCryptoServiceProvider()) {
                random.GetNonZeroBytes(salt);
            }
            return Convert.ToBase64String(salt);
        }

        public static string Encrypt(string raw, string salt)
        {
            var textBytes             = Encoding.ASCII.GetBytes(raw);
            var aes = new AesCryptoServiceProvider {
                BlockSize = 128,
                KeySize = 256,
                Key = Encoding.ASCII.GetBytes("EnCt2a4baea437f621aad2d5728f599b"),
                IV = Encoding.ASCII.GetBytes("BngZmDHZTpqtuapv"),
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.CBC
            };

            var icrypt = aes.CreateEncryptor(aes.Key, aes.IV);

            var enc = icrypt.TransformFinalBlock(textBytes, 0, textBytes.Length);
            icrypt.Dispose();

            return Convert.ToBase64String(enc);
        }
    }
}
