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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardMitra));
            dataGridAlat = new DataGridView();
            dataGridView1 = new DataGridView();
            UserAddButton = new Button();
            DeleteUserButton = new Button();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            LabelLinkPeminjaman = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridAlat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridAlat
            // 
            dataGridAlat.BackgroundColor = Color.White;
            dataGridAlat.BorderStyle = BorderStyle.None;
            dataGridAlat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAlat.Location = new Point(193, 102);
            dataGridAlat.Name = "dataGridAlat";
            dataGridAlat.RowHeadersWidth = 51;
            dataGridAlat.Size = new Size(391, 373);
            dataGridAlat.TabIndex = 16;
            dataGridAlat.CellContentClick += dataGridAlat_CellContentClick;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(606, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(386, 371);
            dataGridView1.TabIndex = 18;
            // 
            // UserAddButton
            // 
            UserAddButton.BackColor = Color.White;
            UserAddButton.BackgroundImage = (Image)resources.GetObject("UserAddButton.BackgroundImage");
            UserAddButton.BackgroundImageLayout = ImageLayout.Zoom;
            UserAddButton.FlatAppearance.BorderSize = 0;
            UserAddButton.FlatStyle = FlatStyle.Flat;
            UserAddButton.Location = new Point(459, 481);
            UserAddButton.Name = "UserAddButton";
            UserAddButton.Size = new Size(116, 45);
            UserAddButton.TabIndex = 20;
            UserAddButton.UseVisualStyleBackColor = false;
            UserAddButton.Click += UserAddButton_Click;
            // 
            // DeleteUserButton
            // 
            DeleteUserButton.BackColor = Color.White;
            DeleteUserButton.BackgroundImage = (Image)resources.GetObject("DeleteUserButton.BackgroundImage");
            DeleteUserButton.BackgroundImageLayout = ImageLayout.Zoom;
            DeleteUserButton.FlatAppearance.BorderSize = 0;
            DeleteUserButton.FlatStyle = FlatStyle.Flat;
            DeleteUserButton.Location = new Point(208, 483);
            DeleteUserButton.Name = "DeleteUserButton";
            DeleteUserButton.Size = new Size(102, 45);
            DeleteUserButton.TabIndex = 21;
            DeleteUserButton.UseVisualStyleBackColor = false;
            DeleteUserButton.Click += DeleteUserButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(326, 483);
            button1.Name = "button1";
            button1.Size = new Size(116, 45);
            button1.TabIndex = 22;
            button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.FromArgb(0, 64, 0);
            linkLabel1.DisabledLinkColor = Color.White;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(26, 156);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(61, 20);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Riwayat";
            // 
            // LabelLinkPeminjaman
            // 
            LabelLinkPeminjaman.AutoSize = true;
            LabelLinkPeminjaman.BackColor = Color.FromArgb(0, 64, 0);
            LabelLinkPeminjaman.DisabledLinkColor = Color.White;
            LabelLinkPeminjaman.LinkColor = Color.White;
            LabelLinkPeminjaman.Location = new Point(26, 111);
            LabelLinkPeminjaman.Name = "LabelLinkPeminjaman";
            LabelLinkPeminjaman.Size = new Size(90, 20);
            LabelLinkPeminjaman.TabIndex = 11;
            LabelLinkPeminjaman.TabStop = true;
            LabelLinkPeminjaman.Text = "Peminjaman";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-9, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1038, 638);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // DashboardMitra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 753);
            Controls.Add(linkLabel1);
            Controls.Add(LabelLinkPeminjaman);
            Controls.Add(button1);
            Controls.Add(DeleteUserButton);
            Controls.Add(UserAddButton);
            Controls.Add(dataGridView1);
            Controls.Add(dataGridAlat);
            Controls.Add(pictureBox1);
            Name = "DashboardMitra";
            Text = "DashboardMitra";
            ((System.ComponentModel.ISupportInitialize)dataGridAlat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridAlat;
        private DataGridView dataGridView1;
        private Button UserAddButton;
        private Button DeleteUserButton;
        private Button button1;
        private LinkLabel linkLabel1;
        private LinkLabel LabelLinkPeminjaman;
        private PictureBox pictureBox1;
    }
}