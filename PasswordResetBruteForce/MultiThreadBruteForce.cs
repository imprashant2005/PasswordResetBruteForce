using System;
using System.Threading.Tasks;

namespace PasswordResetBruteForce
{
    internal class MultiThreadBruteForce
    {
        private PasswordValidator validator = new PasswordValidator();

        private volatile bool passwordFound = false;
        private string foundPassword = "";

        public string FindPassword(string targetHash)
        {
            int threadCount = Math.Max(1, Environment.ProcessorCount - 1);

            Task[] tasks = new Task[threadCount];

            string chars = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < threadCount; i++)
            {
                int threadIndex = i;

                tasks[i] = Task.Run(() =>
                {
                    BruteForceGenerator generator = new BruteForceGenerator();

                    foreach (string candidate in generator.Generate(6))
                    {
                        if (passwordFound)
                            return;

                        if ((candidate[0] - 'a') % threadCount != threadIndex)
                            continue;

                        if (validator.Validate(candidate, targetHash))
                        {
                            foundPassword = candidate;
                            passwordFound = true;
                            return;
                        }
                    }
                });
            }

            Task.WaitAll(tasks);

            return foundPassword;
        }
    }
}