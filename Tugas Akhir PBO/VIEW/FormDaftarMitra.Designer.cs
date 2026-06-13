namespace Tugas_Akhir_PBO.VIEW
{
    partial class FormDaftarMitra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDaftarMitra));
            JConsoleDaftar = new Label();
            labelAlamat = new Label();
            labelNomorHp = new Label();
            labelEmail = new Label();
            labelNama = new Label();
            AlamatTextBox = new RichTextBox();
            NomorHpBox = new TextBox();
            NamaBox = new TextBox();
            button1 = new Button();
            button0 = new Button();
            pictureBox1 = new PictureBox();
            UserDropDown = new ComboBox();
            label1 = new Label();
            JenisBox = new TextBox();
            Deskripsi = new Label();
            DeskripsiBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // JConsoleDaftar
            // 
            JConsoleDaftar.AutoSize = true;
            JConsoleDaftar.Font = new Font("Inter Tight ExtraBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JConsoleDaftar.Location = new Point(12, 9);
            JConsoleDaftar.Name = "JConsoleDaftar";
            JConsoleDaftar.Size = new Size(288, 40);
            JConsoleDaftar.TabIndex = 2;
            JConsoleDaftar.Text = "Console Daftar Mitra";
            // 
            // labelAlamat
            // 
            labelAlamat.AutoSize = true;
            labelAlamat.Location = new Point(51, 318);
            labelAlamat.Name = "labelAlamat";
            labelAlamat.Size = new Size(57, 20);
            labelAlamat.TabIndex = 19;
            labelAlamat.Text = "Alamat";
            // 
            // labelNomorHp
            // 
            labelNomorHp.AutoSize = true;
            labelNomorHp.Location = new Point(51, 264);
            labelNomorHp.Name = "labelNomorHp";
            labelNomorHp.Size = new Size(79, 20);
            labelNomorHp.TabIndex = 18;
            labelNomorHp.Text = "Nomor HP";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(51, 130);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(40, 20);
            labelEmail.TabIndex = 15;
            labelEmail.Text = "Jenis";
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(51, 77);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(88, 20);
            labelNama.TabIndex = 14;
            labelNama.Text = "Nama Mitra";
            // 
            // AlamatTextBox
            // 
            AlamatTextBox.BorderStyle = BorderStyle.FixedSingle;
            AlamatTextBox.Location = new Point(207, 318);
            AlamatTextBox.Name = "AlamatTextBox";
            AlamatTextBox.Size = new Size(284, 57);
            AlamatTextBox.TabIndex = 25;
            AlamatTextBox.Text = "";
            // 
            // NomorHpBox
            // 
            NomorHpBox.BorderStyle = BorderStyle.FixedSingle;
            NomorHpBox.Location = new Point(207, 264);
            NomorHpBox.Name = "NomorHpBox";
            NomorHpBox.Size = new Size(284, 27);
            NomorHpBox.TabIndex = 24;
            // 
            // NamaBox
            // 
            NamaBox.BorderStyle = BorderStyle.FixedSingle;
            NamaBox.Location = new Point(207, 77);
            NamaBox.Name = "NamaBox";
            NamaBox.Size = new Size(284, 27);
            NamaBox.TabIndex = 20;
            // 
            // button1
            // 
            button1.Location = new Point(550, 392);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 27;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button0
            // 
            button0.Location = new Point(650, 392);
            button0.Name = "button0";
            button0.Size = new Size(94, 29);
            button0.TabIndex = 26;
            button0.Text = "Daftarkan";
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
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // UserDropDown
            // 
            UserDropDown.FormattingEnabled = true;
            UserDropDown.Location = new Point(574, 325);
            UserDropDown.Name = "UserDropDown";
            UserDropDown.Size = new Size(151, 28);
            UserDropDown.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(574, 293);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 30;
            label1.Text = "Penanggung Jawab :";
            // 
            // JenisBox
            // 
            JenisBox.BorderStyle = BorderStyle.FixedSingle;
            JenisBox.Location = new Point(207, 123);
            JenisBox.Name = "JenisBox";
            JenisBox.Size = new Size(284, 27);
            JenisBox.TabIndex = 32;
            // 
            // Deskripsi
            // 
            Deskripsi.AutoSize = true;
            Deskripsi.Location = new Point(51, 185);
            Deskripsi.Name = "Deskripsi";
            Deskripsi.Size = new Size(69, 20);
            Deskripsi.TabIndex = 16;
            Deskripsi.Text = "Deskripsi";
            // 
            // DeskripsiBox
            // 
            DeskripsiBox.BorderStyle = BorderStyle.FixedSingle;
            DeskripsiBox.Location = new Point(207, 183);
            DeskripsiBox.Name = "DeskripsiBox";
            DeskripsiBox.Size = new Size(284, 57);
            DeskripsiBox.TabIndex = 33;
            DeskripsiBox.Text = "";
            // 
            // FormDaftarMitra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeskripsiBox);
            Controls.Add(JenisBox);
            Controls.Add(UserDropDown);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(button0);
            Controls.Add(AlamatTextBox);
            Controls.Add(NomorHpBox);
            Controls.Add(NamaBox);
            Controls.Add(labelAlamat);
            Controls.Add(labelNomorHp);
            Controls.Add(Deskripsi);
            Controls.Add(labelEmail);
            Controls.Add(labelNama);
            Controls.Add(JConsoleDaftar);
            Name = "FormDaftarMitra";
            Text = "DaftarMitra";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label JConsoleDaftar;
        private Label labelAlamat;
        private Label labelNomorHp;
        private Label labelEmail;
        private Label labelNama;
        private RichTextBox AlamatTextBox;
        private TextBox NomorHpBox;
        private TextBox NamaBox;
        private Button button1;
        private Button button0;
        private PictureBox pictureBox1;
        private ComboBox UserDropDown;
        private Label label1;
        private TextBox JenisBox;
        private Label Deskripsi;
        private RichTextBox DeskripsiBox;
    }
}