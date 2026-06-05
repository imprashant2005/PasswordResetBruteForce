using System.Security.Cryptography;
using System.Text;

namespace PasswordResetBruteForce
{
    internal class PasswordHasher
    {
        private const string SALT = "ITM2025";

        public string HashPassword(string password)
        {
            string saltedPassword = password + SALT;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(saltedPassword);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();

                foreach (byte b in hash)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}