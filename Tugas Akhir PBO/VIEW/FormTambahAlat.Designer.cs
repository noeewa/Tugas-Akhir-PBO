namespace Tugas_Akhir_PBO.VIEW
{
    partial class FormTambahAlat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahAlat));
            JConsoleDaftar = new Label();
            labelVerifPassword = new Label();
            labelPassword = new Label();
            labelEmail = new Label();
            labelNama = new Label();
            DeskripsiText = new RichTextBox();
            KondisiBox = new TextBox();
            NamaBox = new TextBox();
            KategoriCBox = new ComboBox();
            button1 = new Button();
            button0 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // JConsoleDaftar
            // 
            JConsoleDaftar.AutoSize = true;
            JConsoleDaftar.Font = new Font("Inter Tight ExtraBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JConsoleDaftar.Location = new Point(12, 9);
            JConsoleDaftar.Name = "JConsoleDaftar";
            JConsoleDaftar.Size = new Size(183, 40);
            JConsoleDaftar.TabIndex = 2;
            JConsoleDaftar.Text = "Tambah Alat";
            // 
            // labelVerifPassword
            // 
            labelVerifPassword.AutoSize = true;
            labelVerifPassword.Location = new Point(52, 234);
            labelVerifPassword.Name = "labelVerifPassword";
            labelVerifPassword.Size = new Size(69, 20);
            labelVerifPassword.TabIndex = 17;
            labelVerifPassword.Text = "Deskripsi";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(52, 185);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(58, 20);
            labelPassword.TabIndex = 16;
            labelPassword.Text = "Kondisi";
            labelPassword.Click += labelPassword_Click;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(52, 130);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(66, 20);
            labelEmail.TabIndex = 15;
            labelEmail.Text = "Kategori";
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(52, 77);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(80, 20);
            labelNama.TabIndex = 14;
            labelNama.Text = "Nama Alat";
            // 
            // DeskripsiText
            // 
            DeskripsiText.BorderStyle = BorderStyle.FixedSingle;
            DeskripsiText.Location = new Point(216, 234);
            DeskripsiText.Name = "DeskripsiText";
            DeskripsiText.Size = new Size(284, 57);
            DeskripsiText.TabIndex = 25;
            DeskripsiText.Text = "";
            // 
            // KondisiBox
            // 
            KondisiBox.BorderStyle = BorderStyle.FixedSingle;
            KondisiBox.Location = new Point(216, 185);
            KondisiBox.Name = "KondisiBox";
            KondisiBox.Size = new Size(284, 27);
            KondisiBox.TabIndex = 22;
            // 
            // NamaBox
            // 
            NamaBox.BorderStyle = BorderStyle.FixedSingle;
            NamaBox.Location = new Point(216, 77);
            NamaBox.Name = "NamaBox";
            NamaBox.Size = new Size(284, 27);
            NamaBox.TabIndex = 20;
            // 
            // KategoriCBox
            // 
            KategoriCBox.FormattingEnabled = true;
            KategoriCBox.Location = new Point(216, 130);
            KategoriCBox.Name = "KategoriCBox";
            KategoriCBox.Size = new Size(194, 28);
            KategoriCBox.TabIndex = 26;
            // 
            // button1
            // 
            button1.Location = new Point(526, 370);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 28;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button0
            // 
            button0.Location = new Point(626, 370);
            button0.Name = "button0";
            button0.Size = new Size(94, 29);
            button0.TabIndex = 27;
            button0.Text = "Tambah";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 413);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // FormTambahAlat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(button0);
            Controls.Add(KategoriCBox);
            Controls.Add(DeskripsiText);
            Controls.Add(KondisiBox);
            Controls.Add(NamaBox);
            Controls.Add(labelVerifPassword);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(labelNama);
            Controls.Add(JConsoleDaftar);
            Name = "FormTambahAlat";
            Text = "FormTambahAlat";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label JConsoleDaftar;
        private Label labelVerifPassword;
        private Label labelPassword;
        private Label labelEmail;
        private Label labelNama;
        private RichTextBox DeskripsiText;
        private TextBox KondisiBox;
        private TextBox NamaBox;
        private ComboBox KategoriCBox;
        private Button button1;
        private Button button0;
        private PictureBox pictureBox1;
    }
}