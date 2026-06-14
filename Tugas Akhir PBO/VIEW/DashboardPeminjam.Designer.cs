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
            dataGridPeminjam = new DataGridView();
            bPinjam = new Button();
            bBatalkan = new Button();
            bPengembalian = new Button();
            linkLabel3 = new LinkLabel();
            linkLabel5 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridPeminjam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridPeminjam
            // 
            dataGridPeminjam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPeminjam.BackgroundColor = Color.White;
            dataGridPeminjam.BorderStyle = BorderStyle.None;
            dataGridPeminjam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPeminjam.Location = new Point(231, 158);
            dataGridPeminjam.Margin = new Padding(3, 4, 3, 4);
            dataGridPeminjam.Name = "dataGridPeminjam";
            dataGridPeminjam.RowHeadersWidth = 51;
            dataGridPeminjam.Size = new Size(913, 478);
            dataGridPeminjam.TabIndex = 16;
            // 
            // bPinjam
            // 
            bPinjam.Anchor = AnchorStyles.Bottom;
            bPinjam.BackColor = Color.White;
            bPinjam.BackgroundImage = (Image)resources.GetObject("bPinjam.BackgroundImage");
            bPinjam.BackgroundImageLayout = ImageLayout.Zoom;
            bPinjam.FlatAppearance.BorderSize = 0;
            bPinjam.FlatStyle = FlatStyle.Flat;
            bPinjam.Location = new Point(449, 647);
            bPinjam.Margin = new Padding(3, 4, 3, 4);
            bPinjam.Name = "bPinjam";
            bPinjam.Size = new Size(145, 46);
            bPinjam.TabIndex = 18;
            bPinjam.UseVisualStyleBackColor = false;
            bPinjam.Click += bPinjam_Click;
            // 
            // bBatalkan
            // 
            bBatalkan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bBatalkan.BackColor = Color.White;
            bBatalkan.BackgroundImage = (Image)resources.GetObject("bBatalkan.BackgroundImage");
            bBatalkan.BackgroundImageLayout = ImageLayout.Zoom;
            bBatalkan.FlatAppearance.BorderSize = 0;
            bBatalkan.FlatStyle = FlatStyle.Flat;
            bBatalkan.Location = new Point(245, 647);
            bBatalkan.Margin = new Padding(3, 4, 3, 4);
            bBatalkan.Name = "bBatalkan";
            bBatalkan.Size = new Size(181, 46);
            bBatalkan.TabIndex = 19;
            bBatalkan.UseVisualStyleBackColor = false;
            // 
            // bPengembalian
            // 
            bPengembalian.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bPengembalian.BackColor = Color.White;
            bPengembalian.BackgroundImage = (Image)resources.GetObject("bPengembalian.BackgroundImage");
            bPengembalian.BackgroundImageLayout = ImageLayout.Zoom;
            bPengembalian.FlatAppearance.BorderSize = 0;
            bPengembalian.FlatStyle = FlatStyle.Flat;
            bPengembalian.Location = new Point(908, 644);
            bPengembalian.Margin = new Padding(3, 4, 3, 4);
            bPengembalian.Name = "bPengembalian";
            bPengembalian.Size = new Size(218, 49);
            bPengembalian.TabIndex = 20;
            bPengembalian.UseVisualStyleBackColor = false;
            bPengembalian.Click += bPengembalian_Click;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.FromArgb(0, 64, 0);
            linkLabel3.DisabledLinkColor = Color.White;
            linkLabel3.LinkColor = Color.White;
            linkLabel3.Location = new Point(24, 187);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(54, 20);
            linkLabel3.TabIndex = 14;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Jadwal";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.BackColor = Color.FromArgb(0, 64, 0);
            linkLabel5.DisabledLinkColor = Color.White;
            linkLabel5.LinkColor = Color.White;
            linkLabel5.Location = new Point(24, 139);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(61, 20);
            linkLabel5.TabIndex = 12;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "Riwayat";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1177, 816);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // DashboardPeminjam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 816);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel5);
            Controls.Add(bPengembalian);
            Controls.Add(bBatalkan);
            Controls.Add(bPinjam);
            Controls.Add(dataGridPeminjam);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardPeminjam";
            Text = "DashboardPeminjam";
            ((System.ComponentModel.ISupportInitialize)dataGridPeminjam).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridPeminjam;
        private Button bPinjam;
        private Button bBatalkan;
        private Button bPengembalian;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel5;
        private PictureBox pictureBox1;
    }
}