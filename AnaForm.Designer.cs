namespace OtoServisOtomasyonu
{
    partial class AnaForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnPersonel = new Button();
            ımageList1 = new ImageList(components);
            btnMusteri = new Button();
            btnArac = new Button();
            btnServis = new Button();
            panel2 = new Panel();
            button1 = new Button();
            lblKullaniciBilgi = new Label();
            pnlIcerik = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 24, 24);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnPersonel);
            panel1.Controls.Add(btnMusteri);
            panel1.Controls.Add(btnArac);
            panel1.Controls.Add(btnServis);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 720);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 388);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnPersonel
            // 
            btnPersonel.Dock = DockStyle.Top;
            btnPersonel.FlatAppearance.BorderSize = 0;
            btnPersonel.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 80, 10);
            btnPersonel.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 160, 60);
            btnPersonel.FlatStyle = FlatStyle.Flat;
            btnPersonel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnPersonel.ImageAlign = ContentAlignment.MiddleLeft;
            btnPersonel.ImageKey = "AnaFormPersonelYonetimi.png";
            btnPersonel.ImageList = ımageList1;
            btnPersonel.Location = new Point(0, 180);
            btnPersonel.Name = "btnPersonel";
            btnPersonel.Padding = new Padding(20, 0, 0, 0);
            btnPersonel.Size = new Size(263, 60);
            btnPersonel.TabIndex = 3;
            btnPersonel.Text = "  Personel Yönetimi";
            btnPersonel.TextAlign = ContentAlignment.MiddleRight;
            btnPersonel.UseVisualStyleBackColor = true;
            btnPersonel.Click += btnPersonel_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "AnaFormServisİşlemleriLogosu.png");
            ımageList1.Images.SetKeyName(1, "AnaFormAraçYönetimiLogosu.png");
            ımageList1.Images.SetKeyName(2, "AnaFormMusteriYonetimi.png");
            ımageList1.Images.SetKeyName(3, "AnaFormPersonelYonetimi.png");
            // 
            // btnMusteri
            // 
            btnMusteri.Dock = DockStyle.Top;
            btnMusteri.FlatAppearance.BorderSize = 0;
            btnMusteri.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 80, 10);
            btnMusteri.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 160, 60);
            btnMusteri.FlatStyle = FlatStyle.Flat;
            btnMusteri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnMusteri.ImageAlign = ContentAlignment.MiddleLeft;
            btnMusteri.ImageKey = "AnaFormMusteriYonetimi.png";
            btnMusteri.ImageList = ımageList1;
            btnMusteri.Location = new Point(0, 120);
            btnMusteri.Name = "btnMusteri";
            btnMusteri.Padding = new Padding(20, 0, 0, 0);
            btnMusteri.Size = new Size(263, 60);
            btnMusteri.TabIndex = 2;
            btnMusteri.Text = "  Müşteriler";
            btnMusteri.UseVisualStyleBackColor = true;
            btnMusteri.Click += btnMusteri_Click;
            // 
            // btnArac
            // 
            btnArac.Dock = DockStyle.Top;
            btnArac.FlatAppearance.BorderSize = 0;
            btnArac.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 80, 10);
            btnArac.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 160, 60);
            btnArac.FlatStyle = FlatStyle.Flat;
            btnArac.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnArac.ImageAlign = ContentAlignment.MiddleLeft;
            btnArac.ImageKey = "AnaFormAraçYönetimiLogosu.png";
            btnArac.ImageList = ımageList1;
            btnArac.Location = new Point(0, 60);
            btnArac.Name = "btnArac";
            btnArac.Padding = new Padding(20, 0, 0, 0);
            btnArac.Size = new Size(263, 60);
            btnArac.TabIndex = 1;
            btnArac.Text = "    Araç Kabul";
            btnArac.UseVisualStyleBackColor = true;
            btnArac.Click += btnArac_Click;
            // 
            // btnServis
            // 
            btnServis.Dock = DockStyle.Top;
            btnServis.FlatAppearance.BorderSize = 0;
            btnServis.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 80, 10);
            btnServis.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 160, 60);
            btnServis.FlatStyle = FlatStyle.Flat;
            btnServis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnServis.ImageAlign = ContentAlignment.MiddleLeft;
            btnServis.ImageKey = "AnaFormServisİşlemleriLogosu.png";
            btnServis.ImageList = ımageList1;
            btnServis.Location = new Point(0, 0);
            btnServis.Name = "btnServis";
            btnServis.Padding = new Padding(20, 0, 0, 0);
            btnServis.Size = new Size(263, 60);
            btnServis.TabIndex = 0;
            btnServis.Text = "           Servis İşlemleri";
            btnServis.UseVisualStyleBackColor = true;
            btnServis.Click += btnServis_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 24, 24);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(lblKullaniciBilgi);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(263, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1237, 50);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 80, 10);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 160, 60);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1187, 5);
            button1.Name = "button1";
            button1.Size = new Size(38, 39);
            button1.TabIndex = 9;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblKullaniciBilgi
            // 
            lblKullaniciBilgi.AutoSize = true;
            lblKullaniciBilgi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKullaniciBilgi.Location = new Point(25, 11);
            lblKullaniciBilgi.Name = "lblKullaniciBilgi";
            lblKullaniciBilgi.Size = new Size(79, 31);
            lblKullaniciBilgi.TabIndex = 2;
            lblKullaniciBilgi.Text = "label1";
            // 
            // pnlIcerik
            // 
            pnlIcerik.Dock = DockStyle.Fill;
            pnlIcerik.Location = new Point(263, 50);
            pnlIcerik.Name = "pnlIcerik";
            pnlIcerik.Size = new Size(1237, 670);
            pnlIcerik.TabIndex = 2;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1500, 720);
            Controls.Add(pnlIcerik);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Oto Servis Yönetim Paneli";
            FormClosed += AnaForm_FormClosed;
            Load += AnaForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnPersonel;
        private Button btnMusteri;
        private Button btnArac;
        private Button btnServis;
        private Panel panel2;
        private Label lblKullaniciBilgi;
        private Button button1;
        private Panel pnlIcerik;
        private PictureBox pictureBox1;
        private ImageList ımageList1;
    }
}