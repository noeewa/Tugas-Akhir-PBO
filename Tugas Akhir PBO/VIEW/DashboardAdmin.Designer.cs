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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdmin));
            JConsoleAdmin = new Label();
            label1 = new Label();
            UserAdminLabel = new Label();
            dataGridUser = new DataGridView();
            dataGridMitra = new DataGridView();
            MitraLabel = new Label();
            UserAddButton = new Button();
            DeleteUserButton = new Button();
            HapusMitra = new Button();
            DaftarMitra = new Button();
            LabelLinkBarang = new LinkLabel();
            LabelLinkPeminjaman = new LinkLabel();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMitra).BeginInit();
            guna2ContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // JConsoleAdmin
            // 
            JConsoleAdmin.AutoSize = true;
            JConsoleAdmin.Font = new Font("Inter Tight ExtraBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JConsoleAdmin.Location = new Point(12, 14);
            JConsoleAdmin.Name = "JConsoleAdmin";
            JConsoleAdmin.Size = new Size(218, 40);
            JConsoleAdmin.TabIndex = 0;
            JConsoleAdmin.Text = "Console Admin";
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // UserAdminLabel
            // 
            UserAdminLabel.AutoSize = true;
            UserAdminLabel.Font = new Font("Inter Tight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserAdminLabel.Location = new Point(12, 54);
            UserAdminLabel.Name = "UserAdminLabel";
            UserAdminLabel.Size = new Size(45, 24);
            UserAdminLabel.TabIndex = 1;
            UserAdminLabel.Text = "User";
            UserAdminLabel.Click += UserAdminLabel_Click;
            // 
            // dataGridUser
            // 
            dataGridUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUser.Location = new Point(12, 81);
            dataGridUser.Name = "dataGridUser";
            dataGridUser.RowHeadersWidth = 51;
            dataGridUser.Size = new Size(369, 284);
            dataGridUser.TabIndex = 2;
            // 
            // dataGridMitra
            // 
            dataGridMitra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMitra.Location = new Point(387, 81);
            dataGridMitra.Name = "dataGridMitra";
            dataGridMitra.RowHeadersWidth = 51;
            dataGridMitra.Size = new Size(401, 284);
            dataGridMitra.TabIndex = 3;
            // 
            // MitraLabel
            // 
            MitraLabel.AutoSize = true;
            MitraLabel.Font = new Font("Inter Tight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MitraLabel.Location = new Point(387, 54);
            MitraLabel.Name = "MitraLabel";
            MitraLabel.Size = new Size(47, 24);
            MitraLabel.TabIndex = 4;
            MitraLabel.Text = "Mitra";
            // 
            // UserAddButton
            // 
            UserAddButton.Location = new Point(262, 371);
            UserAddButton.Name = "UserAddButton";
            UserAddButton.Size = new Size(94, 29);
            UserAddButton.TabIndex = 5;
            UserAddButton.Text = "Tambah";
            UserAddButton.UseVisualStyleBackColor = true;
            UserAddButton.Click += UserAddButton_Click;
            // 
            // DeleteUserButton
            // 
            DeleteUserButton.Location = new Point(162, 371);
            DeleteUserButton.Name = "DeleteUserButton";
            DeleteUserButton.Size = new Size(94, 29);
            DeleteUserButton.TabIndex = 7;
            DeleteUserButton.Text = "Hapus";
            DeleteUserButton.UseVisualStyleBackColor = true;
            DeleteUserButton.Click += DeleteUserButton_Click;
            // 
            // HapusMitra
            // 
            HapusMitra.Location = new Point(556, 371);
            HapusMitra.Name = "HapusMitra";
            HapusMitra.Size = new Size(94, 29);
            HapusMitra.TabIndex = 9;
            HapusMitra.Text = "Hapus";
            HapusMitra.UseVisualStyleBackColor = true;
            // 
            // DaftarMitra
            // 
            DaftarMitra.Location = new Point(656, 371);
            DaftarMitra.Name = "DaftarMitra";
            DaftarMitra.Size = new Size(94, 29);
            DaftarMitra.TabIndex = 8;
            DaftarMitra.Text = "Register";
            DaftarMitra.UseVisualStyleBackColor = true;
            DaftarMitra.Click += DaftarMitra_Click;
            // 
            // LabelLinkBarang
            // 
            LabelLinkBarang.AutoSize = true;
            LabelLinkBarang.BackColor = Color.White;
            LabelLinkBarang.DisabledLinkColor = Color.White;
            LabelLinkBarang.Location = new Point(10, 8);
            LabelLinkBarang.Name = "LabelLinkBarang";
            LabelLinkBarang.Size = new Size(36, 20);
            LabelLinkBarang.TabIndex = 10;
            LabelLinkBarang.TabStop = true;
            LabelLinkBarang.Text = "Alat";
            LabelLinkBarang.LinkClicked += LabelLinkBarang_LinkClicked;
            // 
            // LabelLinkPeminjaman
            // 
            LabelLinkPeminjaman.AutoSize = true;
            LabelLinkPeminjaman.BackColor = Color.White;
            LabelLinkPeminjaman.DisabledLinkColor = Color.White;
            LabelLinkPeminjaman.Location = new Point(52, 8);
            LabelLinkPeminjaman.Name = "LabelLinkPeminjaman";
            LabelLinkPeminjaman.Size = new Size(90, 20);
            LabelLinkPeminjaman.TabIndex = 11;
            LabelLinkPeminjaman.TabStop = true;
            LabelLinkPeminjaman.Text = "Peminjaman";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.White;
            linkLabel1.DisabledLinkColor = Color.White;
            linkLabel1.Location = new Point(257, 8);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(61, 20);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Riwayat";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(507, 21);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(0, 20);
            linkLabel2.TabIndex = 13;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.BackColor = Color.White;
            linkLabel4.DisabledLinkColor = Color.White;
            linkLabel4.Location = new Point(148, 8);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(103, 20);
            linkLabel4.TabIndex = 15;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Pengembalian";
            // 
            // guna2ContainerControl1
            // 
            guna2ContainerControl1.Controls.Add(linkLabel4);
            guna2ContainerControl1.Controls.Add(LabelLinkPeminjaman);
            guna2ContainerControl1.Controls.Add(LabelLinkBarang);
            guna2ContainerControl1.Controls.Add(linkLabel1);
            guna2ContainerControl1.CustomizableEdges = customizableEdges1;
            guna2ContainerControl1.Location = new Point(236, 17);
            guna2ContainerControl1.Name = "guna2ContainerControl1";
            guna2ContainerControl1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ContainerControl1.Size = new Size(552, 37);
            guna2ContainerControl1.TabIndex = 34;
            guna2ContainerControl1.Text = "guna2ContainerControl1";
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
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(guna2ContainerControl1);
            Controls.Add(linkLabel2);
            Controls.Add(HapusMitra);
            Controls.Add(DaftarMitra);
            Controls.Add(DeleteUserButton);
            Controls.Add(UserAddButton);
            Controls.Add(MitraLabel);
            Controls.Add(dataGridMitra);
            Controls.Add(dataGridUser);
            Controls.Add(UserAdminLabel);
            Controls.Add(label1);
            Controls.Add(JConsoleAdmin);
            Name = "DashboardAdmin";
            Text = "DashboardAdmin";
            Load += DashboardAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMitra).EndInit();
            guna2ContainerControl1.ResumeLayout(false);
            guna2ContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label JConsoleAdmin;
        private Label label1;
        private Label UserAdminLabel;
        private DataGridView dataGridUser;
        private DataGridView dataGridMitra;
        private Label MitraLabel;
        private Button UserAddButton;
        private Button DeleteUserButton;
        private Button HapusMitra;
        private Button DaftarMitra;
        private LinkLabel LabelLinkBarang;
        private LinkLabel LabelLinkPeminjaman;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel4;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private PictureBox pictureBox1;
    }
}