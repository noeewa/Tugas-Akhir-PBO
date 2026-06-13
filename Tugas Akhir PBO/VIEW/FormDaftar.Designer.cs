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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDaftar));
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // NamaBox
            // 
            NamaBox.BorderStyle = BorderStyle.FixedSingle;
            NamaBox.Location = new Point(506, 149);
            NamaBox.Margin = new Padding(3, 2, 3, 2);
            NamaBox.Name = "NamaBox";
            NamaBox.Size = new Size(249, 23);
            NamaBox.TabIndex = 2;
            // 
            // EmailBox
            // 
            EmailBox.BorderStyle = BorderStyle.FixedSingle;
            EmailBox.Location = new Point(506, 199);
            EmailBox.Margin = new Padding(3, 2, 3, 2);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(249, 23);
            EmailBox.TabIndex = 3;
            // 
            // PasswordBox
            // 
            PasswordBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordBox.Location = new Point(506, 252);
            PasswordBox.Margin = new Padding(3, 2, 3, 2);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(249, 23);
            PasswordBox.TabIndex = 4;
            PasswordBox.UseSystemPasswordChar = true;
            // 
            // VerifPasswordBox
            // 
            VerifPasswordBox.BorderStyle = BorderStyle.FixedSingle;
            VerifPasswordBox.Location = new Point(506, 307);
            VerifPasswordBox.Margin = new Padding(3, 2, 3, 2);
            VerifPasswordBox.Name = "VerifPasswordBox";
            VerifPasswordBox.Size = new Size(249, 23);
            VerifPasswordBox.TabIndex = 5;
            VerifPasswordBox.UseSystemPasswordChar = true;
            VerifPasswordBox.TextChanged += VerifPasswordBox_TextChanged;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.BackColor = Color.White;
            labelNama.Font = new Font("Calibri", 12F, FontStyle.Bold);
            labelNama.ForeColor = Color.Green;
            labelNama.Location = new Point(369, 148);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(121, 19);
            labelNama.TabIndex = 7;
            labelNama.Text = "Nama Pengguna";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.White;
            labelEmail.Font = new Font("Calibri", 12F, FontStyle.Bold);
            labelEmail.ForeColor = Color.Green;
            labelEmail.Location = new Point(369, 199);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 19);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.White;
            labelPassword.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.Green;
            labelPassword.Location = new Point(368, 251);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(120, 19);
            labelPassword.TabIndex = 9;
            labelPassword.Text = "Daftar Password";
            // 
            // labelVerifPassword
            // 
            labelVerifPassword.AutoSize = true;
            labelVerifPassword.BackColor = Color.White;
            labelVerifPassword.Font = new Font("Calibri", 12F, FontStyle.Bold);
            labelVerifPassword.ForeColor = Color.Green;
            labelVerifPassword.Location = new Point(367, 311);
            labelVerifPassword.Name = "labelVerifPassword";
            labelVerifPassword.Size = new Size(121, 19);
            labelVerifPassword.TabIndex = 10;
            labelVerifPassword.Text = "Ulangi Password";
            // 
            // button0
            // 
            button0.BackgroundImage = (Image)resources.GetObject("button0.BackgroundImage");
            button0.BackgroundImageLayout = ImageLayout.Zoom;
            button0.FlatAppearance.BorderSize = 0;
            button0.FlatStyle = FlatStyle.Flat;
            button0.Location = new Point(654, 454);
            button0.Margin = new Padding(3, 2, 3, 2);
            button0.Name = "button0";
            button0.Size = new Size(101, 43);
            button0.TabIndex = 15;
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(549, 454);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(88, 40);
            button1.TabIndex = 16;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(46, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 508);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(293, -44);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(601, 656);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(367, 360);
            label1.Name = "label1";
            label1.Size = new Size(80, 19);
            label1.TabIndex = 20;
            label1.Text = "Nomor HP";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(506, 361);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 23);
            textBox1.TabIndex = 21;
            textBox1.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(369, 408);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 22;
            label2.Text = "Alamat";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(506, 409);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 23);
            textBox2.TabIndex = 23;
            textBox2.UseSystemPasswordChar = true;
            // 
            // FormDaftar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 565);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
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
            Controls.Add(pictureBox2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDaftar";
            Text = "FormDaftar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
    }
}