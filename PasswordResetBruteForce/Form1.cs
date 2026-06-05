// Version 2 - Single Thread Brute Force Completed
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

            txtPerformance.Text =
                "Generated Password: " + currentPassword +
                Environment.NewLine +
                Environment.NewLine +
                "Hash Created Successfully";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            SingleThreadBruteForce bruteForce =
                new SingleThreadBruteForce();

            string foundPassword =
                bruteForce.FindPassword(currentHash);

            stopwatch.Stop();

            lblResult.Text =
                "Found Password: " + foundPassword;

            lblTime.Text =
                "Elapsed Time: " +
                stopwatch.ElapsedMilliseconds +
                " ms";

            txtPerformance.Text =
                "Original Password: " + currentPassword +
                Environment.NewLine +
                "Found Password: " + foundPassword +
                Environment.NewLine +
                "Time: " +
                stopwatch.ElapsedMilliseconds +
                " ms";
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            btnStart_Click(sender, e);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

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
    }
}