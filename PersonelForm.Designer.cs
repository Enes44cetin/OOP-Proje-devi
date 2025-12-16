namespace OtoServisOtomasyonu
{
    partial class PersonelForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel7 = new Panel();
            label10 = new Label();
            numericMaas = new NumericUpDown();
            label9 = new Label();
            cmbPozisyon = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            panel9 = new Panel();
            txtSifre = new TextBox();
            panel8 = new Panel();
            txtKullaniciAdi = new TextBox();
            panel4 = new Panel();
            btnSil = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            btnGuncelle = new Button();
            btnEkle = new Button();
            txtTel = new TextBox();
            label4 = new Label();
            txtSoyad = new TextBox();
            label2 = new Label();
            txtAd = new TextBox();
            label1 = new Label();
            dgvPersoneller = new DataGridView();
            label6 = new Label();
            panel1 = new Panel();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericMaas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPersoneller).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(80, 80, 85);
            panel7.Controls.Add(label10);
            panel7.Controls.Add(numericMaas);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(cmbPozisyon);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(txtSifre);
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(txtKullaniciAdi);
            panel7.Controls.Add(panel4);
            panel7.Controls.Add(btnSil);
            panel7.Controls.Add(panel3);
            panel7.Controls.Add(panel2);
            panel7.Controls.Add(btnGuncelle);
            panel7.Controls.Add(btnEkle);
            panel7.Controls.Add(txtTel);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(txtSoyad);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(txtAd);
            panel7.Controls.Add(label1);
            panel7.Location = new Point(24, 65);
            panel7.Name = "panel7";
            panel7.Size = new Size(386, 566);
            panel7.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F);
            label10.ForeColor = Color.Silver;
            label10.Location = new Point(53, 263);
            label10.Name = "label10";
            label10.Size = new Size(54, 23);
            label10.TabIndex = 41;
            label10.Text = "Maaş:";
            // 
            // numericMaas
            // 
            numericMaas.BackColor = Color.FromArgb(80, 80, 85);
            numericMaas.BorderStyle = BorderStyle.None;
            numericMaas.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            numericMaas.ForeColor = Color.White;
            numericMaas.Location = new Point(108, 264);
            numericMaas.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            numericMaas.Name = "numericMaas";
            numericMaas.Size = new Size(231, 26);
            numericMaas.TabIndex = 40;
            numericMaas.Value = new decimal(new int[] { 22500, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(27, 230);
            label9.Name = "label9";
            label9.Size = new Size(80, 23);
            label9.TabIndex = 39;
            label9.Text = "Pozisyon:";
            // 
            // cmbPozisyon
            // 
            cmbPozisyon.BackColor = Color.FromArgb(80, 80, 85);
            cmbPozisyon.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPozisyon.FlatStyle = FlatStyle.Flat;
            cmbPozisyon.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbPozisyon.ForeColor = Color.White;
            cmbPozisyon.FormattingEnabled = true;
            cmbPozisyon.Location = new Point(108, 227);
            cmbPozisyon.Name = "cmbPozisyon";
            cmbPozisyon.Size = new Size(231, 31);
            cmbPozisyon.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(60, 188);
            label7.Name = "label7";
            label7.Size = new Size(47, 23);
            label7.TabIndex = 37;
            label7.Text = "Şifre:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(2, 149);
            label8.Name = "label8";
            label8.Size = new Size(105, 23);
            label8.TabIndex = 36;
            label8.Text = "Kullanıcı adı:";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Silver;
            panel9.Location = new Point(108, 209);
            panel9.Name = "panel9";
            panel9.Size = new Size(231, 2);
            panel9.TabIndex = 35;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.FromArgb(80, 80, 85);
            txtSifre.BorderStyle = BorderStyle.None;
            txtSifre.Font = new Font("Segoe UI", 10.8F);
            txtSifre.ForeColor = Color.White;
            txtSifre.Location = new Point(108, 184);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(231, 24);
            txtSifre.TabIndex = 34;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Silver;
            panel8.Location = new Point(108, 170);
            panel8.Name = "panel8";
            panel8.Size = new Size(231, 2);
            panel8.TabIndex = 33;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = Color.FromArgb(80, 80, 85);
            txtKullaniciAdi.BorderStyle = BorderStyle.None;
            txtKullaniciAdi.Font = new Font("Segoe UI", 10.8F);
            txtKullaniciAdi.ForeColor = Color.White;
            txtKullaniciAdi.Location = new Point(108, 145);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(231, 24);
            txtKullaniciAdi.TabIndex = 32;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Location = new Point(108, 128);
            panel4.Name = "panel4";
            panel4.Size = new Size(231, 2);
            panel4.TabIndex = 33;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(192, 57, 43);
            btnSil.FlatAppearance.BorderColor = Color.FromArgb(192, 57, 43);
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(108, 403);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(231, 40);
            btnSil.TabIndex = 30;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Location = new Point(108, 96);
            panel3.Name = "panel3";
            panel3.Size = new Size(231, 2);
            panel3.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(108, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 2);
            panel2.TabIndex = 31;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(230, 126, 34);
            btnGuncelle.FlatAppearance.BorderColor = Color.FromArgb(230, 126, 34);
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(108, 357);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(231, 40);
            btnGuncelle.TabIndex = 29;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(39, 174, 96);
            btnEkle.FlatAppearance.BorderColor = Color.FromArgb(39, 174, 96);
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(108, 311);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(231, 40);
            btnEkle.TabIndex = 28;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtTel
            // 
            txtTel.BackColor = Color.FromArgb(80, 80, 85);
            txtTel.BorderStyle = BorderStyle.None;
            txtTel.Font = new Font("Segoe UI", 10.8F);
            txtTel.ForeColor = Color.White;
            txtTel.Location = new Point(108, 104);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(231, 24);
            txtTel.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(39, 107);
            label4.Name = "label4";
            label4.Size = new Size(68, 23);
            label4.TabIndex = 22;
            label4.Text = "Telefon:";
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = Color.FromArgb(80, 80, 85);
            txtSoyad.BorderStyle = BorderStyle.None;
            txtSoyad.Font = new Font("Segoe UI", 10.8F);
            txtSoyad.ForeColor = Color.White;
            txtSoyad.Location = new Point(108, 71);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(231, 24);
            txtSoyad.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(47, 74);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 20;
            label2.Text = "Soyad:";
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.FromArgb(80, 80, 85);
            txtAd.BorderStyle = BorderStyle.None;
            txtAd.Font = new Font("Segoe UI", 10.8F);
            txtAd.ForeColor = Color.White;
            txtAd.Location = new Point(108, 38);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(231, 24);
            txtAd.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(72, 41);
            label1.Name = "label1";
            label1.Size = new Size(35, 23);
            label1.TabIndex = 18;
            label1.Text = "Ad:";
            // 
            // dgvPersoneller
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.GrayText;
            dgvPersoneller.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPersoneller.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersoneller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersoneller.Location = new Point(442, 65);
            dgvPersoneller.Name = "dgvPersoneller";
            dgvPersoneller.ReadOnly = true;
            dgvPersoneller.RowHeadersVisible = false;
            dgvPersoneller.RowHeadersWidth = 51;
            dgvPersoneller.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersoneller.Size = new Size(817, 566);
            dgvPersoneller.TabIndex = 23;
            dgvPersoneller.CellClick += dgvPersoneller_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(24, 9);
            label6.Name = "label6";
            label6.Size = new Size(358, 31);
            label6.TabIndex = 0;
            label6.Text = "PERSONEL YÖNETİMİ VE LİSTESİ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(230, 126, 34);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1271, 50);
            panel1.TabIndex = 24;
            // 
            // PersonelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(1271, 743);
            Controls.Add(panel1);
            Controls.Add(dgvPersoneller);
            Controls.Add(panel7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersonelForm";
            Text = "PersonelForm";
            Load += PersonelForm_Load;
            Click += PersonelForm_Load;
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericMaas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPersoneller).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private Panel panel4;
        private Button btnSil;
        private Panel panel3;
        private Panel panel2;
        private Button btnGuncelle;
        private Button btnEkle;
        private TextBox txtTel;
        private Label label4;
        private TextBox txtSoyad;
        private Label label2;
        private TextBox txtAd;
        private Label label1;
        private DataGridView dgvPersoneller;
        private Label label6;
        private Panel panel1;
        private Panel panel9;
        private TextBox txtSifre;
        private Panel panel8;
        private TextBox txtKullaniciAdi;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cmbPozisyon;
        private Label label10;
        private NumericUpDown numericMaas;
    }
}