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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DsbProsesPengembalian));
            label0 = new Label();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            dataGrid0 = new DataGridView();
            label1 = new Label();
            bRefresh = new Button();
            guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid0).BeginInit();
            guna2ContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.Font = new Font("Inter Tight ExtraBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label0.Location = new Point(21, 12);
            label0.Name = "label0";
            label0.Size = new Size(320, 40);
            label0.TabIndex = 21;
            label0.Text = "Console Pengembalian";
            label0.Click += JConsolePenyewa_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(270, 94);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(518, 293);
            dataGridView2.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter Tight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(270, 63);
            label2.Name = "label2";
            label2.Size = new Size(114, 24);
            label2.TabIndex = 29;
            label2.Text = "Pengembalian";
            // 
            // dataGrid0
            // 
            dataGrid0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid0.Location = new Point(12, 94);
            dataGrid0.Name = "dataGrid0";
            dataGrid0.RowHeadersWidth = 51;
            dataGrid0.Size = new Size(252, 293);
            dataGrid0.TabIndex = 28;
            // 
            // label1
            // 
            label1.AccessibleDescription = "";
            label1.AutoSize = true;
            label1.Font = new Font("Inter Tight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(72, 24);
            label1.TabIndex = 27;
            label1.Text = "Dipinjam";
            // 
            // bRefresh
            // 
            bRefresh.Location = new Point(657, 393);
            bRefresh.Name = "bRefresh";
            bRefresh.Size = new Size(101, 29);
            bRefresh.TabIndex = 31;
            bRefresh.Text = "Konfirmasi";
            bRefresh.UseVisualStyleBackColor = true;
            // 
            // guna2ContainerControl1
            // 
            guna2ContainerControl1.Controls.Add(linkLabel1);
            guna2ContainerControl1.CustomizableEdges = customizableEdges1;
            guna2ContainerControl1.Location = new Point(347, 12);
            guna2ContainerControl1.Name = "guna2ContainerControl1";
            guna2ContainerControl1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ContainerControl1.Size = new Size(441, 37);
            guna2ContainerControl1.TabIndex = 36;
            guna2ContainerControl1.Text = "guna2ContainerControl1";
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
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 413);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // DsbProsesPengembalian
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(guna2ContainerControl1);
            Controls.Add(bRefresh);
            Controls.Add(dataGridView2);
            Controls.Add(label2);
            Controls.Add(dataGrid0);
            Controls.Add(label1);
            Controls.Add(label0);
            Name = "DsbProsesPengembalian";
            Text = "DsbProsesPengembalian";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid0).EndInit();
            guna2ContainerControl1.ResumeLayout(false);
            guna2ContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label0;
        private DataGridView dataGridView2;
        private Label label2;
        private DataGridView dataGrid0;
        private Label label1;
        private Button bRefresh;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}