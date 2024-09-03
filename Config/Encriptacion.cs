using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;


namespace Login.Config
{
    class Encriptacion
    {
                                             //contraaenia         Este es el codigo
        public static string Encripta(string textoaencriptar, string codigosecreto) {

            byte[] dto = new byte[16];
            byte[] array;
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(codigosecreto);
                aes.IV = dto;

                ICryptoTransform cryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV);
                using (MemoryStream memoryStream = new MemoryStream()) {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, cryptoTransform, CryptoStreamMode.Write)) {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream)) {
                            streamWriter.Write(textoaencriptar);
                        }
                        array = memoryStream.ToArray();
                        
                    }
                }
            }
            return Convert.ToBase64String(array);
        }


    }
}
