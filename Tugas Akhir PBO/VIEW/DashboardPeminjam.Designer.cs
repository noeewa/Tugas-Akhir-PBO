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
            dataGridUser = new DataGridView();
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
            // dataGridUser
            // 
            dataGridUser.BackgroundColor = Color.White;
            dataGridUser.BorderStyle = BorderStyle.None;
            dataGridUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUser.Location = new Point(175, 92);
            dataGridUser.Margin = new Padding(3, 2, 3, 2);
            dataGridUser.Name = "dataGridUser";
            dataGridUser.RowHeadersWidth = 51;
            dataGridUser.Size = new Size(699, 408);
            dataGridUser.TabIndex = 16;
            // 
            // bPinjam
            // 
            bPinjam.BackColor = Color.White;
            bPinjam.BackgroundImage = (Image)resources.GetObject("bPinjam.BackgroundImage");
            bPinjam.BackgroundImageLayout = ImageLayout.Zoom;
            bPinjam.FlatAppearance.BorderSize = 0;
            bPinjam.FlatStyle = FlatStyle.Flat;
            bPinjam.Location = new Point(268, 520);
            bPinjam.Margin = new Padding(3, 2, 3, 2);
            bPinjam.Name = "bPinjam";
            bPinjam.Size = new Size(84, 34);
            bPinjam.TabIndex = 18;
            bPinjam.UseVisualStyleBackColor = false;
            // 
            // bBatalkan
            // 
            bBatalkan.BackColor = Color.White;
            bBatalkan.BackgroundImage = (Image)resources.GetObject("bBatalkan.BackgroundImage");
            bBatalkan.BackgroundImageLayout = ImageLayout.Zoom;
            bBatalkan.FlatAppearance.BorderSize = 0;
            bBatalkan.FlatStyle = FlatStyle.Flat;
            bBatalkan.Location = new Point(175, 516);
            bBatalkan.Margin = new Padding(3, 2, 3, 2);
            bBatalkan.Name = "bBatalkan";
            bBatalkan.Size = new Size(87, 38);
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
            bPengembalian.Location = new Point(729, 516);
            bPengembalian.Margin = new Padding(3, 2, 3, 2);
            bPengembalian.Name = "bPengembalian";
            bPengembalian.Size = new Size(145, 38);
            bPengembalian.TabIndex = 20;
            bPengembalian.UseVisualStyleBackColor = false;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.White;
            linkLabel3.DisabledLinkColor = Color.White;
            linkLabel3.Location = new Point(12, 106);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(42, 15);
            linkLabel3.TabIndex = 14;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Jadwal";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.BackColor = Color.White;
            linkLabel5.DisabledLinkColor = Color.White;
            linkLabel5.Location = new Point(12, 79);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(48, 15);
            linkLabel5.TabIndex = 12;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "Riwayat";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -10);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(906, 583);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // DashboardPeminjam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 565);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel5);
            Controls.Add(bPengembalian);
            Controls.Add(bBatalkan);
            Controls.Add(bPinjam);
            Controls.Add(dataGridUser);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DashboardPeminjam";
            Text = "DashboardPeminjam";
            ((System.ComponentModel.ISupportInitialize)dataGridUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridUser;
        private Button bPinjam;
        private Button bBatalkan;
        private Button bPengembalian;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel5;
        private PictureBox pictureBox1;
    }
}