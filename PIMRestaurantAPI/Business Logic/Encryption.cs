using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace PIMRestaurantAPI.Business_Logic
{
    public class Encryption
    {
        static string Inputkey = "256A18CD-6348-4CF0-DDE8-DDTVF9B6B9PIMPOS";

        public static string EncryptRijndael(string text)
        {
            var aesAlg = NewRijndaelManaged();
            var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            var msEncrypt = new MemoryStream();
            using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
            using (var swEncrypt = new StreamWriter(csEncrypt))
            {
                swEncrypt.Write(text);
            }
            return Convert.ToBase64String(msEncrypt.ToArray());
        }



        public static bool IsBase64String(string base64String)
        {
            base64String = base64String.Trim();
            return (base64String.Length % 4 == 0) && Regex.IsMatch(base64String, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);
        }



        public static string DecryptRijndael(string cipherText)
        {
            try
            {
                string text;
                var aesAlg = NewRijndaelManaged();
                var decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                var cipher = Convert.FromBase64String(cipherText);

                using (var msDecrypt = new MemoryStream(cipher))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new StreamReader(csDecrypt))
                        {
                            text = srDecrypt.ReadToEnd();
                        }
                    }
                }
                return text;
            }
            catch
            {
                return "";
            }
        }

        private static RijndaelManaged NewRijndaelManaged()
        {
            var saltBytes = Encoding.ASCII.GetBytes(Inputkey);
            var key = new Rfc2898DeriveBytes(Inputkey, saltBytes);
            var aesAlg = new RijndaelManaged();
            aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
            aesAlg.IV = key.GetBytes(aesAlg.BlockSize / 8);

            return aesAlg;
        }
    }
}
