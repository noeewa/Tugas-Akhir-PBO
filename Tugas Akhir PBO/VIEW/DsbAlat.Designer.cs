namespace Tugas_Akhir_PBO.VIEW
{
    partial class DsbAlat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DsbAlat));
            JudulBesar0 = new Label();
            dataGridView2 = new DataGridView();
            label0 = new Label();
            bRefresh = new Button();
            button1 = new Button();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // JudulBesar0
            // 
            JudulBesar0.AutoSize = true;
            JudulBesar0.Font = new Font("Inter Tight ExtraBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JudulBesar0.Location = new Point(12, 9);
            JudulBesar0.Name = "JudulBesar0";
            JudulBesar0.Size = new Size(123, 40);
            JudulBesar0.TabIndex = 2;
            JudulBesar0.Text = "List Alat";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 90);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(776, 278);
            dataGridView2.TabIndex = 28;
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.Font = new Font("Inter Tight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label0.Location = new Point(12, 59);
            label0.Name = "label0";
            label0.Size = new Size(82, 24);
            label0.TabIndex = 27;
            label0.Text = "Detail Alat";
            // 
            // bRefresh
            // 
            bRefresh.Location = new Point(679, 374);
            bRefresh.Name = "bRefresh";
            bRefresh.Size = new Size(93, 29);
            bRefresh.TabIndex = 29;
            bRefresh.Text = "Refresh";
            bRefresh.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(51, 374);
            button1.Name = "button1";
            button1.Size = new Size(149, 29);
            button1.TabIndex = 30;
            button1.Text = "Update Alat";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(215, 374);
            button2.Name = "button2";
            button2.Size = new Size(188, 29);
            button2.TabIndex = 31;
            button2.Text = "Atur/Tambah Kategori";
            button2.UseVisualStyleBackColor = true;
            //
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.White;
            linkLabel1.Location = new Point(599, 8);
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
            // DsbAlat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(bRefresh);
            Controls.Add(dataGridView2);
            Controls.Add(label0);
            Controls.Add(JudulBesar0);
            Name = "DsbAlat";
            Text = "Barang";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label JudulBesar0;
        private DataGridView dataGridView2;
        private Label label0;
        private Button bRefresh;
        private Button button1;
        private Button button2;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}