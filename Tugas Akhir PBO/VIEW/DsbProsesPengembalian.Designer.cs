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
            dataGridView2 = new DataGridView();
            dataGrid0 = new DataGridView();
            bRefresh = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(725, 183);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(418, 415);
            dataGridView2.TabIndex = 30;
            // 
            // dataGrid0
            // 
            dataGrid0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGrid0.BackgroundColor = Color.White;
            dataGrid0.BorderStyle = BorderStyle.None;
            dataGrid0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid0.Location = new Point(227, 183);
            dataGrid0.Margin = new Padding(3, 4, 3, 4);
            dataGrid0.Name = "dataGrid0";
            dataGrid0.RowHeadersWidth = 51;
            dataGrid0.Size = new Size(422, 415);
            dataGrid0.TabIndex = 28;
            // 
            // bRefresh
            // 
            bRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bRefresh.BackColor = Color.White;
            bRefresh.BackgroundImage = (Image)resources.GetObject("bRefresh.BackgroundImage");
            bRefresh.BackgroundImageLayout = ImageLayout.Zoom;
            bRefresh.FlatAppearance.BorderSize = 0;
            bRefresh.FlatStyle = FlatStyle.Flat;
            bRefresh.Location = new Point(988, 714);
            bRefresh.Margin = new Padding(3, 4, 3, 4);
            bRefresh.Name = "bRefresh";
            bRefresh.Size = new Size(143, 48);
            bRefresh.TabIndex = 31;
            bRefresh.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.White;
            linkLabel1.Location = new Point(390, 8);
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
            pictureBox1.Size = new Size(1177, 865);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // DsbProsesPengembalian
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 865);
            Controls.Add(bRefresh);
            Controls.Add(dataGridView2);
            Controls.Add(dataGrid0);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DsbProsesPengembalian";
            Text = "DsbProsesPengembalian";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid0).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView2;
        private DataGridView dataGrid0;
        private Button bRefresh;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}