namespace Tugas_Akhir_PBO
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            PasswordBox = new TextBox();
            UsernameBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            LoginButton = new Button();
            button1 = new Button();
            JConsoleDaftar = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(270, 247);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(249, 27);
            PasswordBox.TabIndex = 0;
            PasswordBox.UseSystemPasswordChar = true;
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(270, 193);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(248, 27);
            UsernameBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 171);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 224);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(270, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(425, 302);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(272, 302);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // JConsoleDaftar
            // 
            JConsoleDaftar.AutoSize = true;
            JConsoleDaftar.Font = new Font("Inter Tight", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JConsoleDaftar.Location = new Point(12, 9);
            JConsoleDaftar.Name = "JConsoleDaftar";
            JConsoleDaftar.Size = new Size(58, 26);
            JConsoleDaftar.TabIndex = 7;
            JConsoleDaftar.Text = "Login";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(JConsoleDaftar);
            Controls.Add(button1);
            Controls.Add(LoginButton);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UsernameBox);
            Controls.Add(PasswordBox);
            Name = "FormLogin";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PasswordBox;
        private TextBox UsernameBox;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button LoginButton;
        private Button button1;
        private Label JConsoleDaftar;
    }
}
