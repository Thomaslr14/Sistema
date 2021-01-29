using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows;

namespace systema.Classes
{
    public class Hash
    {
        public static string GenerateHash(string password)
        {

            using (SHA256 SHA256Hash = SHA256.Create())
            {
                byte[] bytes = SHA256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                return Convert.ToBase64String(bytes);
                
            }

            
            
        }

        public static string Enconding(string hash)
        {

            var salt = Salt.GetSalt();

            byte[] data = System.Text.Encoding.ASCII.GetBytes(salt + hash);
            data = System.Security.Cryptography.SHA256.Create().ComputeHash(data);
            MessageBox.Show(Convert.ToBase64String(data));
            return Convert.ToBase64String(data);

        }

      /*  public static byte[] _GenerateHash(string password)
        {
            using (SHA256 SHA256Hash = SHA256.Create())
            {
                byte[] bytes = SHA256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                return bytes;
            }
        }  */


    }
}
