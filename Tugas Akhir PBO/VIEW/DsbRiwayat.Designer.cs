namespace Tugas_Akhir_PBO.VIEW
{
    partial class DsbRiwayat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DsbRiwayat));
            JConsoleRiwayat = new Label();
            dataGridView2 = new DataGridView();
            label0 = new Label();
            LoginButton = new Button();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // JConsoleRiwayat
            // 
            JConsoleRiwayat.AutoSize = true;
            JConsoleRiwayat.Font = new Font("Inter Tight ExtraBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JConsoleRiwayat.Location = new Point(12, 9);
            JConsoleRiwayat.Name = "JConsoleRiwayat";
            JConsoleRiwayat.Size = new Size(290, 40);
            JConsoleRiwayat.TabIndex = 1;
            JConsoleRiwayat.Text = "Riwayat Peminjaman";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 89);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(776, 293);
            dataGridView2.TabIndex = 28;
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.Font = new Font("Inter Tight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label0.Location = new Point(12, 58);
            label0.Name = "label0";
            label0.Size = new Size(112, 24);
            label0.TabIndex = 27;
            label0.Text = "Detail Riwayat";
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(654, 388);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 29;
            LoginButton.Text = "Refresh";
            LoginButton.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(748, 23);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(40, 20);
            linkLabel1.TabIndex = 30;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            // 
            // button1
            // 
            button1.Location = new Point(453, 388);
            button1.Name = "button1";
            button1.Size = new Size(160, 29);
            button1.TabIndex = 31;
            button1.Text = "Detail Peminjaman";
            button1.UseVisualStyleBackColor = true;
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
            // DsbRiwayat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(LoginButton);
            Controls.Add(dataGridView2);
            Controls.Add(label0);
            Controls.Add(JConsoleRiwayat);
            Name = "DsbRiwayat";
            Text = "Riwayat";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label JConsoleRiwayat;
        private DataGridView dataGridView2;
        private Label label0;
        private Button LoginButton;
        private LinkLabel linkLabel1;
        private Button button1;
        private PictureBox pictureBox1;
    }
}