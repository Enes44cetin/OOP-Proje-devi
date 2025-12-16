namespace OtoServisOtomasyonu
{
    partial class AracForm
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
            openFileDialog1 = new OpenFileDialog();
            dgvAraclar = new DataGridView();
            panel1 = new Panel();
            label6 = new Label();
            panel7 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            btnAracSil = new Button();
            btnAracEkle = new Button();
            numYil = new NumericUpDown();
            label4 = new Label();
            txtModel = new TextBox();
            label5 = new Label();
            txtMarka = new TextBox();
            label3 = new Label();
            txtPlaka = new TextBox();
            label2 = new Label();
            cmbMusteri = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAraclar).BeginInit();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numYil).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgvAraclar
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.GrayText;
            dgvAraclar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAraclar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAraclar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAraclar.Location = new Point(398, 56);
            dgvAraclar.Name = "dgvAraclar";
            dgvAraclar.RowHeadersVisible = false;
            dgvAraclar.RowHeadersWidth = 51;
            dgvAraclar.Size = new Size(790, 426);
            dgvAraclar.TabIndex = 10;
            dgvAraclar.CellClick += dgvAraclar_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(230, 126, 34);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 50);
            panel1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(27, 9);
            label6.Name = "label6";
            label6.Size = new Size(304, 31);
            label6.TabIndex = 1;
            label6.Text = "ARAÇ KABUL VE YÖNETİMİ";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(80, 80, 85);
            panel7.Controls.Add(panel5);
            panel7.Controls.Add(panel4);
            panel7.Controls.Add(panel3);
            panel7.Controls.Add(panel2);
            panel7.Controls.Add(btnAracSil);
            panel7.Controls.Add(btnAracEkle);
            panel7.Controls.Add(numYil);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(txtModel);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(txtMarka);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(txtPlaka);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(cmbMusteri);
            panel7.Controls.Add(label1);
            panel7.Location = new Point(27, 57);
            panel7.Name = "panel7";
            panel7.Size = new Size(361, 387);
            panel7.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Location = new Point(96, 208);
            panel5.Name = "panel5";
            panel5.Size = new Size(208, 2);
            panel5.TabIndex = 31;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Location = new Point(96, 173);
            panel4.Name = "panel4";
            panel4.Size = new Size(208, 2);
            panel4.TabIndex = 32;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Location = new Point(96, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(208, 2);
            panel3.TabIndex = 33;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(96, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 2);
            panel2.TabIndex = 30;
            // 
            // btnAracSil
            // 
            btnAracSil.BackColor = Color.FromArgb(192, 57, 43);
            btnAracSil.FlatAppearance.BorderColor = Color.FromArgb(192, 57, 43);
            btnAracSil.FlatStyle = FlatStyle.Flat;
            btnAracSil.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAracSil.ForeColor = Color.White;
            btnAracSil.Location = new Point(97, 294);
            btnAracSil.Name = "btnAracSil";
            btnAracSil.Size = new Size(209, 40);
            btnAracSil.TabIndex = 29;
            btnAracSil.Text = "Sil";
            btnAracSil.UseVisualStyleBackColor = false;
            btnAracSil.Click += btnAracSil_Click;
            // 
            // btnAracEkle
            // 
            btnAracEkle.BackColor = Color.FromArgb(39, 174, 96);
            btnAracEkle.FlatAppearance.BorderColor = Color.FromArgb(39, 174, 96);
            btnAracEkle.FlatStyle = FlatStyle.Flat;
            btnAracEkle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAracEkle.ForeColor = Color.White;
            btnAracEkle.Location = new Point(97, 248);
            btnAracEkle.Name = "btnAracEkle";
            btnAracEkle.Size = new Size(209, 40);
            btnAracEkle.TabIndex = 28;
            btnAracEkle.Text = "Kaydet";
            btnAracEkle.UseVisualStyleBackColor = false;
            btnAracEkle.Click += btnAracEkle_Click;
            // 
            // numYil
            // 
            numYil.BackColor = Color.FromArgb(80, 80, 85);
            numYil.BorderStyle = BorderStyle.None;
            numYil.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            numYil.ForeColor = Color.White;
            numYil.Location = new Point(97, 185);
            numYil.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            numYil.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            numYil.Name = "numYil";
            numYil.Size = new Size(207, 26);
            numYil.TabIndex = 27;
            numYil.Value = new decimal(new int[] { 2023, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(64, 187);
            label4.Name = "label4";
            label4.Size = new Size(31, 23);
            label4.TabIndex = 26;
            label4.Text = "Yıl:";
            // 
            // txtModel
            // 
            txtModel.BackColor = Color.FromArgb(80, 80, 85);
            txtModel.BorderStyle = BorderStyle.None;
            txtModel.Font = new Font("Segoe UI", 10.2F);
            txtModel.ForeColor = Color.White;
            txtModel.Location = new Point(97, 149);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(208, 23);
            txtModel.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(37, 152);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 24;
            label5.Text = "Model:";
            // 
            // txtMarka
            // 
            txtMarka.BackColor = Color.FromArgb(80, 80, 85);
            txtMarka.BorderStyle = BorderStyle.None;
            txtMarka.Font = new Font("Segoe UI", 10.2F);
            txtMarka.ForeColor = Color.White;
            txtMarka.Location = new Point(97, 116);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(208, 23);
            txtMarka.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(39, 119);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 22;
            label3.Text = "Marka:";
            // 
            // txtPlaka
            // 
            txtPlaka.BackColor = Color.FromArgb(80, 80, 85);
            txtPlaka.BorderStyle = BorderStyle.None;
            txtPlaka.Font = new Font("Segoe UI", 10.2F);
            txtPlaka.ForeColor = Color.White;
            txtPlaka.Location = new Point(97, 83);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(208, 23);
            txtPlaka.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(45, 86);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 20;
            label2.Text = "Plaka:";
            // 
            // cmbMusteri
            // 
            cmbMusteri.BackColor = Color.FromArgb(80, 80, 85);
            cmbMusteri.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMusteri.FlatStyle = FlatStyle.Flat;
            cmbMusteri.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbMusteri.ForeColor = Color.White;
            cmbMusteri.FormattingEnabled = true;
            cmbMusteri.Location = new Point(97, 49);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(208, 31);
            cmbMusteri.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(31, 52);
            label1.Name = "label1";
            label1.Size = new Size(71, 23);
            label1.TabIndex = 18;
            label1.Text = "Müşteri:";
            // 
            // AracForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(1200, 540);
            Controls.Add(panel7);
            Controls.Add(panel1);
            Controls.Add(dgvAraclar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AracForm";
            Text = "Araç Kabul ve Yönetimi";
            Load += AracForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAraclar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numYil).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private DataGridView dgvAraclar;
        private Panel panel1;
        private Label label6;
        private Panel panel7;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Button btnAracSil;
        private Button btnAracEkle;
        private NumericUpDown numYil;
        private Label label4;
        private TextBox txtModel;
        private Label label5;
        private TextBox txtMarka;
        private Label label3;
        private TextBox txtPlaka;
        private Label label2;
        private ComboBox cmbMusteri;
        private Label label1;
    }
}