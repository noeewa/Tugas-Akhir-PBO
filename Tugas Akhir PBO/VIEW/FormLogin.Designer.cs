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
            LoginButton = new Button();
            button1 = new Button();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(1038, 689);
            PasswordBox.Margin = new Padding(6, 4, 6, 4);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(401, 39);
            PasswordBox.TabIndex = 0;
            PasswordBox.UseSystemPasswordChar = true;
            PasswordBox.TextChanged += PasswordBox_TextChanged;
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(1038, 557);
            UsernameBox.Margin = new Padding(6, 4, 6, 4);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(401, 39);
            UsernameBox.TabIndex = 1;
            UsernameBox.TextChanged += UsernameBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(1038, 503);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 29);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(1044, 631);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 29);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.White;
            LoginButton.BackgroundImage = (Image)resources.GetObject("LoginButton.BackgroundImage");
            LoginButton.BackgroundImageLayout = ImageLayout.Zoom;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Location = new Point(1183, 759);
            LoginButton.Margin = new Padding(6, 4, 6, 4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(260, 83);
            LoginButton.TabIndex = 5;
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1038, 759);
            button1.Margin = new Padding(6, 4, 6, 4);
            button1.Name = "button1";
            button1.Size = new Size(134, 83);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-2, -9);
            pictureBox5.Margin = new Padding(6, 6, 6, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(800, 1231);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(726, -9);
            pictureBox6.Margin = new Padding(6, 6, 6, 6);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(1034, 1231);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1673, 1205);
            Controls.Add(LoginButton);
            Controls.Add(pictureBox5);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UsernameBox);
            Controls.Add(PasswordBox);
            Controls.Add(pictureBox6);
            Margin = new Padding(6, 4, 6, 4);
            Name = "FormLogin";
            Text = "Form1";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PasswordBox;
        private TextBox UsernameBox;
        private Label label1;
        private Label label2;
        private Button LoginButton;
        private Button button1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}
