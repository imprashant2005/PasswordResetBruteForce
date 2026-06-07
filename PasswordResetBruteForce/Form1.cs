// Version 2 - Single Thread and Multi Thread Brute Force

using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PasswordResetBruteForce
{
    public partial class Form1 : Form
    {
        private string currentPassword = "";
        private string currentHash = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            PasswordGenerator generator = new PasswordGenerator();

            currentPassword = generator.GeneratePassword();

            txtPassword.Text = currentPassword;

            PasswordHasher hasher = new PasswordHasher();

            currentHash = hasher.HashPassword(currentPassword);

            progressBar1.Value = 0;

            txtPerformance.Text =
                "Generated Password: " + currentPassword +
                Environment.NewLine +
                Environment.NewLine +
                "Hash Created Successfully";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            // Single Thread Test
            Stopwatch singleWatch = new Stopwatch();

            singleWatch.Start();

            SingleThreadBruteForce single =
                new SingleThreadBruteForce();

            string singleResult =
                single.FindPassword(currentHash);

            singleWatch.Stop();

            progressBar1.Value = 50;

            // Multi Thread Test
            Stopwatch multiWatch = new Stopwatch();

            multiWatch.Start();

            MultiThreadBruteForce multi =
                new MultiThreadBruteForce();

            string multiResult =
                multi.FindPassword(currentHash);

            multiWatch.Stop();

            progressBar1.Value = 100;

            lblResult.Text =
                "Found Password: " + multiResult;

            lblTime.Text =
                "Elapsed Time: " +
                multiWatch.ElapsedMilliseconds +
                " ms";

            double speedup =
                (double)singleWatch.ElapsedMilliseconds /
                Math.Max(1, multiWatch.ElapsedMilliseconds);

            txtPerformance.Text =
                "Original Password: " + currentPassword +
                Environment.NewLine +
                Environment.NewLine +
                "Single Thread Time: " +
                singleWatch.ElapsedMilliseconds + " ms" +
                Environment.NewLine +
                Environment.NewLine +
                "Multi Thread Time: " +
                multiWatch.ElapsedMilliseconds + " ms" +
                Environment.NewLine +
                Environment.NewLine +
                "Speedup: " +
                speedup.ToString("0.00") + "x";
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            btnStart_Click(sender, e);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

            lblResult.Text = "Password Not Found";
            lblTime.Text = "Elapsed Time: 0";

            txtPerformance.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click_1(object sender, EventArgs e)
        {

        }

        private void txtPerformance_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}