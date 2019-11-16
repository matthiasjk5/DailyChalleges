using System;
using System.Security.Cryptography;

namespace EncryptDecrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new byte[] { 1, 2, 3 };
            var (publicKey, privateKey) = GenerateKeys(2048);

            var encryptedData = Encrypt(data, publicKey);
            var decryptedData = Decrypt(encryptedData, privateKey);
        }

        static (RSAParameters publicKey, RSAParameters privateKey) GenerateKeys(int keyLength)
        {
            using (var rsa = RSA.Create())
            {
                rsa.KeySize = keyLength;
                return (
                    publicKey: rsa.ExportParameters(includePrivateParameters: false),
                    privateKey: rsa.ExportParameters(includePrivateParameters: true)
                );
            }
        }

        static byte[] Encrypt(byte[] data, RSAParameters publicKey)
        {
            using (var rsa = RSA.Create())
            {
                rsa.ImportParameters(publicKey);

                var result = rsa.Encrypt(data, RSAEncryptionPadding.OaepSHA256);
                return result;
            }
        }

        static byte[] Decrypt(byte[] data, RSAParameters privateKey)
        {
            using (var rsa = RSA.Create())
            {
                rsa.ImportParameters(privateKey);
                return rsa.Decrypt(data, RSAEncryptionPadding.OaepSHA256);
            }
        }
    }
}
