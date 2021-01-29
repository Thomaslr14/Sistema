using System;
using System.Security.Cryptography;


namespace systema.Classes
{
    public class Salt
    {
       
        // Metodo Salt 
        public static byte[] GetSalt()
        {
            return _GetSalt(32);
        }

        private static byte[] _GetSalt(int maximumLengthLimit)
        {
            var salt = new byte[maximumLengthLimit];
            using (var random = new RNGCryptoServiceProvider())
            {
                random.GetNonZeroBytes(salt);
                
            }
            return salt;
        }


    }
}
