namespace OtoServisOtomasyonu
{
    partial class ServisForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            cmbPlakalar = new ComboBox();
            label2 = new Label();
            txtIslem = new TextBox();
            label3 = new Label();
            numUcret = new NumericUpDown();
            cmbDurum = new ComboBox();
            label4 = new Label();
            btnServisAc = new Button();
            dgvServisler = new DataGridView();
            notifyIcon1 = new NotifyIcon(components);
            label6 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            btnServisSil = new Button();
            btnServisGuncelle = new Button();
            pnlIstatistikFooter = new Panel();
            panel7 = new Panel();
            label5 = new Label();
            lblToplamArac = new Label();
            panel8 = new Panel();
            lblIslemdekiler = new Label();
            label8 = new Label();
            panel9 = new Panel();
            lblParcaBekleyen = new Label();
            label10 = new Label();
            panel10 = new Panel();
            lblToplamKazanc = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)numUcret).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServisler).BeginInit();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            pnlIstatistikFooter.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(42, 43);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 0;
            label1.Text = "Araç Plaka:";
            // 
            // cmbPlakalar
            // 
            cmbPlakalar.BackColor = Color.FromArgb(80, 80, 85);
            cmbPlakalar.FlatStyle = FlatStyle.Flat;
            cmbPlakalar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbPlakalar.ForeColor = Color.White;
            cmbPlakalar.FormattingEnabled = true;
            cmbPlakalar.Location = new Point(134, 40);
            cmbPlakalar.Name = "cmbPlakalar";
            cmbPlakalar.Size = new Size(183, 31);
            cmbPlakalar.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(21, 77);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 2;
            label2.Text = "Şikayet/İşlem:";
            // 
            // txtIslem
            // 
            txtIslem.BackColor = Color.FromArgb(80, 80, 85);
            txtIslem.BorderStyle = BorderStyle.None;
            txtIslem.ForeColor = Color.White;
            txtIslem.Location = new Point(134, 74);
            txtIslem.Multiline = true;
            txtIslem.Name = "txtIslem";
            txtIslem.Size = new Size(183, 80);
            txtIslem.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(75, 162);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 4;
            label3.Text = "Tutar:";
            label3.Click += label3_Click;
            // 
            // numUcret
            // 
            numUcret.BackColor = Color.FromArgb(80, 80, 85);
            numUcret.BorderStyle = BorderStyle.None;
            numUcret.DecimalPlaces = 2;
            numUcret.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            numUcret.ForeColor = Color.White;
            numUcret.Location = new Point(134, 160);
            numUcret.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numUcret.Name = "numUcret";
            numUcret.Size = new Size(183, 26);
            numUcret.TabIndex = 5;
            numUcret.TextAlign = HorizontalAlignment.Right;
            // 
            // cmbDurum
            // 
            cmbDurum.BackColor = Color.FromArgb(80, 80, 85);
            cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDurum.ForeColor = Color.White;
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Items.AddRange(new object[] { "İşlemde", "Parça Bekliyor", "Tamamlandı" });
            cmbDurum.Location = new Point(134, 193);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(183, 28);
            cmbDurum.TabIndex = 7;
            cmbDurum.SelectedIndexChanged += cmbDurum_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(64, 196);
            label4.Name = "label4";
            label4.Size = new Size(67, 23);
            label4.TabIndex = 6;
            label4.Text = "Durum:";
            // 
            // btnServisAc
            // 
            btnServisAc.BackColor = Color.FromArgb(39, 174, 96);
            btnServisAc.FlatAppearance.BorderColor = Color.FromArgb(39, 174, 96);
            btnServisAc.FlatStyle = FlatStyle.Flat;
            btnServisAc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnServisAc.ForeColor = Color.White;
            btnServisAc.Location = new Point(134, 257);
            btnServisAc.Name = "btnServisAc";
            btnServisAc.Size = new Size(183, 40);
            btnServisAc.TabIndex = 8;
            btnServisAc.Text = "Servis Kaydı Aç";
            btnServisAc.UseVisualStyleBackColor = false;
            btnServisAc.Click += btnServisAc_Click_1;
            // 
            // dgvServisler
            // 
            dataGridViewCellStyle2.BackColor = SystemColors.GrayText;
            dgvServisler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvServisler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServisler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServisler.Location = new Point(456, 56);
            dgvServisler.MultiSelect = false;
            dgvServisler.Name = "dgvServisler";
            dgvServisler.RowHeadersVisible = false;
            dgvServisler.RowHeadersWidth = 51;
            dgvServisler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServisler.Size = new Size(687, 426);
            dgvServisler.TabIndex = 9;
            dgvServisler.CellClick += dgvServisler_CellClick;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(24, 9);
            label6.Name = "label6";
            label6.Size = new Size(309, 31);
            label6.TabIndex = 0;
            label6.Text = "SERVİS İŞLEMLERİ VE KAYIT";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(230, 126, 34);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 50);
            panel1.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Location = new Point(134, 69);
            panel5.Name = "panel5";
            panel5.Size = new Size(183, 2);
            panel5.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(134, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 2);
            panel2.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Location = new Point(134, 183);
            panel3.Name = "panel3";
            panel3.Size = new Size(183, 2);
            panel3.TabIndex = 19;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Location = new Point(134, 217);
            panel4.Name = "panel4";
            panel4.Size = new Size(183, 2);
            panel4.TabIndex = 19;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(80, 80, 85);
            panel6.Controls.Add(btnServisSil);
            panel6.Controls.Add(btnServisGuncelle);
            panel6.Controls.Add(cmbPlakalar);
            panel6.Controls.Add(panel4);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(panel3);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(panel2);
            panel6.Controls.Add(txtIslem);
            panel6.Controls.Add(panel5);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(numUcret);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(btnServisAc);
            panel6.Controls.Add(cmbDurum);
            panel6.Location = new Point(45, 56);
            panel6.Name = "panel6";
            panel6.Size = new Size(369, 426);
            panel6.TabIndex = 20;
            // 
            // btnServisSil
            // 
            btnServisSil.BackColor = Color.FromArgb(192, 57, 43);
            btnServisSil.FlatAppearance.BorderColor = Color.FromArgb(192, 57, 43);
            btnServisSil.FlatStyle = FlatStyle.Flat;
            btnServisSil.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnServisSil.ForeColor = Color.White;
            btnServisSil.Location = new Point(134, 349);
            btnServisSil.Name = "btnServisSil";
            btnServisSil.Size = new Size(183, 40);
            btnServisSil.TabIndex = 32;
            btnServisSil.Text = "Sil";
            btnServisSil.UseVisualStyleBackColor = false;
            btnServisSil.Click += btnServisSil_Click;
            // 
            // btnServisGuncelle
            // 
            btnServisGuncelle.BackColor = Color.FromArgb(230, 126, 34);
            btnServisGuncelle.FlatAppearance.BorderColor = Color.FromArgb(230, 126, 34);
            btnServisGuncelle.FlatStyle = FlatStyle.Flat;
            btnServisGuncelle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnServisGuncelle.ForeColor = Color.White;
            btnServisGuncelle.Location = new Point(134, 303);
            btnServisGuncelle.Name = "btnServisGuncelle";
            btnServisGuncelle.Size = new Size(183, 40);
            btnServisGuncelle.TabIndex = 31;
            btnServisGuncelle.Text = "Güncelle";
            btnServisGuncelle.UseVisualStyleBackColor = false;
            btnServisGuncelle.Click += btnServisGuncelle_Click;
            // 
            // pnlIstatistikFooter
            // 
            pnlIstatistikFooter.BackColor = Color.FromArgb(80, 80, 85);
            pnlIstatistikFooter.Controls.Add(panel10);
            pnlIstatistikFooter.Controls.Add(panel9);
            pnlIstatistikFooter.Controls.Add(panel8);
            pnlIstatistikFooter.Controls.Add(panel7);
            pnlIstatistikFooter.Dock = DockStyle.Bottom;
            pnlIstatistikFooter.Location = new Point(0, 525);
            pnlIstatistikFooter.Name = "pnlIstatistikFooter";
            pnlIstatistikFooter.Size = new Size(1182, 80);
            pnlIstatistikFooter.TabIndex = 33;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(50, 50, 50);
            panel7.Controls.Add(lblToplamArac);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(45, 10);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 60);
            panel7.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(42, 5);
            label5.Name = "label5";
            label5.Size = new Size(123, 23);
            label5.TabIndex = 33;
            label5.Text = "TOPLAM KAYIT";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblToplamArac
            // 
            lblToplamArac.AutoSize = true;
            lblToplamArac.Font = new Font("Segoe UI", 10.2F);
            lblToplamArac.ForeColor = Color.Silver;
            lblToplamArac.Location = new Point(85, 28);
            lblToplamArac.Name = "lblToplamArac";
            lblToplamArac.Size = new Size(19, 23);
            lblToplamArac.TabIndex = 34;
            lblToplamArac.Text = "0";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(50, 50, 50);
            panel8.Controls.Add(lblIslemdekiler);
            panel8.Controls.Add(label8);
            panel8.Location = new Point(329, 8);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 60);
            panel8.TabIndex = 35;
            // 
            // lblIslemdekiler
            // 
            lblIslemdekiler.AutoSize = true;
            lblIslemdekiler.Font = new Font("Segoe UI", 10.2F);
            lblIslemdekiler.ForeColor = Color.Silver;
            lblIslemdekiler.Location = new Point(85, 28);
            lblIslemdekiler.Name = "lblIslemdekiler";
            lblIslemdekiler.Size = new Size(19, 23);
            lblIslemdekiler.TabIndex = 34;
            lblIslemdekiler.Text = "0";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(18, 5);
            label8.Name = "label8";
            label8.Size = new Size(169, 23);
            label8.TabIndex = 33;
            label8.Text = "İŞLEMDEKİ ARAÇLAR";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(50, 50, 50);
            panel9.Controls.Add(lblParcaBekleyen);
            panel9.Controls.Add(label10);
            panel9.Location = new Point(638, 8);
            panel9.Name = "panel9";
            panel9.Size = new Size(200, 60);
            panel9.TabIndex = 35;
            // 
            // lblParcaBekleyen
            // 
            lblParcaBekleyen.AutoSize = true;
            lblParcaBekleyen.Font = new Font("Segoe UI", 10.2F);
            lblParcaBekleyen.ForeColor = Color.Silver;
            lblParcaBekleyen.Location = new Point(85, 28);
            lblParcaBekleyen.Name = "lblParcaBekleyen";
            lblParcaBekleyen.Size = new Size(19, 23);
            lblParcaBekleyen.TabIndex = 34;
            lblParcaBekleyen.Text = "0";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F);
            label10.ForeColor = Color.Silver;
            label10.Location = new Point(28, 5);
            label10.Name = "label10";
            label10.Size = new Size(144, 23);
            label10.TabIndex = 33;
            label10.Text = "PARÇA BEKLEYEN";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(50, 50, 50);
            panel10.Controls.Add(lblToplamKazanc);
            panel10.Controls.Add(label12);
            panel10.Location = new Point(943, 10);
            panel10.Name = "panel10";
            panel10.Size = new Size(200, 60);
            panel10.TabIndex = 35;
            // 
            // lblToplamKazanc
            // 
            lblToplamKazanc.AutoSize = true;
            lblToplamKazanc.Font = new Font("Segoe UI", 10.2F);
            lblToplamKazanc.ForeColor = Color.Silver;
            lblToplamKazanc.Location = new Point(85, 28);
            lblToplamKazanc.Name = "lblToplamKazanc";
            lblToplamKazanc.Size = new Size(19, 23);
            lblToplamKazanc.TabIndex = 34;
            lblToplamKazanc.Text = "0";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F);
            label12.ForeColor = Color.Silver;
            label12.Location = new Point(40, 5);
            label12.Name = "label12";
            label12.Size = new Size(119, 23);
            label12.TabIndex = 33;
            label12.Text = "TOPLAM CİRO";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // ServisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(1182, 605);
            Controls.Add(pnlIstatistikFooter);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Controls.Add(dgvServisler);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ServisForm";
            Text = "Servis İşlemleri ve Kayıt";
            Load += ServisForm_Load;
            ((System.ComponentModel.ISupportInitialize)numUcret).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServisler).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            pnlIstatistikFooter.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox cmbPlakalar;
        private Label label2;
        private TextBox txtIslem;
        private Label label3;
        private NumericUpDown numUcret;
        private ComboBox cmbDurum;
        private Label label4;
        private Button btnServisAc;
        private DataGridView dgvServisler;
        private NotifyIcon notifyIcon1;
        private Label label6;
        private Panel panel1;
        private Panel panel5;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private Button btnServisSil;
        private Button btnServisGuncelle;
        private Panel pnlIstatistikFooter;
        private Panel panel7;
        private Panel panel10;
        private Label lblToplamKazanc;
        private Label label12;
        private Panel panel9;
        private Label lblParcaBekleyen;
        private Label label10;
        private Panel panel8;
        private Label lblIslemdekiler;
        private Label label8;
        private Label lblToplamArac;
        private Label label5;
    }
}