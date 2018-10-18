using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP.ServiceGates
{
    class AesCryptoProvider : ICryptor
    {
        public string Decrypt(string strEncryptedText)
        {
            //RijndaelManaged aes = new RijndaelManaged();
            //aes.BlockSize = 128;
            //aes.KeySize = 256;

            //aes.Mode = CipherMode.CBC;
            //aes.Padding = PaddingMode.PKCS7;

            //byte[] keyArr = Convert.FromBase64String(keyStr);
            //byte[] KeyArrBytes32Value = new byte[32];
            //Array.Copy(keyArr, KeyArrBytes32Value, 32);

            //byte[] IVBytes16Value = new byte[16];
            //Array.Copy(ivArr, IVBytes16Value, 16);

            //aes.Key = KeyArrBytes32Value;
            //aes.IV = IVBytes16Value;

            //ICryptoTransform decrypto = aes.CreateDecryptor();

            //byte[] encryptedBytes = Convert.FromBase64CharArray(strEncryptedText.ToCharArray(), 0, strEncryptedText.Length);
            //byte[] decryptedData = decrypto.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
            //return Encoding.UTF8.GetString(decryptedData);
            return null;
        }

        public string Encrypt(string strNormalText)
        {
            //RijndaelManaged aes = new RijndaelManaged();
            //aes.BlockSize = 128;
            //aes.KeySize = 256;
            //aes.Mode = CipherMode.CBC;
            //aes.Padding = PaddingMode.PKCS7;

            //byte[] keyArr = Convert.FromBase64String(keyStr);
            //byte[] KeyArrBytes32Value = new byte[32];
            //Array.Copy(keyArr, KeyArrBytes32Value, 32);
            //byte[] IVBytes16Value = new byte[16];
            //Array.Copy(ivArr, IVBytes16Value, 16);

            //aes.Key = KeyArrBytes32Value;
            //aes.IV = IVBytes16Value;

            //ICryptoTransform encrypto = aes.CreateEncryptor();

            //byte[] plainTextByte = Encoding.UTF8.GetBytes(strNormalText);
            //byte[] CipherText = encrypto.TransformFinalBlock(plainTextByte, 0, plainTextByte.Length);
            //return Convert.ToBase64String(CipherText);
            return null;
        }
    }
}
