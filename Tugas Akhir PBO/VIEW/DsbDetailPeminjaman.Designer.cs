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
            JudulBesar0 = new Label();
            alatLabel = new Label();
            dataGridUser = new DataGridView();
            bRefresh = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // JudulBesar0
            // 
            JudulBesar0.AutoSize = true;
            JudulBesar0.Font = new Font("Inter Tight ExtraBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JudulBesar0.Location = new Point(12, 9);
            JudulBesar0.Name = "JudulBesar0";
            JudulBesar0.Size = new Size(261, 40);
            JudulBesar0.TabIndex = 3;
            JudulBesar0.Text = "Detail Peminjaman";
            // 
            // alatLabel
            // 
            alatLabel.AutoSize = true;
            alatLabel.Font = new Font("Inter Tight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            alatLabel.Location = new Point(12, 63);
            alatLabel.Name = "alatLabel";
            alatLabel.Size = new Size(38, 24);
            alatLabel.TabIndex = 21;
            alatLabel.Text = "Alat";
            // 
            // dataGridUser
            // 
            dataGridUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUser.Location = new Point(12, 90);
            dataGridUser.Name = "dataGridUser";
            dataGridUser.RowHeadersWidth = 51;
            dataGridUser.Size = new Size(776, 293);
            dataGridUser.TabIndex = 20;
            // 
            // bRefresh
            // 
            bRefresh.Location = new Point(660, 389);
            bRefresh.Name = "bRefresh";
            bRefresh.Size = new Size(93, 29);
            bRefresh.TabIndex = 34;
            bRefresh.Text = "Refresh";
            bRefresh.UseVisualStyleBackColor = true;
            // 
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
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 413);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // DsbDetailPeminjaman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(bRefresh);
            Controls.Add(alatLabel);
            Controls.Add(dataGridUser);
            Controls.Add(JudulBesar0);
            Name = "DsbDetailPeminjaman";
            Text = "DsbDetailPeminjaman";
            ((System.ComponentModel.ISupportInitialize)dataGridUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label JudulBesar0;
        private Label alatLabel;
        private DataGridView dataGridUser;
        private Button bRefresh;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}