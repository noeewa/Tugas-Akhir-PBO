namespace Tugas_Akhir_PBO.VIEW
{
    partial class DsbDetailPeminjaman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DsbDetailPeminjaman));
            DataGridDetail = new DataGridView();
            bRefresh = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            Back = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DataGridDetail
            // 
            DataGridDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridDetail.BackgroundColor = Color.White;
            DataGridDetail.BorderStyle = BorderStyle.None;
            DataGridDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridDetail.Location = new Point(233, 157);
            DataGridDetail.Margin = new Padding(3, 4, 3, 4);
            DataGridDetail.Name = "DataGridDetail";
            DataGridDetail.RowHeadersWidth = 51;
            DataGridDetail.Size = new Size(903, 490);
            DataGridDetail.TabIndex = 20;
            // 
            // bRefresh
            // 
            bRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bRefresh.BackColor = Color.White;
            bRefresh.BackgroundImage = (Image)resources.GetObject("bRefresh.BackgroundImage");
            bRefresh.BackgroundImageLayout = ImageLayout.Zoom;
            bRefresh.FlatAppearance.BorderSize = 0;
            bRefresh.FlatStyle = FlatStyle.Flat;
            bRefresh.Location = new Point(1016, 655);
            bRefresh.Margin = new Padding(3, 4, 3, 4);
            bRefresh.Name = "bRefresh";
            bRefresh.Size = new Size(107, 39);
            bRefresh.TabIndex = 34;
            bRefresh.UseVisualStyleBackColor = false;
            bRefresh.Click += bRefresh_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.White;
            linkLabel1.Location = new Point(461, 8);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(40, 20);
            linkLabel1.TabIndex = 31;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1177, 829);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // Back
            // 
            Back.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Back.AutoSize = true;
            Back.BackColor = SystemColors.ButtonHighlight;
            Back.Font = new Font("Inter Tight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.Location = new Point(1119, 60);
            Back.Name = "Back";
            Back.Size = new Size(46, 24);
            Back.TabIndex = 49;
            Back.Text = "Back";
            Back.Click += Back_Click;
            // 
            // DsbDetailPeminjaman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 829);
            Controls.Add(Back);
            Controls.Add(bRefresh);
            Controls.Add(DataGridDetail);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DsbDetailPeminjaman";
            Text = "DsbDetailPeminjaman";
            Load += DsbDetailPeminjaman_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView DataGridDetail;
        private Button bRefresh;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Label Back;
    }
}