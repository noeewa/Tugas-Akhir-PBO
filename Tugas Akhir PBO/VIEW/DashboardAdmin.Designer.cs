namespace Tugas_Akhir_PBO.VIEW
{
    partial class DashboardAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdmin));
            label1 = new Label();
            dataGridUser = new DataGridView();
            dataGridMitra = new DataGridView();
            UserAddButton = new Button();
            DeleteUserButton = new Button();
            HapusMitra = new Button();
            DaftarMitra = new Button();
            LabelLinkBarang = new LinkLabel();
            LabelLinkPeminjaman = new LinkLabel();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMitra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 16);
            label1.TabIndex = 0;
            // 
            // dataGridUser
            // 
            dataGridUser.BackgroundColor = Color.White;
            dataGridUser.BorderStyle = BorderStyle.None;
            dataGridUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUser.Location = new Point(174, 78);
            dataGridUser.Margin = new Padding(4, 2, 4, 2);
            dataGridUser.Name = "dataGridUser";
            dataGridUser.RowHeadersWidth = 51;
            dataGridUser.Size = new Size(341, 320);
            dataGridUser.TabIndex = 2;
            dataGridUser.CellContentClick += dataGridUser_CellContentClick;
            // 
            // dataGridMitra
            // 
            dataGridMitra.BackgroundColor = Color.White;
            dataGridMitra.BorderStyle = BorderStyle.None;
            dataGridMitra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMitra.Location = new Point(536, 78);
            dataGridMitra.Margin = new Padding(4, 2, 4, 2);
            dataGridMitra.Name = "dataGridMitra";
            dataGridMitra.RowHeadersWidth = 51;
            dataGridMitra.Size = new Size(340, 322);
            dataGridMitra.TabIndex = 3;
            dataGridMitra.CellContentClick += dataGridMitra_CellContentClick;
            // 
            // UserAddButton
            // 
            UserAddButton.BackgroundImage = (Image)resources.GetObject("UserAddButton.BackgroundImage");
            UserAddButton.BackgroundImageLayout = ImageLayout.Zoom;
            UserAddButton.FlatAppearance.BorderSize = 0;
            UserAddButton.FlatStyle = FlatStyle.Flat;
            UserAddButton.Location = new Point(271, 432);
            UserAddButton.Margin = new Padding(4, 2, 4, 2);
            UserAddButton.Name = "UserAddButton";
            UserAddButton.Size = new Size(84, 34);
            UserAddButton.TabIndex = 5;
            UserAddButton.UseVisualStyleBackColor = true;
            UserAddButton.Click += UserAddButton_Click;
            // 
            // DeleteUserButton
            // 
            DeleteUserButton.BackgroundImage = (Image)resources.GetObject("DeleteUserButton.BackgroundImage");
            DeleteUserButton.BackgroundImageLayout = ImageLayout.Zoom;
            DeleteUserButton.FlatAppearance.BorderSize = 0;
            DeleteUserButton.FlatStyle = FlatStyle.Flat;
            DeleteUserButton.Location = new Point(184, 432);
            DeleteUserButton.Margin = new Padding(4, 2, 4, 2);
            DeleteUserButton.Name = "DeleteUserButton";
            DeleteUserButton.Size = new Size(80, 34);
            DeleteUserButton.TabIndex = 7;
            DeleteUserButton.UseVisualStyleBackColor = true;
            DeleteUserButton.Click += DeleteUserButton_Click;
            // 
            // HapusMitra
            // 
            HapusMitra.BackgroundImage = (Image)resources.GetObject("HapusMitra.BackgroundImage");
            HapusMitra.BackgroundImageLayout = ImageLayout.Zoom;
            HapusMitra.FlatAppearance.BorderSize = 0;
            HapusMitra.FlatStyle = FlatStyle.Flat;
            HapusMitra.Location = new Point(546, 432);
            HapusMitra.Margin = new Padding(4, 2, 4, 2);
            HapusMitra.Name = "HapusMitra";
            HapusMitra.Size = new Size(80, 34);
            HapusMitra.TabIndex = 9;
            HapusMitra.UseVisualStyleBackColor = true;
            HapusMitra.Click += HapusMitra_Click;
            // 
            // DaftarMitra
            // 
            DaftarMitra.BackgroundImage = (Image)resources.GetObject("DaftarMitra.BackgroundImage");
            DaftarMitra.BackgroundImageLayout = ImageLayout.Zoom;
            DaftarMitra.FlatAppearance.BorderSize = 0;
            DaftarMitra.FlatStyle = FlatStyle.Flat;
            DaftarMitra.Location = new Point(638, 432);
            DaftarMitra.Margin = new Padding(4, 2, 4, 2);
            DaftarMitra.Name = "DaftarMitra";
            DaftarMitra.Size = new Size(83, 34);
            DaftarMitra.TabIndex = 8;
            DaftarMitra.UseVisualStyleBackColor = true;
            DaftarMitra.Click += DaftarMitra_Click;
            // 
            // LabelLinkBarang
            // 
            LabelLinkBarang.AutoSize = true;
            LabelLinkBarang.BackColor = Color.FromArgb(0, 64, 0);
            LabelLinkBarang.DisabledLinkColor = Color.White;
            LabelLinkBarang.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelLinkBarang.LinkColor = Color.White;
            LabelLinkBarang.Location = new Point(12, 78);
            LabelLinkBarang.Margin = new Padding(4, 0, 4, 0);
            LabelLinkBarang.Name = "LabelLinkBarang";
            LabelLinkBarang.Size = new Size(29, 14);
            LabelLinkBarang.TabIndex = 10;
            LabelLinkBarang.TabStop = true;
            LabelLinkBarang.Text = "Alat";
            LabelLinkBarang.LinkClicked += LabelLinkBarang_LinkClicked;
            // 
            // LabelLinkPeminjaman
            // 
            LabelLinkPeminjaman.AutoSize = true;
            LabelLinkPeminjaman.BackColor = Color.FromArgb(0, 64, 0);
            LabelLinkPeminjaman.DisabledLinkColor = Color.White;
            LabelLinkPeminjaman.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelLinkPeminjaman.LinkColor = Color.White;
            LabelLinkPeminjaman.Location = new Point(13, 104);
            LabelLinkPeminjaman.Margin = new Padding(4, 0, 4, 0);
            LabelLinkPeminjaman.Name = "LabelLinkPeminjaman";
            LabelLinkPeminjaman.Size = new Size(75, 14);
            LabelLinkPeminjaman.TabIndex = 11;
            LabelLinkPeminjaman.TabStop = true;
            LabelLinkPeminjaman.Text = "Peminjaman";
            LabelLinkPeminjaman.LinkClicked += LabelLinkPeminjaman_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.FromArgb(0, 64, 0);
            linkLabel1.DisabledLinkColor = Color.White;
            linkLabel1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(13, 165);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(50, 14);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Riwayat";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(444, 16);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(0, 15);
            linkLabel2.TabIndex = 13;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.BackColor = Color.FromArgb(0, 64, 0);
            linkLabel4.DisabledLinkColor = Color.White;
            linkLabel4.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel4.LinkColor = Color.White;
            linkLabel4.Location = new Point(13, 134);
            linkLabel4.Margin = new Padding(4, 0, 4, 0);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(86, 14);
            linkLabel4.TabIndex = 15;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Pengembalian";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 490);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(149, 0);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(752, 490);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(901, 494);
            Controls.Add(linkLabel1);
            Controls.Add(linkLabel4);
            Controls.Add(LabelLinkBarang);
            Controls.Add(LabelLinkPeminjaman);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel2);
            Controls.Add(HapusMitra);
            Controls.Add(DaftarMitra);
            Controls.Add(DeleteUserButton);
            Controls.Add(UserAddButton);
            Controls.Add(dataGridMitra);
            Controls.Add(dataGridUser);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Margin = new Padding(4, 2, 4, 2);
            Name = "DashboardAdmin";
            Text = "DashboardAdmin";
            Load += DashboardAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMitra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridUser;
        private DataGridView dataGridMitra;
        private Button UserAddButton;
        private Button DeleteUserButton;
        private Button HapusMitra;
        private Button DaftarMitra;
        private LinkLabel LabelLinkBarang;
        private LinkLabel LabelLinkPeminjaman;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}