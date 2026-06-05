using System;

namespace PasswordResetBruteForce
{
    internal class PasswordValidator
    {
        private PasswordHasher hasher = new PasswordHasher();

        public bool Validate(string candidate, string targetHash)
        {
            string candidateHash = hasher.HashPassword(candidate);

            return candidateHash == targetHash;
        }
    }
}