namespace OtoServisOtomasyonu
{
    partial class MusteriForm
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
            dgvMusteriler = new DataGridView();
            panel1 = new Panel();
            label6 = new Label();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            btnGuncelle = new Button();
            btnEkle = new Button();
            txtAdres = new TextBox();
            label5 = new Label();
            txtMail = new TextBox();
            label3 = new Label();
            txtTel = new TextBox();
            label4 = new Label();
            txtSoyad = new TextBox();
            label2 = new Label();
            txtAd = new TextBox();
            label1 = new Label();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMusteriler
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.GrayText;
            dgvMusteriler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMusteriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriler.Location = new Point(402, 57);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.ReadOnly = true;
            dgvMusteriler.RowHeadersVisible = false;
            dgvMusteriler.RowHeadersWidth = 51;
            dgvMusteriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMusteriler.Size = new Size(786, 484);
            dgvMusteriler.TabIndex = 0;
            dgvMusteriler.CellClick += dgvMusteriler_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(230, 126, 34);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 50);
            panel1.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(24, 9);
            label6.Name = "label6";
            label6.Size = new Size(344, 31);
            label6.TabIndex = 0;
            label6.Text = "MÜŞTERİ YÖNETİMİ VE LİSTESİ";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(80, 80, 85);
            panel7.Controls.Add(panel6);
            panel7.Controls.Add(panel5);
            panel7.Controls.Add(panel4);
            panel7.Controls.Add(btnSil);
            panel7.Controls.Add(panel3);
            panel7.Controls.Add(panel2);
            panel7.Controls.Add(btnGuncelle);
            panel7.Controls.Add(btnEkle);
            panel7.Controls.Add(txtAdres);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(txtMail);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(txtTel);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(txtSoyad);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(txtAd);
            panel7.Controls.Add(label1);
            panel7.Location = new Point(24, 57);
            panel7.Name = "panel7";
            panel7.Size = new Size(361, 425);
            panel7.TabIndex = 21;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Silver;
            panel6.Location = new Point(91, 194);
            panel6.Name = "panel6";
            panel6.Size = new Size(231, 2);
            panel6.TabIndex = 35;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Location = new Point(91, 161);
            panel5.Name = "panel5";
            panel5.Size = new Size(231, 2);
            panel5.TabIndex = 34;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Location = new Point(91, 128);
            panel4.Name = "panel4";
            panel4.Size = new Size(231, 2);
            panel4.TabIndex = 33;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Location = new Point(91, 96);
            panel3.Name = "panel3";
            panel3.Size = new Size(231, 2);
            panel3.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(91, 63);
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
            btnGuncelle.Location = new Point(91, 303);
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
            btnEkle.Location = new Point(91, 257);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(231, 40);
            btnEkle.TabIndex = 28;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtAdres
            // 
            txtAdres.BackColor = Color.FromArgb(80, 80, 85);
            txtAdres.BorderStyle = BorderStyle.None;
            txtAdres.Font = new Font("Segoe UI", 10.8F);
            txtAdres.ForeColor = Color.White;
            txtAdres.Location = new Point(91, 170);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(231, 60);
            txtAdres.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(36, 173);
            label5.Name = "label5";
            label5.Size = new Size(57, 23);
            label5.TabIndex = 26;
            label5.Text = "Adres:";
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.FromArgb(80, 80, 85);
            txtMail.BorderStyle = BorderStyle.None;
            txtMail.Font = new Font("Segoe UI", 10.8F);
            txtMail.ForeColor = Color.White;
            txtMail.Location = new Point(91, 137);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(231, 24);
            txtMail.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(31, 140);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 24;
            label3.Text = "E-mail:";
            // 
            // txtTel
            // 
            txtTel.BackColor = Color.FromArgb(80, 80, 85);
            txtTel.BorderStyle = BorderStyle.None;
            txtTel.Font = new Font("Segoe UI", 10.8F);
            txtTel.ForeColor = Color.White;
            txtTel.Location = new Point(91, 104);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(231, 24);
            txtTel.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(25, 107);
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
            txtSoyad.Location = new Point(91, 71);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(231, 24);
            txtSoyad.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(33, 74);
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
            txtAd.Location = new Point(91, 38);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(231, 24);
            txtAd.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(55, 41);
            label1.Name = "label1";
            label1.Size = new Size(35, 23);
            label1.TabIndex = 18;
            label1.Text = "Ad:";
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(192, 57, 43);
            btnSil.FlatAppearance.BorderColor = Color.FromArgb(192, 57, 43);
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(91, 349);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(231, 40);
            btnSil.TabIndex = 30;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // MusteriForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(1200, 563);
            Controls.Add(panel7);
            Controls.Add(panel1);
            Controls.Add(dgvMusteriler);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MusteriForm";
            Text = "Müşteri Yönetimi";
            Load += MusteriForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMusteriler;
        private Panel panel1;
        private Label label6;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private TextBox txtAdres;
        private Label label5;
        private TextBox txtMail;
        private Label label3;
        private TextBox txtTel;
        private Label label4;
        private TextBox txtSoyad;
        private Label label2;
        private TextBox txtAd;
        private Label label1;
    }
}