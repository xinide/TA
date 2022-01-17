namespace Perpustakaan_MI_Darussalam
{
    partial class FormPengembalian
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
            this.ButtonTutupPengembalian = new System.Windows.Forms.Button();
            this.GroupPengembalian = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.KodeBukuPengembalian = new System.Windows.Forms.Label();
            this.TextKodeBuku = new System.Windows.Forms.TextBox();
            this.TextIDAnggota = new System.Windows.Forms.TextBox();
            this.ComboBoxKodePinjam = new System.Windows.Forms.ComboBox();
            this.ButtonKonfirmasi = new System.Windows.Forms.Button();
            this.ButtonHitungDenda = new System.Windows.Forms.Button();
            this.ButtonCekDenda = new System.Windows.Forms.Button();
            this.TextDendaKembali = new System.Windows.Forms.TextBox();
            this.TextLamaPinjamKembali = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextCariPengembalian = new System.Windows.Forms.TextBox();
            this.ComboPilihanPengembalian = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButtonBatalPengembalian = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupPengembalian.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonTutupPengembalian
            // 
            this.ButtonTutupPengembalian.Location = new System.Drawing.Point(981, 209);
            this.ButtonTutupPengembalian.Name = "ButtonTutupPengembalian";
            this.ButtonTutupPengembalian.Size = new System.Drawing.Size(118, 55);
            this.ButtonTutupPengembalian.TabIndex = 10;
            this.ButtonTutupPengembalian.Text = "Tutup";
            this.ButtonTutupPengembalian.UseVisualStyleBackColor = true;
            this.ButtonTutupPengembalian.Click += new System.EventHandler(this.ButtonTutupPengembalian_Click);
            // 
            // GroupPengembalian
            // 
            this.GroupPengembalian.Controls.Add(this.label9);
            this.GroupPengembalian.Controls.Add(this.KodeBukuPengembalian);
            this.GroupPengembalian.Controls.Add(this.TextKodeBuku);
            this.GroupPengembalian.Controls.Add(this.TextIDAnggota);
            this.GroupPengembalian.Controls.Add(this.ComboBoxKodePinjam);
            this.GroupPengembalian.Controls.Add(this.ButtonKonfirmasi);
            this.GroupPengembalian.Controls.Add(this.ButtonHitungDenda);
            this.GroupPengembalian.Controls.Add(this.ButtonCekDenda);
            this.GroupPengembalian.Controls.Add(this.TextDendaKembali);
            this.GroupPengembalian.Controls.Add(this.TextLamaPinjamKembali);
            this.GroupPengembalian.Controls.Add(this.dateTimePicker2);
            this.GroupPengembalian.Controls.Add(this.dateTimePicker1);
            this.GroupPengembalian.Controls.Add(this.label6);
            this.GroupPengembalian.Controls.Add(this.label5);
            this.GroupPengembalian.Controls.Add(this.label4);
            this.GroupPengembalian.Controls.Add(this.label3);
            this.GroupPengembalian.Controls.Add(this.label1);
            this.GroupPengembalian.Location = new System.Drawing.Point(21, 12);
            this.GroupPengembalian.Name = "GroupPengembalian";
            this.GroupPengembalian.Size = new System.Drawing.Size(720, 373);
            this.GroupPengembalian.TabIndex = 8;
            this.GroupPengembalian.TabStop = false;
            this.GroupPengembalian.Text = "Input Data Pengembalian";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 27);
            this.label9.TabIndex = 20;
            this.label9.Text = "ID Anggota";
            // 
            // KodeBukuPengembalian
            // 
            this.KodeBukuPengembalian.AutoSize = true;
            this.KodeBukuPengembalian.Location = new System.Drawing.Point(27, 114);
            this.KodeBukuPengembalian.Name = "KodeBukuPengembalian";
            this.KodeBukuPengembalian.Size = new System.Drawing.Size(122, 27);
            this.KodeBukuPengembalian.TabIndex = 19;
            this.KodeBukuPengembalian.Text = "Kode Buku";
            // 
            // TextKodeBuku
            // 
            this.TextKodeBuku.Location = new System.Drawing.Point(263, 111);
            this.TextKodeBuku.Name = "TextKodeBuku";
            this.TextKodeBuku.Size = new System.Drawing.Size(269, 35);
            this.TextKodeBuku.TabIndex = 18;
            // 
            // TextIDAnggota
            // 
            this.TextIDAnggota.Location = new System.Drawing.Point(263, 69);
            this.TextIDAnggota.Name = "TextIDAnggota";
            this.TextIDAnggota.Size = new System.Drawing.Size(269, 35);
            this.TextIDAnggota.TabIndex = 17;
            // 
            // ComboBoxKodePinjam
            // 
            this.ComboBoxKodePinjam.FormattingEnabled = true;
            this.ComboBoxKodePinjam.Location = new System.Drawing.Point(263, 28);
            this.ComboBoxKodePinjam.Name = "ComboBoxKodePinjam";
            this.ComboBoxKodePinjam.Size = new System.Drawing.Size(269, 35);
            this.ComboBoxKodePinjam.TabIndex = 16;
            this.ComboBoxKodePinjam.SelectedIndexChanged += new System.EventHandler(this.ComboBoxKodePinjam_SelectedIndexChanged);
            // 
            // ButtonKonfirmasi
            // 
            this.ButtonKonfirmasi.Location = new System.Drawing.Point(581, 318);
            this.ButtonKonfirmasi.Name = "ButtonKonfirmasi";
            this.ButtonKonfirmasi.Size = new System.Drawing.Size(127, 46);
            this.ButtonKonfirmasi.TabIndex = 14;
            this.ButtonKonfirmasi.Text = "Konfirmasi";
            this.ButtonKonfirmasi.UseVisualStyleBackColor = true;
            this.ButtonKonfirmasi.Click += new System.EventHandler(this.ButtonKonfirmasi_Click);
            // 
            // ButtonHitungDenda
            // 
            this.ButtonHitungDenda.Location = new System.Drawing.Point(389, 316);
            this.ButtonHitungDenda.Name = "ButtonHitungDenda";
            this.ButtonHitungDenda.Size = new System.Drawing.Size(172, 51);
            this.ButtonHitungDenda.TabIndex = 13;
            this.ButtonHitungDenda.Text = "Hitung Denda";
            this.ButtonHitungDenda.UseVisualStyleBackColor = true;
            this.ButtonHitungDenda.Click += new System.EventHandler(this.ButtonHitungDenda_Click);
            // 
            // ButtonCekDenda
            // 
            this.ButtonCekDenda.Location = new System.Drawing.Point(263, 316);
            this.ButtonCekDenda.Name = "ButtonCekDenda";
            this.ButtonCekDenda.Size = new System.Drawing.Size(106, 51);
            this.ButtonCekDenda.TabIndex = 12;
            this.ButtonCekDenda.Text = "Cek";
            this.ButtonCekDenda.UseVisualStyleBackColor = true;
            this.ButtonCekDenda.Click += new System.EventHandler(this.ButtonCekDenda_Click);
            // 
            // TextDendaKembali
            // 
            this.TextDendaKembali.Location = new System.Drawing.Point(263, 275);
            this.TextDendaKembali.Name = "TextDendaKembali";
            this.TextDendaKembali.Size = new System.Drawing.Size(133, 35);
            this.TextDendaKembali.TabIndex = 11;
            this.TextDendaKembali.TextChanged += new System.EventHandler(this.TextDendaKembali_TextChanged);
            // 
            // TextLamaPinjamKembali
            // 
            this.TextLamaPinjamKembali.Location = new System.Drawing.Point(263, 234);
            this.TextLamaPinjamKembali.Name = "TextLamaPinjamKembali";
            this.TextLamaPinjamKembali.Size = new System.Drawing.Size(269, 35);
            this.TextLamaPinjamKembali.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(263, 193);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(269, 35);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(263, 152);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(269, 35);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Denda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lama Pinjam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Pengembalian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal Batas Pinjam";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Pinjam";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TextCariPengembalian);
            this.groupBox1.Controls.Add(this.ComboPilihanPengembalian);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(769, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 173);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Data Pengembalian";
            // 
            // TextCariPengembalian
            // 
            this.TextCariPengembalian.Location = new System.Drawing.Point(136, 104);
            this.TextCariPengembalian.Name = "TextCariPengembalian";
            this.TextCariPengembalian.Size = new System.Drawing.Size(226, 35);
            this.TextCariPengembalian.TabIndex = 16;
            this.TextCariPengembalian.TextChanged += new System.EventHandler(this.TextCariPengembalian_TextChanged);
            // 
            // ComboPilihanPengembalian
            // 
            this.ComboPilihanPengembalian.FormattingEnabled = true;
            this.ComboPilihanPengembalian.Items.AddRange(new object[] {
            "Kode Pinjam",
            "ID Anggota",
            "Kode Buku"});
            this.ComboPilihanPengembalian.Location = new System.Drawing.Point(136, 52);
            this.ComboPilihanPengembalian.Name = "ComboPilihanPengembalian";
            this.ComboPilihanPengembalian.Size = new System.Drawing.Size(226, 35);
            this.ComboPilihanPengembalian.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 27);
            this.label8.TabIndex = 1;
            this.label8.Text = "Cari";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "Pilihan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 405);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1110, 243);
            this.dataGridView1.TabIndex = 11;
            // 
            // ButtonBatalPengembalian
            // 
            this.ButtonBatalPengembalian.Location = new System.Drawing.Point(831, 209);
            this.ButtonBatalPengembalian.Name = "ButtonBatalPengembalian";
            this.ButtonBatalPengembalian.Size = new System.Drawing.Size(118, 55);
            this.ButtonBatalPengembalian.TabIndex = 12;
            this.ButtonBatalPengembalian.Text = "Batal";
            this.ButtonBatalPengembalian.UseVisualStyleBackColor = true;
            this.ButtonBatalPengembalian.Click += new System.EventHandler(this.ButtonBatalPengembalian_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 655);
            this.Controls.Add(this.ButtonBatalPengembalian);
            this.Controls.Add(this.ButtonTutupPengembalian);
            this.Controls.Add(this.GroupPengembalian);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPengembalian";
            this.Text = "Pengembalian";
            this.Load += new System.EventHandler(this.FormPengembalian_Load);
            this.GroupPengembalian.ResumeLayout(false);
            this.GroupPengembalian.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonTutupPengembalian;
        private System.Windows.Forms.GroupBox GroupPengembalian;
        private System.Windows.Forms.Button ButtonKonfirmasi;
        private System.Windows.Forms.Button ButtonHitungDenda;
        private System.Windows.Forms.Button ButtonCekDenda;
        private System.Windows.Forms.TextBox TextDendaKembali;
        private System.Windows.Forms.TextBox TextLamaPinjamKembali;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextCariPengembalian;
        private System.Windows.Forms.ComboBox ComboPilihanPengembalian;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ButtonBatalPengembalian;
        private System.Windows.Forms.ComboBox ComboBoxKodePinjam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label KodeBukuPengembalian;
        private System.Windows.Forms.TextBox TextKodeBuku;
        private System.Windows.Forms.TextBox TextIDAnggota;
        private System.Windows.Forms.Button button1;
    }
}