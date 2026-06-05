using System;

namespace PasswordResetBruteForce
{
    internal class PasswordGenerator
    {
        private Random random = new Random();

        private const string chars = "abcdefghijklmnopqrstuvwxyz";

        public string GeneratePassword()
        {
            int length = random.Next(4, 6);

            char[] password = new char[length];

            for (int i = 0; i < length; i++)
            {
                password[i] = chars[random.Next(chars.Length)];
            }

            return new string(password);
        }
    }
}