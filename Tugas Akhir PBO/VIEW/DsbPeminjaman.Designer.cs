namespace Tugas_Akhir_PBO.VIEW
{
    partial class DsbPeminjaman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DsbPeminjaman));
            JadwalLabel = new Label();
            dataGridUser = new DataGridView();
            JudulBesar0 = new Label();
            bRefresh = new Button();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // JadwalLabel
            // 
            JadwalLabel.AutoSize = true;
            JadwalLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JadwalLabel.Location = new Point(12, 65);
            JadwalLabel.Name = "JadwalLabel";
            JadwalLabel.Size = new Size(109, 20);
            JadwalLabel.TabIndex = 19;
            JadwalLabel.Text = "Alat Dipinjam";
            // 
            // dataGridUser
            // 
            dataGridUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUser.Location = new Point(12, 92);
            dataGridUser.Name = "dataGridUser";
            dataGridUser.RowHeadersWidth = 51;
            dataGridUser.Size = new Size(776, 293);
            dataGridUser.TabIndex = 18;
            // 
            // JudulBesar0
            // 
            JudulBesar0.AutoSize = true;
            JudulBesar0.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JudulBesar0.Location = new Point(12, 9);
            JudulBesar0.Name = "JudulBesar0";
            JudulBesar0.Size = new Size(166, 32);
            JudulBesar0.TabIndex = 20;
            JudulBesar0.Text = "List Jadwal";
            // 
            // bRefresh
            // 
            bRefresh.Location = new Point(673, 391);
            bRefresh.Name = "bRefresh";
            bRefresh.Size = new Size(93, 29);
            bRefresh.TabIndex = 30;
            bRefresh.Text = "Refresh";
            bRefresh.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(466, 391);
            button1.Name = "button1";
            button1.Size = new Size(163, 29);
            button1.TabIndex = 32;
            button1.Text = "Detail Peminjaman";
            button1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.White;
            linkLabel1.Location = new Point(557, 8);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(40, 20);
            linkLabel1.TabIndex = 31;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 416);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // DsbJadwal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(bRefresh);
            Controls.Add(JudulBesar0);
            Controls.Add(JadwalLabel);
            Controls.Add(dataGridUser);
            Name = "DsbJadwal";
            Text = "DsbJadwal";
            ((System.ComponentModel.ISupportInitialize)dataGridUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label JadwalLabel;
        private DataGridView dataGridUser;
        private Label JudulBesar0;
        private Button bRefresh;
        private Button button1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}