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
            dataGridView2 = new DataGridView();
            bRefresh = new Button();
            button1 = new Button();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            Back = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(229, 132);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(911, 383);
            dataGridView2.TabIndex = 28;
            // 
            // bRefresh
            // 
            bRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bRefresh.BackColor = Color.White;
            bRefresh.BackgroundImage = (Image)resources.GetObject("bRefresh.BackgroundImage");
            bRefresh.BackgroundImageLayout = ImageLayout.Zoom;
            bRefresh.FlatAppearance.BorderSize = 0;
            bRefresh.FlatStyle = FlatStyle.Flat;
            bRefresh.Location = new Point(1020, 523);
            bRefresh.Margin = new Padding(3, 4, 3, 4);
            bRefresh.Name = "bRefresh";
            bRefresh.Size = new Size(112, 39);
            bRefresh.TabIndex = 29;
            bRefresh.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.White;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(252, 523);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(136, 39);
            button1.TabIndex = 30;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.BackColor = Color.White;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(405, 523);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(191, 39);
            button2.TabIndex = 31;
            button2.UseVisualStyleBackColor = false;
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
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1177, 751);
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
            Back.Location = new Point(1075, 12);
            Back.Name = "Back";
            Back.Size = new Size(46, 24);
            Back.TabIndex = 48;
            Back.Text = "Back";
            // 
            // DsbAlat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 751);
            Controls.Add(Back);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(bRefresh);
            Controls.Add(dataGridView2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DsbAlat";
            Text = "Barang";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView2;
        private Button bRefresh;
        private Button button1;
        private Button button2;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Label Back;
    }
}