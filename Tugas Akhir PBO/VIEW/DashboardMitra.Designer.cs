namespace Tugas_Akhir_PBO.VIEW
{
    partial class DashboardMitra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardMitra));
            JConsoleAdmin = new Label();
            MitraLabel = new Label();
            dataGridAlat = new DataGridView();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            UserAddButton = new Button();
            DeleteUserButton = new Button();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            LabelLinkPeminjaman = new LinkLabel();
            linkLabel4 = new LinkLabel();
            guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridAlat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            guna2ContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // JConsoleAdmin
            // 
            JConsoleAdmin.AutoSize = true;
            JConsoleAdmin.Font = new Font("Inter Tight ExtraBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JConsoleAdmin.Location = new Point(12, 9);
            JConsoleAdmin.Name = "JConsoleAdmin";
            JConsoleAdmin.Size = new Size(200, 40);
            JConsoleAdmin.TabIndex = 1;
            JConsoleAdmin.Text = "Console Mitra";
            // 
            // MitraLabel
            // 
            MitraLabel.AutoSize = true;
            MitraLabel.Font = new Font("Inter Tight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MitraLabel.Location = new Point(414, 58);
            MitraLabel.Name = "MitraLabel";
            MitraLabel.Size = new Size(108, 24);
            MitraLabel.TabIndex = 17;
            MitraLabel.Text = "Alat Di Pinjam";
            // 
            // dataGridAlat
            // 
            dataGridAlat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAlat.Location = new Point(16, 89);
            dataGridAlat.Name = "dataGridAlat";
            dataGridAlat.RowHeadersWidth = 51;
            dataGridAlat.Size = new Size(383, 278);
            dataGridAlat.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter Tight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 58);
            label1.Name = "label1";
            label1.Size = new Size(38, 24);
            label1.TabIndex = 19;
            label1.Text = "Alat";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(405, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(383, 278);
            dataGridView1.TabIndex = 18;
            // 
            // UserAddButton
            // 
            UserAddButton.Location = new Point(290, 373);
            UserAddButton.Name = "UserAddButton";
            UserAddButton.Size = new Size(94, 29);
            UserAddButton.TabIndex = 20;
            UserAddButton.Text = "Tambah";
            UserAddButton.UseVisualStyleBackColor = true;
            UserAddButton.Click += UserAddButton_Click;
            // 
            // DeleteUserButton
            // 
            DeleteUserButton.Location = new Point(90, 373);
            DeleteUserButton.Name = "DeleteUserButton";
            DeleteUserButton.Size = new Size(94, 29);
            DeleteUserButton.TabIndex = 21;
            DeleteUserButton.Text = "Hapus";
            DeleteUserButton.UseVisualStyleBackColor = true;
            DeleteUserButton.Click += DeleteUserButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(190, 373);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 22;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.White;
            linkLabel1.DisabledLinkColor = Color.White;
            linkLabel1.Location = new Point(105, 8);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(61, 20);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Riwayat";
            // 
            // LabelLinkPeminjaman
            // 
            LabelLinkPeminjaman.AutoSize = true;
            LabelLinkPeminjaman.BackColor = Color.White;
            LabelLinkPeminjaman.DisabledLinkColor = Color.White;
            LabelLinkPeminjaman.Location = new Point(11, 8);
            LabelLinkPeminjaman.Name = "LabelLinkPeminjaman";
            LabelLinkPeminjaman.Size = new Size(90, 20);
            LabelLinkPeminjaman.TabIndex = 11;
            LabelLinkPeminjaman.TabStop = true;
            LabelLinkPeminjaman.Text = "Peminjaman";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.BackColor = Color.White;
            linkLabel4.DisabledLinkColor = Color.White;
            linkLabel4.Location = new Point(148, 8);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(0, 20);
            linkLabel4.TabIndex = 15;
            // 
            // guna2ContainerControl1
            // 
            guna2ContainerControl1.Controls.Add(linkLabel4);
            guna2ContainerControl1.Controls.Add(LabelLinkPeminjaman);
            guna2ContainerControl1.Controls.Add(linkLabel1);
            guna2ContainerControl1.CustomizableEdges = customizableEdges1;
            guna2ContainerControl1.Location = new Point(216, 12);
            guna2ContainerControl1.Name = "guna2ContainerControl1";
            guna2ContainerControl1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ContainerControl1.Size = new Size(572, 37);
            guna2ContainerControl1.TabIndex = 35;
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
            // DashboardMitra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(guna2ContainerControl1);
            Controls.Add(button1);
            Controls.Add(DeleteUserButton);
            Controls.Add(UserAddButton);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(MitraLabel);
            Controls.Add(dataGridAlat);
            Controls.Add(JConsoleAdmin);
            Name = "DashboardMitra";
            Text = "DashboardMitra";
            ((System.ComponentModel.ISupportInitialize)dataGridAlat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            guna2ContainerControl1.ResumeLayout(false);
            guna2ContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label JConsoleAdmin;
        private Label MitraLabel;
        private DataGridView dataGridAlat;
        private Label label1;
        private DataGridView dataGridView1;
        private Button UserAddButton;
        private Button DeleteUserButton;
        private Button button1;
        private LinkLabel linkLabel1;
        private LinkLabel LabelLinkPeminjaman;
        private LinkLabel linkLabel4;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private PictureBox pictureBox1;
    }
}