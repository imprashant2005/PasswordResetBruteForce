namespace PasswordResetBruteForce
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtPassword = new TextBox();
            btnGenerate = new Button();
            btnStart = new Button();
            btnStop = new Button();
            progressBar1 = new ProgressBar();
            lblTime = new Label();
            lblResult = new Label();
            txtPerformance = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 23);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Generated Password";
            label1.Click += label1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(325, 52);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(337, 81);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate Password";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(337, 110);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start Attack";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click_1;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(337, 139);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop Attack";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(325, 168);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 5;
            progressBar1.Click += progressBar1_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(325, 204);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(89, 15);
            lblTime.TabIndex = 6;
            lblTime.Text = "Elapsed Time: 0";
            lblTime.Click += lblTime_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(322, 228);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(117, 15);
            lblResult.TabIndex = 7;
            lblResult.Text = "Password Not Found";
            lblResult.Click += lblResult_Click_1;
            // 
            // txtPerformance
            // 
            txtPerformance.Location = new Point(277, 246);
            txtPerformance.Name = "txtPerformance";
            txtPerformance.Size = new Size(200, 120);
            txtPerformance.TabIndex = 8;
            txtPerformance.Text = "";
            txtPerformance.TextChanged += txtPerformance_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPerformance);
            Controls.Add(lblResult);
            Controls.Add(lblTime);
            Controls.Add(progressBar1);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(btnGenerate);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPassword;
        private Button btnGenerate;
        private Button btnStart;
        private Button btnStop;
        private ProgressBar progressBar1;
        private Label lblTime;
        private Label lblResult;
        private RichTextBox txtPerformance;
    }
}
