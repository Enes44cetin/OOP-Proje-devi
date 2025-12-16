namespace OtoServisOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(377, 132);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = Color.FromArgb(30, 30, 30);
            txtKullaniciAdi.BorderStyle = BorderStyle.None;
            txtKullaniciAdi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKullaniciAdi.ForeColor = Color.White;
            txtKullaniciAdi.Location = new Point(490, 128);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(125, 27);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.FromArgb(30, 30, 30);
            txtSifre.BorderStyle = BorderStyle.None;
            txtSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.ForeColor = Color.White;
            txtSifre.Location = new Point(488, 196);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 3;
            // 
            // btnGiris
            // 
            btnGiris.FlatAppearance.BorderSize = 0;
            btnGiris.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 80, 10);
            btnGiris.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 160, 60);
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGiris.ForeColor = Color.White;
            btnGiris.Location = new Point(387, 283);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(228, 39);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(230, 126, 34);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 450);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 233);
            label3.Name = "label3";
            label3.Size = new Size(174, 76);
            label3.TabIndex = 7;
            label3.Text = "OTO SERVİS\r\n YÖNETİMİ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(488, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(127, 1);
            panel2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(435, 197);
            label4.Name = "label4";
            label4.Size = new Size(47, 23);
            label4.TabIndex = 7;
            label4.Text = "Şifre:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Location = new Point(486, 222);
            panel3.Name = "panel3";
            panel3.Size = new Size(127, 1);
            panel3.TabIndex = 7;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 80, 10);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 160, 60);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(700, 12);
            button1.Name = "button1";
            button1.Size = new Size(38, 39);
            button1.TabIndex = 8;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(750, 450);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Ekranı";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnGiris;
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label4;
        private Panel panel3;
        private Button button1;
    }
}
