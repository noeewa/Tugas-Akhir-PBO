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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardPeminjam));
            JConsolePenyewa = new Label();
            dataGridUser = new DataGridView();
            JadwalLabel = new Label();
            bPinjam = new Button();
            bBatalkan = new Button();
            bPengembalian = new Button();
            guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            linkLabel3 = new LinkLabel();
            linkLabel5 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridUser).BeginInit();
            guna2ContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // JConsolePenyewa
            // 
            JConsolePenyewa.AutoSize = true;
            JConsolePenyewa.Font = new Font("Inter Tight ExtraBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JConsolePenyewa.Location = new Point(12, 9);
            JConsolePenyewa.Name = "JConsolePenyewa";
            JConsolePenyewa.Size = new Size(252, 40);
            JConsolePenyewa.TabIndex = 1;
            JConsolePenyewa.Text = "Console Penyewa";
            // 
            // dataGridUser
            // 
            dataGridUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUser.Location = new Point(12, 79);
            dataGridUser.Name = "dataGridUser";
            dataGridUser.RowHeadersWidth = 51;
            dataGridUser.Size = new Size(776, 291);
            dataGridUser.TabIndex = 16;
            // 
            // JadwalLabel
            // 
            JadwalLabel.AutoSize = true;
            JadwalLabel.Font = new Font("Inter Tight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JadwalLabel.Location = new Point(12, 52);
            JadwalLabel.Name = "JadwalLabel";
            JadwalLabel.Size = new Size(62, 24);
            JadwalLabel.TabIndex = 17;
            JadwalLabel.Text = "Jadwal";
            // 
            // bPinjam
            // 
            bPinjam.Location = new Point(222, 376);
            bPinjam.Name = "bPinjam";
            bPinjam.Size = new Size(94, 29);
            bPinjam.TabIndex = 18;
            bPinjam.Text = "Pinjam Alat";
            bPinjam.UseVisualStyleBackColor = true;
            // 
            // bBatalkan
            // 
            bBatalkan.Location = new Point(47, 376);
            bBatalkan.Name = "bBatalkan";
            bBatalkan.Size = new Size(149, 29);
            bBatalkan.TabIndex = 19;
            bBatalkan.Text = "Batalkan Jadwal";
            bBatalkan.UseVisualStyleBackColor = true;
            // 
            // bPengembalian
            // 
            bPengembalian.Location = new Point(592, 376);
            bPengembalian.Name = "bPengembalian";
            bPengembalian.Size = new Size(166, 29);
            bPengembalian.TabIndex = 20;
            bPengembalian.Text = "Buat Pengembalian";
            bPengembalian.UseVisualStyleBackColor = true;
            // 
            // guna2ContainerControl1
            // 
            guna2ContainerControl1.Controls.Add(linkLabel3);
            guna2ContainerControl1.Controls.Add(linkLabel5);
            guna2ContainerControl1.CustomizableEdges = customizableEdges1;
            guna2ContainerControl1.Location = new Point(279, 12);
            guna2ContainerControl1.Name = "guna2ContainerControl1";
            guna2ContainerControl1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ContainerControl1.Size = new Size(509, 37);
            guna2ContainerControl1.TabIndex = 35;
            guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.White;
            linkLabel3.DisabledLinkColor = Color.White;
            linkLabel3.Location = new Point(77, 9);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(54, 20);
            linkLabel3.TabIndex = 14;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Jadwal";
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.BackColor = Color.White;
            linkLabel5.DisabledLinkColor = Color.White;
            linkLabel5.Location = new Point(10, 9);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(61, 20);
            linkLabel5.TabIndex = 12;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "Riwayat";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 413);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // DashboardPeminjam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(guna2ContainerControl1);
            Controls.Add(bPengembalian);
            Controls.Add(bBatalkan);
            Controls.Add(bPinjam);
            Controls.Add(JadwalLabel);
            Controls.Add(dataGridUser);
            Controls.Add(JConsolePenyewa);
            Name = "DashboardPeminjam";
            Text = "DashboardPeminjam";
            ((System.ComponentModel.ISupportInitialize)dataGridUser).EndInit();
            guna2ContainerControl1.ResumeLayout(false);
            guna2ContainerControl1.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel5;
        private PictureBox pictureBox1;
    }
}