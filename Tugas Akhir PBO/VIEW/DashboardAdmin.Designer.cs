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
            labelAlat = new LinkLabel();
            LabelLinkPeminjaman = new LinkLabel();
            labelRiwayat = new LinkLabel();
            linkLabel2 = new LinkLabel();
            labelPengembalian = new LinkLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Logut = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMitra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 0;
            // 
            // dataGridUser
            // 
            dataGridUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridUser.BackgroundColor = Color.White;
            dataGridUser.BorderStyle = BorderStyle.None;
            dataGridUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUser.Location = new Point(201, 104);
            dataGridUser.Margin = new Padding(5, 3, 5, 3);
            dataGridUser.Name = "dataGridUser";
            dataGridUser.RowHeadersWidth = 51;
            dataGridUser.Size = new Size(389, 427);
            dataGridUser.TabIndex = 2;
            dataGridUser.CellContentClick += dataGridUser_CellContentClick;
            // 
            // dataGridMitra
            // 
            dataGridMitra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridMitra.BackgroundColor = Color.White;
            dataGridMitra.BorderStyle = BorderStyle.None;
            dataGridMitra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMitra.Location = new Point(615, 104);
            dataGridMitra.Margin = new Padding(5, 3, 5, 3);
            dataGridMitra.Name = "dataGridMitra";
            dataGridMitra.RowHeadersWidth = 51;
            dataGridMitra.Size = new Size(389, 429);
            dataGridMitra.TabIndex = 3;
            dataGridMitra.CellContentClick += dataGridMitra_CellContentClick;
            // 
            // UserAddButton
            // 
            UserAddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            UserAddButton.BackgroundImage = (Image)resources.GetObject("UserAddButton.BackgroundImage");
            UserAddButton.BackgroundImageLayout = ImageLayout.Zoom;
            UserAddButton.FlatAppearance.BorderSize = 0;
            UserAddButton.FlatStyle = FlatStyle.Flat;
            UserAddButton.Location = new Point(424, 576);
            UserAddButton.Margin = new Padding(5, 3, 5, 3);
            UserAddButton.Name = "UserAddButton";
            UserAddButton.Size = new Size(128, 45);
            UserAddButton.TabIndex = 5;
            UserAddButton.UseVisualStyleBackColor = true;
            UserAddButton.Click += UserAddButton_Click;
            // 
            // DeleteUserButton
            // 
            DeleteUserButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeleteUserButton.BackgroundImage = (Image)resources.GetObject("DeleteUserButton.BackgroundImage");
            DeleteUserButton.BackgroundImageLayout = ImageLayout.Zoom;
            DeleteUserButton.FlatAppearance.BorderSize = 0;
            DeleteUserButton.FlatStyle = FlatStyle.Flat;
            DeleteUserButton.Location = new Point(299, 576);
            DeleteUserButton.Margin = new Padding(5, 3, 5, 3);
            DeleteUserButton.Name = "DeleteUserButton";
            DeleteUserButton.Size = new Size(115, 45);
            DeleteUserButton.TabIndex = 7;
            DeleteUserButton.UseVisualStyleBackColor = true;
            DeleteUserButton.Click += DeleteUserButton_Click;
            // 
            // HapusMitra
            // 
            HapusMitra.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            HapusMitra.BackgroundImage = (Image)resources.GetObject("HapusMitra.BackgroundImage");
            HapusMitra.BackgroundImageLayout = ImageLayout.Zoom;
            HapusMitra.FlatAppearance.BorderSize = 0;
            HapusMitra.FlatStyle = FlatStyle.Flat;
            HapusMitra.Location = new Point(710, 576);
            HapusMitra.Margin = new Padding(5, 3, 5, 3);
            HapusMitra.Name = "HapusMitra";
            HapusMitra.Size = new Size(110, 45);
            HapusMitra.TabIndex = 9;
            HapusMitra.UseVisualStyleBackColor = true;
            HapusMitra.Click += HapusMitra_Click;
            // 
            // DaftarMitra
            // 
            DaftarMitra.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DaftarMitra.BackgroundImage = (Image)resources.GetObject("DaftarMitra.BackgroundImage");
            DaftarMitra.BackgroundImageLayout = ImageLayout.Zoom;
            DaftarMitra.FlatAppearance.BorderSize = 0;
            DaftarMitra.FlatStyle = FlatStyle.Flat;
            DaftarMitra.Location = new Point(841, 576);
            DaftarMitra.Margin = new Padding(5, 3, 5, 3);
            DaftarMitra.Name = "DaftarMitra";
            DaftarMitra.Size = new Size(130, 45);
            DaftarMitra.TabIndex = 8;
            DaftarMitra.UseVisualStyleBackColor = true;
            DaftarMitra.Click += DaftarMitra_Click;
            // 
            // labelAlat
            // 
            labelAlat.AutoSize = true;
            labelAlat.BackColor = Color.FromArgb(0, 64, 0);
            labelAlat.DisabledLinkColor = Color.White;
            labelAlat.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAlat.LinkColor = Color.White;
            labelAlat.Location = new Point(14, 104);
            labelAlat.Margin = new Padding(5, 0, 5, 0);
            labelAlat.Name = "labelAlat";
            labelAlat.Size = new Size(33, 18);
            labelAlat.TabIndex = 10;
            labelAlat.TabStop = true;
            labelAlat.Text = "Alat";
            labelAlat.LinkClicked += labelAlat_LinkClicked;
            // 
            // LabelLinkPeminjaman
            // 
            LabelLinkPeminjaman.AutoSize = true;
            LabelLinkPeminjaman.BackColor = Color.FromArgb(0, 64, 0);
            LabelLinkPeminjaman.DisabledLinkColor = Color.White;
            LabelLinkPeminjaman.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelLinkPeminjaman.LinkColor = Color.White;
            LabelLinkPeminjaman.Location = new Point(15, 139);
            LabelLinkPeminjaman.Margin = new Padding(5, 0, 5, 0);
            LabelLinkPeminjaman.Name = "LabelLinkPeminjaman";
            LabelLinkPeminjaman.Size = new Size(86, 18);
            LabelLinkPeminjaman.TabIndex = 11;
            LabelLinkPeminjaman.TabStop = true;
            LabelLinkPeminjaman.Text = "Peminjaman";
            LabelLinkPeminjaman.LinkClicked += LinkLabelPeminjaman_LinkClicked;
            // 
            // labelRiwayat
            // 
            labelRiwayat.AutoSize = true;
            labelRiwayat.BackColor = Color.FromArgb(0, 64, 0);
            labelRiwayat.DisabledLinkColor = Color.White;
            labelRiwayat.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRiwayat.LinkColor = Color.White;
            labelRiwayat.Location = new Point(15, 220);
            labelRiwayat.Margin = new Padding(5, 0, 5, 0);
            labelRiwayat.Name = "labelRiwayat";
            labelRiwayat.Size = new Size(57, 18);
            labelRiwayat.TabIndex = 12;
            labelRiwayat.TabStop = true;
            labelRiwayat.Text = "Riwayat";
            labelRiwayat.LinkClicked += labelRiwayat_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(507, 21);
            linkLabel2.Margin = new Padding(5, 0, 5, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(0, 20);
            linkLabel2.TabIndex = 13;
            // 
            // labelPengembalian
            // 
            labelPengembalian.AutoSize = true;
            labelPengembalian.BackColor = Color.FromArgb(0, 64, 0);
            labelPengembalian.DisabledLinkColor = Color.White;
            labelPengembalian.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPengembalian.LinkColor = Color.White;
            labelPengembalian.Location = new Point(15, 179);
            labelPengembalian.Margin = new Padding(5, 0, 5, 0);
            labelPengembalian.Name = "labelPengembalian";
            labelPengembalian.Size = new Size(97, 18);
            labelPengembalian.TabIndex = 15;
            labelPengembalian.TabStop = true;
            labelPengembalian.Text = "Pengembalian";
            labelPengembalian.LinkClicked += labelPengembalian_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 653);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(176, 0);
            pictureBox2.Margin = new Padding(5, 4, 5, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(854, 653);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // Logut
            // 
            Logut.AutoSize = true;
            Logut.BackColor = Color.White;
            Logut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logut.Location = new Point(950, 16);
            Logut.Name = "Logut";
            Logut.Size = new Size(50, 20);
            Logut.TabIndex = 37;
            Logut.Text = "Logut";
            Logut.Click += Logut_Click;
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1030, 659);
            Controls.Add(Logut);
            Controls.Add(labelRiwayat);
            Controls.Add(labelPengembalian);
            Controls.Add(labelAlat);
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
            Margin = new Padding(5, 3, 5, 3);
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
        private LinkLabel labelAlat;
        private LinkLabel LabelLinkPeminjaman;
        private LinkLabel labelRiwayat;
        private LinkLabel linkLabel2;
        private LinkLabel labelPengembalian;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label Logut;
    }
}