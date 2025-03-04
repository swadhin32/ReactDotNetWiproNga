using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptDecryptDemo
{
    internal class Program
    {
        public class EncryptionService
        {
            // Use a 32-byte key for AES-256 (32 characters, exactly 32 bytes)
            private readonly byte[] _key = Encoding.UTF8.GetBytes("b14ca5898a4e4133bbce2ea2315a1916"); // Must be 32 bytes
            private readonly byte[] _iv = Encoding.UTF8.GetBytes("ThisIsAnIV123456"); // Must be 16 bytes

            // Encrypt a plain text using AES encryption
            public string Encrypt(string plainText)
            {
                Aes aes = Aes.Create();
                aes.Key = _key;
                aes.IV = _iv;
                // Create an encryptor
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                MemoryStream msEncrypt = new MemoryStream();
                CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);
                StreamWriter swEncrypt = new StreamWriter(csEncrypt);

                swEncrypt.Write(plainText);
                swEncrypt.Flush();
                csEncrypt.FlushFinalBlock();

                string encryptedText = Convert.ToBase64String(msEncrypt.ToArray());

                // Close and dispose streams explicitly
                swEncrypt.Close();
                csEncrypt.Close();
                msEncrypt.Close();
                encryptor.Dispose();
                aes.Dispose();

                return encryptedText;
            }

            // Decrypt function
            public string Decrypt(string cipherText)
            {

                Aes aes = Aes.Create();
                aes.Key = _key;
                aes.IV = _iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText));
                CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
                StreamReader srDecrypt = new StreamReader(csDecrypt);

                string decryptedText = srDecrypt.ReadToEnd();

                // Close and dispose streams explicitly
                srDecrypt.Close();
                csDecrypt.Close();
                msDecrypt.Close();
                decryptor.Dispose();
                aes.Dispose();

                return decryptedText;
            }
        }

        static void Main(string[] args)
        {
            // Create an instance of the ecryption service
            EncryptionService encryptionService = new EncryptionService();

            Console.WriteLine("Enter the message to encrypt:");
            string plainText = Console.ReadLine();

            // Encrypt the message
            string encryptedText = encryptionService.Encrypt(plainText);
            Console.WriteLine("Encrypted Message: " + encryptedText);

            // Decrypt the message
            string decryptedText = encryptionService.Decrypt(encryptedText);
            Console.WriteLine("Decrypted Message: " + decryptedText);

            Console.ReadLine();
        }
    }
}
