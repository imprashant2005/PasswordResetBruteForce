using System;

namespace PasswordResetBruteForce
{
    internal class SingleThreadBruteForce
    {
        private PasswordValidator validator = new PasswordValidator();
        private BruteForceGenerator generator = new BruteForceGenerator();

        public string FindPassword(string targetHash)
        {
            foreach (string candidate in generator.Generate(6))
            {
                if (validator.Validate(candidate, targetHash))
                {
                    return candidate;
                }
            }

            return "";
        }
    }
}