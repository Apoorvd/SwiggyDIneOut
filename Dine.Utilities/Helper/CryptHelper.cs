using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dine.Utilities.Helper
{
    public class CryptHelper
    {
        public static string EncryptionHelper(String plaintext, string keyVal, string nonceVal)
        {
            byte[] key = Encoding.UTF8.GetBytes(keyVal);
            byte[] nonce = Encoding.UTF8.GetBytes(nonceVal);
            var output = Encrypt(plaintext, key, nonce);
            var result = Convert.ToBase64String(output.ElementAt(0).ToArray());
            result = result + Convert.ToBase64String(output.ElementAt(1).ToArray());
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(result));
        }
        private static List<List<byte>> Encrypt(string plaintext, byte[] key, byte[] nonce)
        {
            using (AesCcm aesCcm = new AesCcm(key))
            {
                byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintext);
                byte[] ciphertext = new byte[plaintextBytes.Length];
                byte[] authenticationTag = new byte[16];
                // Encrypt the plaintext
                //        public void Encrypt(byte[] nonce, byte[] plaintext, byte[] ciphertext, byte[] tag, byte[]? associatedData = null)

                aesCcm.Encrypt(nonce, plaintextBytes, ciphertext, authenticationTag);

                var output = new List<List<byte>>
                {
                    ciphertext.ToList(),
                    authenticationTag.ToList()
                };
                aesCcm.Dispose();
                return output;
            }
        }
        public static string DecryptionHelper(string EncryptString, string keyVal, string nonceVal)
        {
            byte[] key = Encoding.UTF8.GetBytes(keyVal);
            byte[] nonce = Encoding.UTF8.GetBytes(nonceVal);
            var ees = Convert.FromBase64String(EncryptString);
            var input = Encoding.UTF8.GetString(ees);
            byte[] ciphertext = Convert.FromBase64String(input.Substring(0, input.Length - 24));
            byte[] authTag = Convert.FromBase64String(input.Substring(input.Length - 24));
            return Decrypt(ciphertext, authTag, key, nonce);
        }
        private static string Decrypt(byte[] ciphertext, byte[] authTag, byte[] key, byte[] nonce)
        {
            using (AesCcm aesCcm = new AesCcm(key))
            {
                // Decrypt the ciphertext
                //public void Decrypt (byte[] nonce, byte[] ciphertext, byte[] tag, byte[] plaintext, byte[]? associatedData = default);
                byte[] plainetext = new byte[ciphertext.Length];
                aesCcm.Decrypt(nonce, ciphertext, authTag, plainetext);
                aesCcm.Dispose();
                return Encoding.UTF8.GetString(plainetext);
            }
        }
    }
}
