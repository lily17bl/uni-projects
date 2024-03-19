using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Encryption
{
    internal class Encryption
    {
        public Encryption() { }

        public string CaesarMethod (string message)
        {
            string newStr = string.Empty;

            foreach (char c in message)
            {
                var asciiValue = (int)c;

                if (asciiValue <= 35)
                {
                    asciiValue -= 3;
                    asciiValue += 94;
                }
                else
                {
                    asciiValue -= 3;
                }

                newStr += Convert.ToChar(asciiValue);
            }

            return newStr;
        }

        public string AESMethod (string message)
        {
            string key = "MySecretKey123/!";

            byte[] encryptedBytes;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[16];

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(message);
                        }
                        encryptedBytes = msEncrypt.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(encryptedBytes);
        }

        public string ECDsaMethod(string message)
        {
            using (ECDsa ecdsa = ECDsa.Create())
            {
                byte[] publicKey = ecdsa.ExportSubjectPublicKeyInfo();
                byte[] privateKey = ecdsa.ExportPkcs8PrivateKey();

                byte[] menssageBytes = Encoding.UTF8.GetBytes(message);
                byte[] firma = SignMessage(ecdsa, message);

                bool verified = VerifySign(publicKey, message, firma);

                return "Firma Verificada";
            }

            static byte[] SignMessage(ECDsa ecdsa, string mensaje)
            {
                byte[] mensajeBytes = Encoding.UTF8.GetBytes(mensaje);
                return ecdsa.SignData(mensajeBytes, HashAlgorithmName.SHA256);
            }

            static bool VerifySign(byte[] publicKey, string mensaje, byte[] firma)
            {
                using (ECDsa ecdsa = ECDsa.Create())
                {
                    ecdsa.ImportSubjectPublicKeyInfo(publicKey, out _);
                    byte[] mensajeBytes = Encoding.UTF8.GetBytes(mensaje);
                    return ecdsa.VerifyData(mensajeBytes, firma, HashAlgorithmName.SHA256);
                }
            }
        }
    }
}
