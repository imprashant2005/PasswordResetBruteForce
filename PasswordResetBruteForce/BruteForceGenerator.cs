using System.Collections.Generic;

namespace PasswordResetBruteForce
{
    internal class BruteForceGenerator
    {
        private const string chars = "abcdefghijklmnopqrstuvwxyz";

        public IEnumerable<string> Generate(int maxLength)
        {
            for (int length = 1; length <= maxLength; length++)
            {
                foreach (string s in GenerateRecursive("", length))
                {
                    yield return s;
                }
            }
        }

        private IEnumerable<string> GenerateRecursive(string prefix, int remaining)
        {
            if (remaining == 0)
            {
                yield return prefix;
                yield break;
            }

            foreach (char c in chars)
            {
                foreach (string s in GenerateRecursive(prefix + c, remaining - 1))
                {
                    yield return s;
                }
            }
        }
    }
}