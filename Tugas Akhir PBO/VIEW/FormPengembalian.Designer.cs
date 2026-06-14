namespace Tugas_Akhir_PBO.VIEW
{
    partial class FormPengembalian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPengembalian));
            JConsoleRiwayat = new Label();
            labelEmail = new Label();
            labelNama = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label0 = new Label();
            dataGridView2 = new DataGridView();
            LoginButton = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // JConsoleRiwayat
            // 
            JConsoleRiwayat.AutoSize = true;
            JConsoleRiwayat.Font = new Font("Inter Tight ExtraBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JConsoleRiwayat.Location = new Point(12, 7);
            JConsoleRiwayat.Name = "JConsoleRiwayat";
            JConsoleRiwayat.Size = new Size(278, 40);
            JConsoleRiwayat.TabIndex = 2;
            JConsoleRiwayat.Text = "Form Pengembalian";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.White;
            labelEmail.Location = new Point(174, 63);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(125, 20);
            labelEmail.TabIndex = 13;
            labelEmail.Text = "Rencana Datang :";
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.BackColor = Color.White;
            labelNama.Location = new Point(174, 18);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(79, 20);
            labelNama.TabIndex = 12;
            labelNama.Text = "Pilih Alat : ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(315, 18);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(284, 28);
            comboBox1.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(315, 63);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.Font = new Font("Inter Tight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label0.Location = new Point(12, 47);
            label0.Name = "label0";
            label0.Size = new Size(67, 24);
            label0.TabIndex = 32;
            label0.Text = "List Alat";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 74);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(776, 135);
            dataGridView2.TabIndex = 31;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(666, 359);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 33;
            LoginButton.Text = "Ajukan";
            LoginButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(562, 359);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 34;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 413);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // FormPengembalian
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(LoginButton);
            Controls.Add(label0);
            Controls.Add(dataGridView2);
            Controls.Add(JConsoleRiwayat);
            Name = "FormPengembalian";
            Text = "FormPengembalian";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label JConsoleRiwayat;
        private Label labelEmail;
        private Label labelNama;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label0;
        private DataGridView dataGridView2;
        private Button LoginButton;
        private Button button1;
        private PictureBox pictureBox1;
    }
}