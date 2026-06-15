namespace Tugas_Akhir_PBO.VIEW
{
    partial class DsbProsesPengembalian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DsbProsesPengembalian));
            ListPengembalian = new DataGridView();
            ListAlatBox = new DataGridView();
            bKonfirmasi = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            Back = new Label();
            ((System.ComponentModel.ISupportInitialize)ListPengembalian).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ListAlatBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ListPengembalian
            // 
            ListPengembalian.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ListPengembalian.BackgroundColor = Color.White;
            ListPengembalian.BorderStyle = BorderStyle.None;
            ListPengembalian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListPengembalian.Location = new Point(725, 183);
            ListPengembalian.Margin = new Padding(3, 4, 3, 4);
            ListPengembalian.Name = "ListPengembalian";
            ListPengembalian.RowHeadersWidth = 51;
            ListPengembalian.Size = new Size(418, 415);
            ListPengembalian.TabIndex = 30;
            // 
            // ListAlatBox
            // 
            ListAlatBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ListAlatBox.BackgroundColor = Color.White;
            ListAlatBox.BorderStyle = BorderStyle.None;
            ListAlatBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListAlatBox.Location = new Point(227, 183);
            ListAlatBox.Margin = new Padding(3, 4, 3, 4);
            ListAlatBox.Name = "ListAlatBox";
            ListAlatBox.RowHeadersWidth = 51;
            ListAlatBox.Size = new Size(422, 350);
            ListAlatBox.TabIndex = 28;
            // 
            // bKonfirmasi
            // 
            bKonfirmasi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bKonfirmasi.BackColor = Color.White;
            bKonfirmasi.BackgroundImage = (Image)resources.GetObject("bKonfirmasi.BackgroundImage");
            bKonfirmasi.BackgroundImageLayout = ImageLayout.Zoom;
            bKonfirmasi.FlatAppearance.BorderSize = 0;
            bKonfirmasi.FlatStyle = FlatStyle.Flat;
            bKonfirmasi.Location = new Point(988, 714);
            bKonfirmasi.Margin = new Padding(3, 4, 3, 4);
            bKonfirmasi.Name = "bKonfirmasi";
            bKonfirmasi.Size = new Size(143, 48);
            bKonfirmasi.TabIndex = 31;
            bKonfirmasi.UseVisualStyleBackColor = false;
            bKonfirmasi.Click += bKonfirmasi_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.White;
            linkLabel1.Location = new Point(390, 8);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(46, 20);
            linkLabel1.TabIndex = 31;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            linkLabel1.LinkClicked += Back_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1177, 865);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // Back
            // 
            Back.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Back.AutoSize = true;
            Back.BackColor = SystemColors.ButtonHighlight;
            Back.Font = new Font("Inter Tight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.Location = new Point(1119, 77);
            Back.Name = "Back";
            Back.Size = new Size(46, 24);
            Back.TabIndex = 50;
            Back.Text = "Back";
            Back.Click += Back_Click;
            // 
            // DsbProsesPengembalian
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 865);
            Controls.Add(Back);
            Controls.Add(bKonfirmasi);
            Controls.Add(ListPengembalian);
            Controls.Add(ListAlatBox);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DsbProsesPengembalian";
            Text = "DsbProsesPengembalian";
            ((System.ComponentModel.ISupportInitialize)ListPengembalian).EndInit();
            ((System.ComponentModel.ISupportInitialize)ListAlatBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView ListPengembalian;
        private DataGridView ListAlatBox;
        private Button bKonfirmasi;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Label Back;
    }
}