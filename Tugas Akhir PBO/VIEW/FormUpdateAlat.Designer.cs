namespace Tugas_Akhir_PBO.VIEW
{
    partial class FormUpdateAlat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateAlat));
            JConsoleDaftar = new Label();
            comboBox1 = new ComboBox();
            AlamatTextBox = new RichTextBox();
            PasswordBox = new TextBox();
            labelVerifPassword = new Label();
            labelPassword = new Label();
            labelEmail = new Label();
            labelPilih = new Label();
            button1 = new Button();
            button0 = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // JConsoleDaftar
            // 
            JConsoleDaftar.AutoSize = true;
            JConsoleDaftar.Font = new Font("Inter Tight ExtraBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JConsoleDaftar.Location = new Point(12, 9);
            JConsoleDaftar.Name = "JConsoleDaftar";
            JConsoleDaftar.Size = new Size(172, 40);
            JConsoleDaftar.TabIndex = 3;
            JConsoleDaftar.Text = "Update Alat";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(464, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(194, 28);
            comboBox1.TabIndex = 34;
            // 
            // AlamatTextBox
            // 
            AlamatTextBox.BorderStyle = BorderStyle.FixedSingle;
            AlamatTextBox.Location = new Point(452, 166);
            AlamatTextBox.Name = "AlamatTextBox";
            AlamatTextBox.Size = new Size(284, 57);
            AlamatTextBox.TabIndex = 33;
            AlamatTextBox.Text = "";
            // 
            // PasswordBox
            // 
            PasswordBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordBox.Location = new Point(464, 148);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(284, 27);
            PasswordBox.TabIndex = 32;
            PasswordBox.UseSystemPasswordChar = true;
            // 
            // labelVerifPassword
            // 
            labelVerifPassword.AutoSize = true;
            labelVerifPassword.BackColor = Color.White;
            labelVerifPassword.Location = new Point(367, 168);
            labelVerifPassword.Name = "labelVerifPassword";
            labelVerifPassword.Size = new Size(76, 20);
            labelVerifPassword.TabIndex = 30;
            labelVerifPassword.Text = "Deskripsi :";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.White;
            labelPassword.Location = new Point(379, 148);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(65, 20);
            labelPassword.TabIndex = 29;
            labelPassword.Text = "Kondisi :";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.White;
            labelEmail.Location = new Point(379, 97);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(73, 20);
            labelEmail.TabIndex = 28;
            labelEmail.Text = "Kategori :";
            labelEmail.Click += labelEmail_Click;
            // 
            // labelPilih
            // 
            labelPilih.AutoSize = true;
            labelPilih.Location = new Point(12, 56);
            labelPilih.Name = "labelPilih";
            labelPilih.Size = new Size(37, 20);
            labelPilih.TabIndex = 27;
            labelPilih.Text = "Pilih";
            // 
            // button1
            // 
            button1.Location = new Point(537, 285);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 36;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            button0.Location = new Point(637, 285);
            button0.Name = "button0";
            button0.Size = new Size(94, 29);
            button0.TabIndex = 35;
            button0.Text = "Update";
            button0.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(355, 244);
            dataGridView1.TabIndex = 37;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(65, 249);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 27);
            textBox1.TabIndex = 39;
            textBox1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(6, 247);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 38;
            label1.Text = "Search";
            // 
            // button2
            // 
            button2.Location = new Point(270, 249);
            button2.Name = "button2";
            button2.Size = new Size(85, 29);
            button2.TabIndex = 40;
            button2.Text = "Cari";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 415);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(452, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(284, 27);
            textBox2.TabIndex = 44;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(367, 118);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 43;
            label2.Text = "Status :";
            // 
            // FormUpdateAlat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(PasswordBox);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(labelPilih);
            Controls.Add(JConsoleDaftar);
            Name = "FormUpdateAlat";
            Text = "FormUpdateStatus";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label JConsoleDaftar;
        private ComboBox comboBox1;
        private RichTextBox AlamatTextBox;
        private TextBox PasswordBox;
        private Label labelVerifPassword;
        private Label labelPassword;
        private Label labelEmail;
        private Label labelPilih;
        private Button button1;
        private Button button0;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Label label2;
    }
}