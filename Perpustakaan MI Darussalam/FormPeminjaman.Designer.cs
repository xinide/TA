namespace Perpustakaan_MI_Darussalam
{
    partial class FormPeminjaman
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
            this.ButtonTutupPeminjaman = new System.Windows.Forms.Button();
            this.GroupInputPeminjaman = new System.Windows.Forms.GroupBox();
            this.ButtonKoreksiPeminjaman = new System.Windows.Forms.Button();
            this.ButtonHapusPeminjaman = new System.Windows.Forms.Button();
            this.ButtonSimpanPeminjaman = new System.Windows.Forms.Button();
            this.ButtonGK = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TextKodePinjam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupCariPeminjaman = new System.Windows.Forms.GroupBox();
            this.TextCariPeminjaman = new System.Windows.Forms.TextBox();
            this.ComboPilihanPeminjaman = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.ComboIDAnggota = new System.Windows.Forms.ComboBox();
            this.ComboKodeBuku = new System.Windows.Forms.ComboBox();
            this.GroupInputPeminjaman.SuspendLayout();
            this.GroupCariPeminjaman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonTutupPeminjaman
            // 
            this.ButtonTutupPeminjaman.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTutupPeminjaman.Location = new System.Drawing.Point(1065, 253);
            this.ButtonTutupPeminjaman.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonTutupPeminjaman.Name = "ButtonTutupPeminjaman";
            this.ButtonTutupPeminjaman.Size = new System.Drawing.Size(126, 67);
            this.ButtonTutupPeminjaman.TabIndex = 10;
            this.ButtonTutupPeminjaman.Text = "Tutup";
            this.ButtonTutupPeminjaman.UseVisualStyleBackColor = true;
            this.ButtonTutupPeminjaman.Click += new System.EventHandler(this.ButtonTutupPeminjaman_Click);
            // 
            // GroupInputPeminjaman
            // 
            this.GroupInputPeminjaman.Controls.Add(this.ComboKodeBuku);
            this.GroupInputPeminjaman.Controls.Add(this.ComboIDAnggota);
            this.GroupInputPeminjaman.Controls.Add(this.ButtonKoreksiPeminjaman);
            this.GroupInputPeminjaman.Controls.Add(this.ButtonHapusPeminjaman);
            this.GroupInputPeminjaman.Controls.Add(this.ButtonSimpanPeminjaman);
            this.GroupInputPeminjaman.Controls.Add(this.ButtonGK);
            this.GroupInputPeminjaman.Controls.Add(this.dateTimePicker2);
            this.GroupInputPeminjaman.Controls.Add(this.dateTimePicker1);
            this.GroupInputPeminjaman.Controls.Add(this.TextKodePinjam);
            this.GroupInputPeminjaman.Controls.Add(this.label5);
            this.GroupInputPeminjaman.Controls.Add(this.label4);
            this.GroupInputPeminjaman.Controls.Add(this.label3);
            this.GroupInputPeminjaman.Controls.Add(this.label2);
            this.GroupInputPeminjaman.Controls.Add(this.label1);
            this.GroupInputPeminjaman.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupInputPeminjaman.Location = new System.Drawing.Point(13, 13);
            this.GroupInputPeminjaman.Margin = new System.Windows.Forms.Padding(4);
            this.GroupInputPeminjaman.Name = "GroupInputPeminjaman";
            this.GroupInputPeminjaman.Padding = new System.Windows.Forms.Padding(4);
            this.GroupInputPeminjaman.Size = new System.Drawing.Size(751, 369);
            this.GroupInputPeminjaman.TabIndex = 8;
            this.GroupInputPeminjaman.TabStop = false;
            this.GroupInputPeminjaman.Text = "Input Data Peminjaman";
            // 
            // ButtonKoreksiPeminjaman
            // 
            this.ButtonKoreksiPeminjaman.Location = new System.Drawing.Point(549, 297);
            this.ButtonKoreksiPeminjaman.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonKoreksiPeminjaman.Name = "ButtonKoreksiPeminjaman";
            this.ButtonKoreksiPeminjaman.Size = new System.Drawing.Size(121, 57);
            this.ButtonKoreksiPeminjaman.TabIndex = 13;
            this.ButtonKoreksiPeminjaman.Text = "Koreksi";
            this.ButtonKoreksiPeminjaman.UseVisualStyleBackColor = true;
            this.ButtonKoreksiPeminjaman.Click += new System.EventHandler(this.ButtonKoreksiPeminjaman_Click);
            // 
            // ButtonHapusPeminjaman
            // 
            this.ButtonHapusPeminjaman.Location = new System.Drawing.Point(420, 297);
            this.ButtonHapusPeminjaman.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonHapusPeminjaman.Name = "ButtonHapusPeminjaman";
            this.ButtonHapusPeminjaman.Size = new System.Drawing.Size(121, 57);
            this.ButtonHapusPeminjaman.TabIndex = 12;
            this.ButtonHapusPeminjaman.Text = "Hapus";
            this.ButtonHapusPeminjaman.UseVisualStyleBackColor = true;
            this.ButtonHapusPeminjaman.Click += new System.EventHandler(this.ButtonHapusPeminjaman_Click);
            // 
            // ButtonSimpanPeminjaman
            // 
            this.ButtonSimpanPeminjaman.Location = new System.Drawing.Point(291, 297);
            this.ButtonSimpanPeminjaman.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSimpanPeminjaman.Name = "ButtonSimpanPeminjaman";
            this.ButtonSimpanPeminjaman.Size = new System.Drawing.Size(121, 57);
            this.ButtonSimpanPeminjaman.TabIndex = 11;
            this.ButtonSimpanPeminjaman.Text = "Simpan";
            this.ButtonSimpanPeminjaman.UseVisualStyleBackColor = true;
            this.ButtonSimpanPeminjaman.Click += new System.EventHandler(this.ButtonSimpanPeminjaman_Click);
            // 
            // ButtonGK
            // 
            this.ButtonGK.Location = new System.Drawing.Point(553, 108);
            this.ButtonGK.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonGK.Name = "ButtonGK";
            this.ButtonGK.Size = new System.Drawing.Size(177, 58);
            this.ButtonGK.TabIndex = 10;
            this.ButtonGK.Text = "Generate Kode";
            this.ButtonGK.UseVisualStyleBackColor = true;
            this.ButtonGK.Click += new System.EventHandler(this.ButtonGK_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(250, 254);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(217, 35);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(250, 211);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 35);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // TextKodePinjam
            // 
            this.TextKodePinjam.Location = new System.Drawing.Point(250, 78);
            this.TextKodePinjam.Margin = new System.Windows.Forms.Padding(4);
            this.TextKodePinjam.Name = "TextKodePinjam";
            this.TextKodePinjam.Size = new System.Drawing.Size(252, 35);
            this.TextKodePinjam.TabIndex = 5;
            this.TextKodePinjam.TextChanged += new System.EventHandler(this.TextKodePinjam_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 260);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tanggal Batas Pinjam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Pinjam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kode Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Anggota";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Pinjam";
            // 
            // GroupCariPeminjaman
            // 
            this.GroupCariPeminjaman.Controls.Add(this.TextCariPeminjaman);
            this.GroupCariPeminjaman.Controls.Add(this.ComboPilihanPeminjaman);
            this.GroupCariPeminjaman.Controls.Add(this.label7);
            this.GroupCariPeminjaman.Controls.Add(this.label6);
            this.GroupCariPeminjaman.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupCariPeminjaman.Location = new System.Drawing.Point(798, 13);
            this.GroupCariPeminjaman.Margin = new System.Windows.Forms.Padding(4);
            this.GroupCariPeminjaman.Name = "GroupCariPeminjaman";
            this.GroupCariPeminjaman.Padding = new System.Windows.Forms.Padding(4);
            this.GroupCariPeminjaman.Size = new System.Drawing.Size(443, 221);
            this.GroupCariPeminjaman.TabIndex = 9;
            this.GroupCariPeminjaman.TabStop = false;
            this.GroupCariPeminjaman.Text = "Cari Data Peminjaman";
            this.GroupCariPeminjaman.Enter += new System.EventHandler(this.GroupCariPeminjaman_Enter);
            // 
            // TextCariPeminjaman
            // 
            this.TextCariPeminjaman.Location = new System.Drawing.Point(178, 145);
            this.TextCariPeminjaman.Margin = new System.Windows.Forms.Padding(4);
            this.TextCariPeminjaman.Name = "TextCariPeminjaman";
            this.TextCariPeminjaman.Size = new System.Drawing.Size(233, 35);
            this.TextCariPeminjaman.TabIndex = 3;
            this.TextCariPeminjaman.TextChanged += new System.EventHandler(this.TextCariPeminjaman_TextChanged);
            // 
            // ComboPilihanPeminjaman
            // 
            this.ComboPilihanPeminjaman.FormattingEnabled = true;
            this.ComboPilihanPeminjaman.Items.AddRange(new object[] {
            "Kode Pinjam",
            "ID Anggota",
            "Kode Buku",
            "Tanggal Pinjam",
            "Tanggal Batas Pinjam"});
            this.ComboPilihanPeminjaman.Location = new System.Drawing.Point(178, 78);
            this.ComboPilihanPeminjaman.Margin = new System.Windows.Forms.Padding(4);
            this.ComboPilihanPeminjaman.Name = "ComboPilihanPeminjaman";
            this.ComboPilihanPeminjaman.Size = new System.Drawing.Size(233, 35);
            this.ComboPilihanPeminjaman.TabIndex = 2;
            this.ComboPilihanPeminjaman.SelectedIndexChanged += new System.EventHandler(this.ComboPilihanPeminjaman_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 27);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cari";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pilihan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 425);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1178, 288);
            this.dataGridView1.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(885, 253);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 67);
            this.button3.TabIndex = 12;
            this.button3.Text = "Batal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ComboIDAnggota
            // 
            this.ComboIDAnggota.FormattingEnabled = true;
            this.ComboIDAnggota.Location = new System.Drawing.Point(250, 124);
            this.ComboIDAnggota.Name = "ComboIDAnggota";
            this.ComboIDAnggota.Size = new System.Drawing.Size(252, 35);
            this.ComboIDAnggota.TabIndex = 14;
            // 
            // ComboKodeBuku
            // 
            this.ComboKodeBuku.FormattingEnabled = true;
            this.ComboKodeBuku.Location = new System.Drawing.Point(250, 165);
            this.ComboKodeBuku.Name = "ComboKodeBuku";
            this.ComboKodeBuku.Size = new System.Drawing.Size(252, 35);
            this.ComboKodeBuku.TabIndex = 15;
            // 
            // FormPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 726);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ButtonTutupPeminjaman);
            this.Controls.Add(this.GroupInputPeminjaman);
            this.Controls.Add(this.GroupCariPeminjaman);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPeminjaman";
            this.Text = "Peminjaman";
            this.Load += new System.EventHandler(this.FormPeminjaman_Load);
            this.GroupInputPeminjaman.ResumeLayout(false);
            this.GroupInputPeminjaman.PerformLayout();
            this.GroupCariPeminjaman.ResumeLayout(false);
            this.GroupCariPeminjaman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonTutupPeminjaman;
        private System.Windows.Forms.GroupBox GroupInputPeminjaman;
        private System.Windows.Forms.Button ButtonKoreksiPeminjaman;
        private System.Windows.Forms.Button ButtonHapusPeminjaman;
        private System.Windows.Forms.Button ButtonSimpanPeminjaman;
        private System.Windows.Forms.Button ButtonGK;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TextKodePinjam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GroupCariPeminjaman;
        private System.Windows.Forms.TextBox TextCariPeminjaman;
        private System.Windows.Forms.ComboBox ComboPilihanPeminjaman;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox ComboKodeBuku;
        private System.Windows.Forms.ComboBox ComboIDAnggota;
    }
}