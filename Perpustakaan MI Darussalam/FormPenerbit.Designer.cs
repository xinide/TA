namespace Perpustakaan_MI_Darussalam
{
    partial class FormPenerbit
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
            this.ButtonKoreksiPenerbit = new System.Windows.Forms.Button();
            this.ButtonHapusPenerbit = new System.Windows.Forms.Button();
            this.ButtonSimpanPenerbit = new System.Windows.Forms.Button();
            this.TextNamaPenerbit = new System.Windows.Forms.TextBox();
            this.TextIDPenerbit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextCariPenerbit = new System.Windows.Forms.TextBox();
            this.ComboPilihanPenerbit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonKoreksiPenerbit);
            this.groupBox1.Controls.Add(this.ButtonHapusPenerbit);
            this.groupBox1.Controls.Add(this.ButtonSimpanPenerbit);
            this.groupBox1.Controls.Add(this.TextNamaPenerbit);
            this.groupBox1.Controls.Add(this.TextIDPenerbit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 240);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data Penerbit";
            // 
            // ButtonKoreksiPenerbit
            // 
            this.ButtonKoreksiPenerbit.Location = new System.Drawing.Point(471, 159);
            this.ButtonKoreksiPenerbit.Name = "ButtonKoreksiPenerbit";
            this.ButtonKoreksiPenerbit.Size = new System.Drawing.Size(100, 52);
            this.ButtonKoreksiPenerbit.TabIndex = 10;
            this.ButtonKoreksiPenerbit.Text = "Koreksi";
            this.ButtonKoreksiPenerbit.UseVisualStyleBackColor = true;
            this.ButtonKoreksiPenerbit.Click += new System.EventHandler(this.ButtonKoreksiPenerbit_Click);
            // 
            // ButtonHapusPenerbit
            // 
            this.ButtonHapusPenerbit.Location = new System.Drawing.Point(344, 159);
            this.ButtonHapusPenerbit.Name = "ButtonHapusPenerbit";
            this.ButtonHapusPenerbit.Size = new System.Drawing.Size(100, 52);
            this.ButtonHapusPenerbit.TabIndex = 9;
            this.ButtonHapusPenerbit.Text = "Hapus";
            this.ButtonHapusPenerbit.UseVisualStyleBackColor = true;
            this.ButtonHapusPenerbit.Click += new System.EventHandler(this.ButtonHapusPenerbit_Click);
            // 
            // ButtonSimpanPenerbit
            // 
            this.ButtonSimpanPenerbit.Location = new System.Drawing.Point(222, 159);
            this.ButtonSimpanPenerbit.Name = "ButtonSimpanPenerbit";
            this.ButtonSimpanPenerbit.Size = new System.Drawing.Size(100, 52);
            this.ButtonSimpanPenerbit.TabIndex = 8;
            this.ButtonSimpanPenerbit.Text = "Simpan";
            this.ButtonSimpanPenerbit.UseVisualStyleBackColor = true;
            this.ButtonSimpanPenerbit.Click += new System.EventHandler(this.ButtonSimpanPenerbit_Click);
            // 
            // TextNamaPenerbit
            // 
            this.TextNamaPenerbit.Location = new System.Drawing.Point(222, 99);
            this.TextNamaPenerbit.Name = "TextNamaPenerbit";
            this.TextNamaPenerbit.Size = new System.Drawing.Size(461, 35);
            this.TextNamaPenerbit.TabIndex = 5;
            // 
            // TextIDPenerbit
            // 
            this.TextIDPenerbit.Location = new System.Drawing.Point(222, 42);
            this.TextIDPenerbit.Name = "TextIDPenerbit";
            this.TextIDPenerbit.Size = new System.Drawing.Size(248, 35);
            this.TextIDPenerbit.TabIndex = 4;
            this.TextIDPenerbit.TextChanged += new System.EventHandler(this.TextIDPenerbit_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Penerbit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Penerbit";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextCariPenerbit);
            this.groupBox2.Controls.Add(this.ComboPilihanPenerbit);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(746, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 158);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cari Data Penerbit";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TextCariPenerbit
            // 
            this.TextCariPenerbit.Location = new System.Drawing.Point(128, 94);
            this.TextCariPenerbit.Name = "TextCariPenerbit";
            this.TextCariPenerbit.Size = new System.Drawing.Size(275, 35);
            this.TextCariPenerbit.TabIndex = 3;
            this.TextCariPenerbit.TextChanged += new System.EventHandler(this.TextCariPenerbit_TextChanged);
            // 
            // ComboPilihanPenerbit
            // 
            this.ComboPilihanPenerbit.FormattingEnabled = true;
            this.ComboPilihanPenerbit.Items.AddRange(new object[] {
            "Kode Penerbit",
            "Nama Penerbit"});
            this.ComboPilihanPenerbit.Location = new System.Drawing.Point(128, 37);
            this.ComboPilihanPenerbit.Name = "ComboPilihanPenerbit";
            this.ComboPilihanPenerbit.Size = new System.Drawing.Size(275, 35);
            this.ComboPilihanPenerbit.TabIndex = 2;
            this.ComboPilihanPenerbit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cari";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pillihan";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(841, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 52);
            this.button3.TabIndex = 11;
            this.button3.Text = "Batal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(984, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 52);
            this.button4.TabIndex = 12;
            this.button4.Text = "Tutup";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1121, 260);
            this.dataGridView1.TabIndex = 13;
            // 
            // FormPenerbit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 608);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPenerbit";
            this.Text = "Form Penerbit";
            this.Load += new System.EventHandler(this.FormPenerbit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonKoreksiPenerbit;
        private System.Windows.Forms.Button ButtonHapusPenerbit;
        private System.Windows.Forms.Button ButtonSimpanPenerbit;
        private System.Windows.Forms.TextBox TextNamaPenerbit;
        private System.Windows.Forms.TextBox TextIDPenerbit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboPilihanPenerbit;
        private System.Windows.Forms.TextBox TextCariPenerbit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}