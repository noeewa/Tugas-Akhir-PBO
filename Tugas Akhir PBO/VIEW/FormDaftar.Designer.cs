namespace Tugas_Akhir_PBO.VIEW
{
    partial class FormDaftar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            JConsoleDaftar = new Label();
            NamaBox = new TextBox();
            EmailBox = new TextBox();
            PasswordBox = new TextBox();
            VerifPasswordBox = new TextBox();
            labelNama = new Label();
            labelEmail = new Label();
            labelPassword = new Label();
            labelVerifPassword = new Label();
            button0 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // JConsoleDaftar
            // 
            JConsoleDaftar.AutoSize = true;
            JConsoleDaftar.Font = new Font("Inter Tight ExtraBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JConsoleDaftar.Location = new Point(12, 9);
            JConsoleDaftar.Name = "JConsoleDaftar";
            JConsoleDaftar.Size = new Size(215, 40);
            JConsoleDaftar.TabIndex = 1;
            JConsoleDaftar.Text = "Console Daftar";
            // 
            // NamaBox
            // 
            NamaBox.BorderStyle = BorderStyle.FixedSingle;
            NamaBox.Location = new Point(213, 67);
            NamaBox.Name = "NamaBox";
            NamaBox.Size = new Size(284, 27);
            NamaBox.TabIndex = 2;
            // 
            // EmailBox
            // 
            EmailBox.BorderStyle = BorderStyle.FixedSingle;
            EmailBox.Location = new Point(213, 120);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(284, 27);
            EmailBox.TabIndex = 3;
            // 
            // PasswordBox
            // 
            PasswordBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordBox.Location = new Point(213, 175);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(284, 27);
            PasswordBox.TabIndex = 4;
            PasswordBox.UseSystemPasswordChar = true;
            // 
            // VerifPasswordBox
            // 
            VerifPasswordBox.BorderStyle = BorderStyle.FixedSingle;
            VerifPasswordBox.Location = new Point(213, 229);
            VerifPasswordBox.Name = "VerifPasswordBox";
            VerifPasswordBox.Size = new Size(284, 27);
            VerifPasswordBox.TabIndex = 5;
            VerifPasswordBox.UseSystemPasswordChar = true;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(49, 67);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(118, 20);
            labelNama.TabIndex = 7;
            labelNama.Text = "Nama Pengguna";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(49, 120);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(49, 175);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(116, 20);
            labelPassword.TabIndex = 9;
            labelPassword.Text = "Daftar Password";
            // 
            // labelVerifPassword
            // 
            labelVerifPassword.AutoSize = true;
            labelVerifPassword.Location = new Point(49, 229);
            labelVerifPassword.Name = "labelVerifPassword";
            labelVerifPassword.Size = new Size(117, 20);
            labelVerifPassword.TabIndex = 10;
            labelVerifPassword.Text = "Ulangi Password";
            // 
            // button0
            // 
            button0.Location = new Point(652, 393);
            button0.Name = "button0";
            button0.Size = new Size(94, 29);
            button0.TabIndex = 15;
            button0.Text = "Daftarkan";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // button1
            // 
            button1.Location = new Point(552, 393);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormDaftar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button0);
            Controls.Add(labelVerifPassword);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(labelNama);
            Controls.Add(VerifPasswordBox);
            Controls.Add(PasswordBox);
            Controls.Add(EmailBox);
            Controls.Add(NamaBox);
            Controls.Add(JConsoleDaftar);
            Name = "FormDaftar";
            Text = "FormDaftar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label JConsoleDaftar;
        private TextBox NamaBox;
        private TextBox EmailBox;
        private TextBox PasswordBox;
        private TextBox VerifPasswordBox;
        private Label labelNama;
        private Label labelEmail;
        private Label labelPassword;
        private Label labelVerifPassword;
        private Button button0;
        private Button button1;
    }
}