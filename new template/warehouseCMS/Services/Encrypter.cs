using System;
using System.Security.Cryptography;

namespace warehouseCMS.Services
{
    public class Encrypter : IEncrypter
    {
        private static readonly int SaltSize = 40;
        private static readonly int DeriveBytesIntegarationsCount = 10000;
        
        public string GetHash(string value, string salt)
        {
            var pbkdf2 = new Rfc2898DeriveBytes(value, GetBytes(salt), DeriveBytesIntegarationsCount);
            return Convert.ToBase64String(pbkdf2.GetBytes(SaltSize));
        }

        public string GetSalt(string value)
        {
            var random = new Random();
            var saltByte = new byte[SaltSize];
            var rng = RandomNumberGenerator.Create();
            rng.GetBytes(saltByte);
            return Convert.ToBase64String(saltByte);
        }

        private static byte[] GetBytes(string value)
        {
            var bytes = new byte[value.Length*sizeof(char)];
            Buffer.BlockCopy(value.ToCharArray(),0, bytes,0 ,bytes.Length);
            return bytes;
        }
    }
}