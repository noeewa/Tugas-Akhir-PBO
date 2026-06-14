namespace Tugas_Akhir_PBO.VIEW
{
    partial class FormPinjam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPinjam));
            JPinjamAlat = new Label();
            linkLabel1 = new LinkLabel();
            AlatGridBox = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            AlatListBox = new DataGridView();
            button2 = new Button();
            label3 = new Label();
            button3 = new Button();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            LoginButton = new Button();
            DateStartPick = new DateTimePicker();
            labelMulai = new Label();
            label5 = new Label();
            DateEndPick = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)AlatGridBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AlatListBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // JPinjamAlat
            // 
            JPinjamAlat.AutoSize = true;
            JPinjamAlat.Font = new Font("Inter Tight ExtraBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JPinjamAlat.Location = new Point(14, 12);
            JPinjamAlat.Name = "JPinjamAlat";
            JPinjamAlat.Size = new Size(165, 40);
            JPinjamAlat.TabIndex = 35;
            JPinjamAlat.Text = "Pinjam Alat";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.White;
            linkLabel1.Location = new Point(555, 8);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(40, 20);
            linkLabel1.TabIndex = 31;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            // 
            // AlatGridBox
            // 
            AlatGridBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AlatGridBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AlatGridBox.Location = new Point(14, 115);
            AlatGridBox.Margin = new Padding(3, 4, 3, 4);
            AlatGridBox.Name = "AlatGridBox";
            AlatGridBox.RowHeadersWidth = 51;
            AlatGridBox.Size = new Size(431, 248);
            AlatGridBox.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 84);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 39;
            label1.Text = "Pilih Alat";
            // 
            // button1
            // 
            button1.Location = new Point(313, 371);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(107, 39);
            button1.TabIndex = 42;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(101, 17);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(451, 84);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 46;
            label2.Text = "Alat Dalam List";
            // 
            // AlatListBox
            // 
            AlatListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AlatListBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AlatListBox.Location = new Point(451, 115);
            AlatListBox.Margin = new Padding(3, 4, 3, 4);
            AlatListBox.Name = "AlatListBox";
            AlatListBox.RowHeadersWidth = 51;
            AlatListBox.Size = new Size(449, 248);
            AlatListBox.TabIndex = 45;
            // 
            // button2
            // 
            button2.Location = new Point(755, 371);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(107, 39);
            button2.TabIndex = 47;
            button2.Text = "Hapus";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(18, 20);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 48;
            label3.Text = "Mulai :";
            // 
            // button3
            // 
            button3.Location = new Point(649, 57);
            button3.Name = "button3";
            button3.Size = new Size(112, 29);
            button3.TabIndex = 50;
            button3.Text = "Mulai Pinjam";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(369, 17);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 50;
            label4.Text = "Kembali :";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(452, 14);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 49;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 551);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.Location = new Point(654, 519);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(107, 39);
            button4.TabIndex = 53;
            button4.Text = "Batal";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LoginButton.Location = new Point(773, 519);
            LoginButton.Margin = new Padding(3, 4, 3, 4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(107, 39);
            LoginButton.TabIndex = 52;
            LoginButton.Text = "Ajukan";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // DateStartPick
            // 
            DateStartPick.Location = new Point(329, 431);
            DateStartPick.Name = "DateStartPick";
            DateStartPick.Size = new Size(250, 27);
            DateStartPick.TabIndex = 54;
            // 
            // labelMulai
            // 
            labelMulai.AutoSize = true;
            labelMulai.Location = new Point(206, 436);
            labelMulai.Name = "labelMulai";
            labelMulai.Size = new Size(106, 20);
            labelMulai.TabIndex = 55;
            labelMulai.Text = "Mulai Pinjam : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(206, 481);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 56;
            label5.Text = "Kembali :";
            // 
            // DateEndPick
            // 
            DateEndPick.Location = new Point(329, 476);
            DateEndPick.Name = "DateEndPick";
            DateEndPick.Size = new Size(250, 27);
            DateEndPick.TabIndex = 57;
            // 
            // FormPinjam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(DateEndPick);
            Controls.Add(label5);
            Controls.Add(labelMulai);
            Controls.Add(DateStartPick);
            Controls.Add(button4);
            Controls.Add(LoginButton);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(AlatListBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(AlatGridBox);
            Controls.Add(JPinjamAlat);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPinjam";
            Text = "FormPinjam";
            ((System.ComponentModel.ISupportInitialize)AlatGridBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AlatListBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label JPinjamAlat;
        private LinkLabel linkLabel1;
        private DataGridView AlatGridBox;
        private Label label1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private DataGridView AlatListBox;
        private Button button2;
        private Label label3;
        private Button button3;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private PictureBox pictureBox1;
        private Button button4;
        private Button LoginButton;
        private DateTimePicker DateStartPick;
        private Label labelMulai;
        private Label label5;
        private DateTimePicker DateEndPick;
    }
}