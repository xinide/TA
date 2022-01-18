namespace Perpustakaan_MI_Darussalam
{
    partial class FormPengarang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextIDPengarang = new System.Windows.Forms.TextBox();
            this.TextNamaPengarang = new System.Windows.Forms.TextBox();
            this.ButtonSimpan = new System.Windows.Forms.Button();
            this.ButtonHapus = new System.Windows.Forms.Button();
            this.ButtonKoreksiPengarang = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextPilihanPengarang = new System.Windows.Forms.TextBox();
            this.TextCariPengarang = new System.Windows.Forms.TextBox();
            this.ButtonBatalPengarang = new System.Windows.Forms.Button();
            this.ButtonTutupPengarang = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonKoreksiPengarang);
            this.groupBox1.Controls.Add(this.ButtonHapus);
            this.groupBox1.Controls.Add(this.ButtonSimpan);
            this.groupBox1.Controls.Add(this.TextNamaPengarang);
            this.groupBox1.Controls.Add(this.TextIDPengarang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data Pengarang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Pengarang";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Pengarang";
            // 
            // TextIDPengarang
            // 
            this.TextIDPengarang.Location = new System.Drawing.Point(227, 45);
            this.TextIDPengarang.Name = "TextIDPengarang";
            this.TextIDPengarang.Size = new System.Drawing.Size(223, 35);
            this.TextIDPengarang.TabIndex = 2;
            // 
            // TextNamaPengarang
            // 
            this.TextNamaPengarang.Location = new System.Drawing.Point(227, 92);
            this.TextNamaPengarang.Name = "TextNamaPengarang";
            this.TextNamaPengarang.Size = new System.Drawing.Size(480, 35);
            this.TextNamaPengarang.TabIndex = 3;
            this.TextNamaPengarang.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ButtonSimpan
            // 
            this.ButtonSimpan.Location = new System.Drawing.Point(227, 153);
            this.ButtonSimpan.Name = "ButtonSimpan";
            this.ButtonSimpan.Size = new System.Drawing.Size(100, 50);
            this.ButtonSimpan.TabIndex = 4;
            this.ButtonSimpan.Text = "Simpan";
            this.ButtonSimpan.UseVisualStyleBackColor = true;
            // 
            // ButtonHapus
            // 
            this.ButtonHapus.Location = new System.Drawing.Point(350, 153);
            this.ButtonHapus.Name = "ButtonHapus";
            this.ButtonHapus.Size = new System.Drawing.Size(100, 50);
            this.ButtonHapus.TabIndex = 5;
            this.ButtonHapus.Text = "Hapus";
            this.ButtonHapus.UseVisualStyleBackColor = true;
            // 
            // ButtonKoreksiPengarang
            // 
            this.ButtonKoreksiPengarang.Location = new System.Drawing.Point(478, 153);
            this.ButtonKoreksiPengarang.Name = "ButtonKoreksiPengarang";
            this.ButtonKoreksiPengarang.Size = new System.Drawing.Size(100, 50);
            this.ButtonKoreksiPengarang.TabIndex = 6;
            this.ButtonKoreksiPengarang.Text = "Koreksi";
            this.ButtonKoreksiPengarang.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextCariPengarang);
            this.groupBox2.Controls.Add(this.TextPilihanPengarang);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(774, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cari Data Pengarang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pilihan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cari";
            // 
            // TextPilihanPengarang
            // 
            this.TextPilihanPengarang.Location = new System.Drawing.Point(130, 32);
            this.TextPilihanPengarang.Name = "TextPilihanPengarang";
            this.TextPilihanPengarang.Size = new System.Drawing.Size(292, 35);
            this.TextPilihanPengarang.TabIndex = 2;
            // 
            // TextCariPengarang
            // 
            this.TextCariPengarang.Location = new System.Drawing.Point(130, 86);
            this.TextCariPengarang.Name = "TextCariPengarang";
            this.TextCariPengarang.Size = new System.Drawing.Size(292, 35);
            this.TextCariPengarang.TabIndex = 3;
            // 
            // ButtonBatalPengarang
            // 
            this.ButtonBatalPengarang.Location = new System.Drawing.Point(861, 177);
            this.ButtonBatalPengarang.Name = "ButtonBatalPengarang";
            this.ButtonBatalPengarang.Size = new System.Drawing.Size(100, 50);
            this.ButtonBatalPengarang.TabIndex = 7;
            this.ButtonBatalPengarang.Text = "Batal";
            this.ButtonBatalPengarang.UseVisualStyleBackColor = true;
            // 
            // ButtonTutupPengarang
            // 
            this.ButtonTutupPengarang.Location = new System.Drawing.Point(1005, 177);
            this.ButtonTutupPengarang.Name = "ButtonTutupPengarang";
            this.ButtonTutupPengarang.Size = new System.Drawing.Size(100, 50);
            this.ButtonTutupPengarang.TabIndex = 8;
            this.ButtonTutupPengarang.Text = "Tutup";
            this.ButtonTutupPengarang.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1203, 341);
            this.dataGridView1.TabIndex = 9;
            // 
            // FormPengarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 608);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButtonTutupPengarang);
            this.Controls.Add(this.ButtonBatalPengarang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPengarang";
            this.Text = "Form Pengarang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextNamaPengarang;
        private System.Windows.Forms.TextBox TextIDPengarang;
        private System.Windows.Forms.Button ButtonKoreksiPengarang;
        private System.Windows.Forms.Button ButtonHapus;
        private System.Windows.Forms.Button ButtonSimpan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextCariPengarang;
        private System.Windows.Forms.TextBox TextPilihanPengarang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonBatalPengarang;
        private System.Windows.Forms.Button ButtonTutupPengarang;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}