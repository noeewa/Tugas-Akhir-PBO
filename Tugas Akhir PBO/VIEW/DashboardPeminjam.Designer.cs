namespace Tugas_Akhir_PBO.VIEW
{
    partial class DashboardPeminjam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardPeminjam));
            JConsolePenyewa = new Label();
            dataGridUser = new DataGridView();
            JadwalLabel = new Label();
            bPinjam = new Button();
            bBatalkan = new Button();
            bPengembalian = new Button();
            linkLabel3 = new LinkLabel();
            linkLabel5 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // JConsolePenyewa
            // 
            JConsolePenyewa.AutoSize = true;
            JConsolePenyewa.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JConsolePenyewa.Location = new Point(11, 9);
            JConsolePenyewa.Name = "JConsolePenyewa";
            JConsolePenyewa.Size = new Size(258, 32);
            JConsolePenyewa.TabIndex = 1;
            JConsolePenyewa.Text = "Console Penyewa";
            // 
            // dataGridUser
            // 
            dataGridUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUser.Location = new Point(200, 80);
            dataGridUser.Name = "dataGridUser";
            dataGridUser.RowHeadersWidth = 51;
            dataGridUser.Size = new Size(776, 291);
            dataGridUser.TabIndex = 16;
            // 
            // JadwalLabel
            // 
            JadwalLabel.AutoSize = true;
            JadwalLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JadwalLabel.Location = new Point(200, 49);
            JadwalLabel.Name = "JadwalLabel";
            JadwalLabel.Size = new Size(61, 20);
            JadwalLabel.TabIndex = 17;
            JadwalLabel.Text = "Jadwal";
            // 
            // bPinjam
            // 
            bPinjam.BackColor = Color.White;
            bPinjam.BackgroundImage = (Image)resources.GetObject("bPinjam.BackgroundImage");
            bPinjam.BackgroundImageLayout = ImageLayout.Zoom;
            bPinjam.FlatAppearance.BorderSize = 0;
            bPinjam.FlatStyle = FlatStyle.Flat;
            bPinjam.Location = new Point(668, 400);
            bPinjam.Name = "bPinjam";
            bPinjam.Size = new Size(118, 38);
            bPinjam.TabIndex = 18;
            bPinjam.UseVisualStyleBackColor = false;
            bPinjam.Click += bPinjam_Click;
            // 
            // bBatalkan
            // 
            bBatalkan.BackColor = Color.White;
            bBatalkan.BackgroundImage = (Image)resources.GetObject("bBatalkan.BackgroundImage");
            bBatalkan.BackgroundImageLayout = ImageLayout.Zoom;
            bBatalkan.FlatAppearance.BorderSize = 0;
            bBatalkan.FlatStyle = FlatStyle.Flat;
            bBatalkan.Location = new Point(290, 400);
            bBatalkan.Name = "bBatalkan";
            bBatalkan.Size = new Size(154, 38);
            bBatalkan.TabIndex = 19;
            bBatalkan.UseVisualStyleBackColor = false;
            // 
            // bPengembalian
            // 
            bPengembalian.BackColor = Color.White;
            bPengembalian.BackgroundImage = (Image)resources.GetObject("bPengembalian.BackgroundImage");
            bPengembalian.BackgroundImageLayout = ImageLayout.Zoom;
            bPengembalian.FlatAppearance.BorderSize = 0;
            bPengembalian.FlatStyle = FlatStyle.Flat;
            bPengembalian.Location = new Point(792, 400);
            bPengembalian.Name = "bPengembalian";
            bPengembalian.Size = new Size(170, 38);
            bPengembalian.TabIndex = 20;
            bPengembalian.UseVisualStyleBackColor = false;
            bPengembalian.Click += bPengembalian_Click;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.White;
            linkLabel3.DisabledLinkColor = Color.White;
            linkLabel3.Location = new Point(67, 7);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(42, 15);
            linkLabel3.TabIndex = 14;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Jadwal";
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.BackColor = Color.White;
            linkLabel5.DisabledLinkColor = Color.White;
            linkLabel5.Location = new Point(9, 7);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(48, 15);
            linkLabel5.TabIndex = 12;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "Riwayat";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(375, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // DashboardPeminjam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1030, 753);
            Controls.Add(pictureBox1);
            Controls.Add(bPengembalian);
            Controls.Add(bBatalkan);
            Controls.Add(bPinjam);
            Controls.Add(JadwalLabel);
            Controls.Add(dataGridUser);
            Controls.Add(JConsolePenyewa);
            Name = "DashboardPeminjam";
            Text = "DashboardPeminjam";
            ((System.ComponentModel.ISupportInitialize)dataGridUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label JConsolePenyewa;
        private DataGridView dataGridUser;
        private Label JadwalLabel;
        private Button bPinjam;
        private Button bBatalkan;
        private Button bPengembalian;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel5;
        private PictureBox pictureBox1;
    }
}