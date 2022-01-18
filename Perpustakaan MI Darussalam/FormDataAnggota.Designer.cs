namespace Perpustakaan_MI_Darussalam
{
    partial class FormDataAnggota
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupCariAnggota = new System.Windows.Forms.GroupBox();
            this.ComboPilihanAnggota = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextCariAnggota = new System.Windows.Forms.TextBox();
            this.TextDataAnggota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupAnggota = new System.Windows.Forms.GroupBox();
            this.ComboStatusAnggota = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtonKoreksiAnggota = new System.Windows.Forms.Button();
            this.ButtonHapusAnggota = new System.Windows.Forms.Button();
            this.ButtonSimpanPeminjam = new System.Windows.Forms.Button();
            this.TextAlamatAnggota = new System.Windows.Forms.TextBox();
            this.ComboJenisKAnggota = new System.Windows.Forms.ComboBox();
            this.TextNamaAnggota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonBatalAnggota = new System.Windows.Forms.Button();
            this.ButtonTutupAnggota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GroupCariAnggota.SuspendLayout();
            this.GroupAnggota.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1145, 246);
            this.dataGridView1.TabIndex = 7;
            // 
            // GroupCariAnggota
            // 
            this.GroupCariAnggota.Controls.Add(this.ComboPilihanAnggota);
            this.GroupCariAnggota.Controls.Add(this.label5);
            this.GroupCariAnggota.Controls.Add(this.label6);
            this.GroupCariAnggota.Controls.Add(this.TextCariAnggota);
            this.GroupCariAnggota.Location = new System.Drawing.Point(753, 12);
            this.GroupCariAnggota.Name = "GroupCariAnggota";
            this.GroupCariAnggota.Size = new System.Drawing.Size(411, 152);
            this.GroupCariAnggota.TabIndex = 8;
            this.GroupCariAnggota.TabStop = false;
            this.GroupCariAnggota.Text = "Cari Data Anggota";
            // 
            // ComboPilihanAnggota
            // 
            this.ComboPilihanAnggota.FormattingEnabled = true;
            this.ComboPilihanAnggota.Items.AddRange(new object[] {
            "ID Anggota",
            "Nama Anggota",
            "Jenis Kelamin",
            "Alamat",
            "Status"});
            this.ComboPilihanAnggota.Location = new System.Drawing.Point(148, 45);
            this.ComboPilihanAnggota.Name = "ComboPilihanAnggota";
            this.ComboPilihanAnggota.Size = new System.Drawing.Size(257, 35);
            this.ComboPilihanAnggota.TabIndex = 11;
            this.ComboPilihanAnggota.SelectedIndexChanged += new System.EventHandler(this.ComboPilihanAnggota_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 45);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(79, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pilihan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cari";
            // 
            // TextCariAnggota
            // 
            this.TextCariAnggota.Location = new System.Drawing.Point(148, 86);
            this.TextCariAnggota.Name = "TextCariAnggota";
            this.TextCariAnggota.Size = new System.Drawing.Size(256, 35);
            this.TextCariAnggota.TabIndex = 10;
            this.TextCariAnggota.TextChanged += new System.EventHandler(this.TextCariAnggota_TextChanged);
            // 
            // TextDataAnggota
            // 
            this.TextDataAnggota.Location = new System.Drawing.Point(230, 47);
            this.TextDataAnggota.Name = "TextDataAnggota";
            this.TextDataAnggota.Size = new System.Drawing.Size(238, 35);
            this.TextDataAnggota.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Anggota";
            // 
            // GroupAnggota
            // 
            this.GroupAnggota.Controls.Add(this.ComboStatusAnggota);
            this.GroupAnggota.Controls.Add(this.label7);
            this.GroupAnggota.Controls.Add(this.ButtonKoreksiAnggota);
            this.GroupAnggota.Controls.Add(this.ButtonHapusAnggota);
            this.GroupAnggota.Controls.Add(this.ButtonSimpanPeminjam);
            this.GroupAnggota.Controls.Add(this.TextAlamatAnggota);
            this.GroupAnggota.Controls.Add(this.ComboJenisKAnggota);
            this.GroupAnggota.Controls.Add(this.TextNamaAnggota);
            this.GroupAnggota.Controls.Add(this.TextDataAnggota);
            this.GroupAnggota.Controls.Add(this.label4);
            this.GroupAnggota.Controls.Add(this.label3);
            this.GroupAnggota.Controls.Add(this.label2);
            this.GroupAnggota.Controls.Add(this.label1);
            this.GroupAnggota.Location = new System.Drawing.Point(12, 12);
            this.GroupAnggota.Name = "GroupAnggota";
            this.GroupAnggota.Size = new System.Drawing.Size(707, 319);
            this.GroupAnggota.TabIndex = 6;
            this.GroupAnggota.TabStop = false;
            this.GroupAnggota.Text = "Input Data Anggota";
            // 
            // ComboStatusAnggota
            // 
            this.ComboStatusAnggota.FormattingEnabled = true;
            this.ComboStatusAnggota.Items.AddRange(new object[] {
            "Siswa",
            "Guru"});
            this.ComboStatusAnggota.Location = new System.Drawing.Point(230, 211);
            this.ComboStatusAnggota.Name = "ComboStatusAnggota";
            this.ComboStatusAnggota.Size = new System.Drawing.Size(238, 35);
            this.ComboStatusAnggota.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 27);
            this.label7.TabIndex = 15;
            this.label7.Text = "Status";
            // 
            // ButtonKoreksiAnggota
            // 
            this.ButtonKoreksiAnggota.Location = new System.Drawing.Point(512, 262);
            this.ButtonKoreksiAnggota.Name = "ButtonKoreksiAnggota";
            this.ButtonKoreksiAnggota.Size = new System.Drawing.Size(96, 51);
            this.ButtonKoreksiAnggota.TabIndex = 14;
            this.ButtonKoreksiAnggota.Text = "Koreksi";
            this.ButtonKoreksiAnggota.UseVisualStyleBackColor = true;
            this.ButtonKoreksiAnggota.Click += new System.EventHandler(this.ButtonKoreksiAnggota_Click);
            // 
            // ButtonHapusAnggota
            // 
            this.ButtonHapusAnggota.Location = new System.Drawing.Point(372, 262);
            this.ButtonHapusAnggota.Name = "ButtonHapusAnggota";
            this.ButtonHapusAnggota.Size = new System.Drawing.Size(96, 51);
            this.ButtonHapusAnggota.TabIndex = 13;
            this.ButtonHapusAnggota.Text = "Hapus";
            this.ButtonHapusAnggota.UseVisualStyleBackColor = true;
            this.ButtonHapusAnggota.Click += new System.EventHandler(this.ButtonHapusAnggota_Click);
            // 
            // ButtonSimpanPeminjam
            // 
            this.ButtonSimpanPeminjam.Location = new System.Drawing.Point(230, 262);
            this.ButtonSimpanPeminjam.Name = "ButtonSimpanPeminjam";
            this.ButtonSimpanPeminjam.Size = new System.Drawing.Size(96, 51);
            this.ButtonSimpanPeminjam.TabIndex = 12;
            this.ButtonSimpanPeminjam.Text = "Simpan";
            this.ButtonSimpanPeminjam.UseVisualStyleBackColor = true;
            this.ButtonSimpanPeminjam.Click += new System.EventHandler(this.ButtonSimpanPeminjam_Click);
            // 
            // TextAlamatAnggota
            // 
            this.TextAlamatAnggota.Location = new System.Drawing.Point(230, 172);
            this.TextAlamatAnggota.Name = "TextAlamatAnggota";
            this.TextAlamatAnggota.Size = new System.Drawing.Size(458, 35);
            this.TextAlamatAnggota.TabIndex = 7;
            // 
            // ComboJenisKAnggota
            // 
            this.ComboJenisKAnggota.FormattingEnabled = true;
            this.ComboJenisKAnggota.Items.AddRange(new object[] {
            "Perempuan",
            "Laki-Laki"});
            this.ComboJenisKAnggota.Location = new System.Drawing.Point(230, 130);
            this.ComboJenisKAnggota.Name = "ComboJenisKAnggota";
            this.ComboJenisKAnggota.Size = new System.Drawing.Size(238, 35);
            this.ComboJenisKAnggota.TabIndex = 6;
            this.ComboJenisKAnggota.SelectedIndexChanged += new System.EventHandler(this.ComboJenisKAnggota_SelectedIndexChanged);
            // 
            // TextNamaAnggota
            // 
            this.TextNamaAnggota.Location = new System.Drawing.Point(230, 88);
            this.TextNamaAnggota.Name = "TextNamaAnggota";
            this.TextNamaAnggota.Size = new System.Drawing.Size(458, 35);
            this.TextNamaAnggota.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Anggota";
            // 
            // ButtonBatalAnggota
            // 
            this.ButtonBatalAnggota.Location = new System.Drawing.Point(861, 184);
            this.ButtonBatalAnggota.Name = "ButtonBatalAnggota";
            this.ButtonBatalAnggota.Size = new System.Drawing.Size(96, 51);
            this.ButtonBatalAnggota.TabIndex = 17;
            this.ButtonBatalAnggota.Text = "Batal";
            this.ButtonBatalAnggota.UseVisualStyleBackColor = true;
            this.ButtonBatalAnggota.Click += new System.EventHandler(this.ButtonBatalAnggota_Click);
            // 
            // ButtonTutupAnggota
            // 
            this.ButtonTutupAnggota.Location = new System.Drawing.Point(984, 184);
            this.ButtonTutupAnggota.Name = "ButtonTutupAnggota";
            this.ButtonTutupAnggota.Size = new System.Drawing.Size(96, 51);
            this.ButtonTutupAnggota.TabIndex = 18;
            this.ButtonTutupAnggota.Text = "Tutup";
            this.ButtonTutupAnggota.UseVisualStyleBackColor = true;
            this.ButtonTutupAnggota.Click += new System.EventHandler(this.ButtonTutupAnggota_Click);
            // 
            // FormDataAnggota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 608);
            this.Controls.Add(this.ButtonTutupAnggota);
            this.Controls.Add(this.ButtonBatalAnggota);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GroupCariAnggota);
            this.Controls.Add(this.GroupAnggota);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDataAnggota";
            this.Text = "Data Anggota";
            this.Load += new System.EventHandler(this.FormDataAnggota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GroupCariAnggota.ResumeLayout(false);
            this.GroupCariAnggota.PerformLayout();
            this.GroupAnggota.ResumeLayout(false);
            this.GroupAnggota.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox GroupCariAnggota;
        private System.Windows.Forms.ComboBox ComboPilihanAnggota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextCariAnggota;
        private System.Windows.Forms.TextBox TextDataAnggota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GroupAnggota;
        private System.Windows.Forms.ComboBox ComboStatusAnggota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ButtonKoreksiAnggota;
        private System.Windows.Forms.Button ButtonHapusAnggota;
        private System.Windows.Forms.Button ButtonSimpanPeminjam;
        private System.Windows.Forms.TextBox TextAlamatAnggota;
        private System.Windows.Forms.ComboBox ComboJenisKAnggota;
        private System.Windows.Forms.TextBox TextNamaAnggota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonBatalAnggota;
        private System.Windows.Forms.Button ButtonTutupAnggota;
    }
}