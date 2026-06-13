namespace Tugas_Akhir_PBO.VIEW
{
    partial class FormAuturKategori
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuturKategori));
            JConsoleDaftar = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            labelNama = new Label();
            guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            linkLabel1 = new LinkLabel();
            guna2ContainerControl2 = new Guna.UI2.WinForms.Guna2ContainerControl();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            guna2ContainerControl1.SuspendLayout();
            guna2ContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // JConsoleDaftar
            // 
            JConsoleDaftar.AutoSize = true;
            JConsoleDaftar.Font = new Font("Inter Tight ExtraBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JConsoleDaftar.Location = new Point(12, 9);
            JConsoleDaftar.Name = "JConsoleDaftar";
            JConsoleDaftar.Size = new Size(193, 40);
            JConsoleDaftar.TabIndex = 3;
            JConsoleDaftar.Text = "Atur Kategori";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 279);
            dataGridView1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(500, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 27);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(672, 11);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(13, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Hapus";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(371, 13);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 8;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(199, 14);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 27);
            textBox2.TabIndex = 9;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(12, 55);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(98, 20);
            labelNama.TabIndex = 15;
            labelNama.Text = "Pilih Kategori";
            // 
            // guna2ContainerControl1
            // 
            guna2ContainerControl1.Controls.Add(linkLabel1);
            guna2ContainerControl1.CustomizableEdges = customizableEdges1;
            guna2ContainerControl1.Location = new Point(208, 12);
            guna2ContainerControl1.Name = "guna2ContainerControl1";
            guna2ContainerControl1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ContainerControl1.Size = new Size(580, 37);
            guna2ContainerControl1.TabIndex = 36;
            guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.White;
            linkLabel1.Location = new Point(531, 8);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(40, 20);
            linkLabel1.TabIndex = 31;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            // 
            // guna2ContainerControl2
            // 
            guna2ContainerControl2.Controls.Add(button2);
            guna2ContainerControl2.Controls.Add(textBox1);
            guna2ContainerControl2.Controls.Add(button1);
            guna2ContainerControl2.Controls.Add(textBox2);
            guna2ContainerControl2.Controls.Add(button3);
            guna2ContainerControl2.CustomizableEdges = customizableEdges3;
            guna2ContainerControl2.Location = new Point(12, 346);
            guna2ContainerControl2.Name = "guna2ContainerControl2";
            guna2ContainerControl2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ContainerControl2.Size = new Size(776, 52);
            guna2ContainerControl2.TabIndex = 37;
            guna2ContainerControl2.Text = "guna2ContainerControl2";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 413);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // FormAuturKategori
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(guna2ContainerControl1);
            Controls.Add(labelNama);
            Controls.Add(dataGridView1);
            Controls.Add(JConsoleDaftar);
            Controls.Add(guna2ContainerControl2);
            Name = "FormAuturKategori";
            Text = "FormAuturKategori";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            guna2ContainerControl1.ResumeLayout(false);
            guna2ContainerControl1.PerformLayout();
            guna2ContainerControl2.ResumeLayout(false);
            guna2ContainerControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label JConsoleDaftar;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private Label labelNama;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl2;
        private PictureBox pictureBox1;
    }
}