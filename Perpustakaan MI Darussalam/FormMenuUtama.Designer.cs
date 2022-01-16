namespace Perpustakaan_MI_Darussalam
{
    partial class FormMenuUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuUtama));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataAnggotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peminjamanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengembalianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanDataAnggotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanPeminjamanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanPengembalianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axCrystalReport1 = new AxCrystal.AxCrystalReport();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axCrystalReport1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBukuToolStripMenuItem,
            this.dataAnggotaToolStripMenuItem,
            this.peminjamanToolStripMenuItem,
            this.pengembalianToolStripMenuItem,
            this.laporanToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1156, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataBukuToolStripMenuItem
            // 
            this.dataBukuToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataBukuToolStripMenuItem.Name = "dataBukuToolStripMenuItem";
            this.dataBukuToolStripMenuItem.Size = new System.Drawing.Size(128, 31);
            this.dataBukuToolStripMenuItem.Text = "Data Buku";
            this.dataBukuToolStripMenuItem.Click += new System.EventHandler(this.dataBukuToolStripMenuItem_Click);
            // 
            // dataAnggotaToolStripMenuItem
            // 
            this.dataAnggotaToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataAnggotaToolStripMenuItem.Name = "dataAnggotaToolStripMenuItem";
            this.dataAnggotaToolStripMenuItem.Size = new System.Drawing.Size(156, 31);
            this.dataAnggotaToolStripMenuItem.Text = "Data Anggota";
            this.dataAnggotaToolStripMenuItem.Click += new System.EventHandler(this.dataAnggotaToolStripMenuItem_Click);
            // 
            // peminjamanToolStripMenuItem
            // 
            this.peminjamanToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peminjamanToolStripMenuItem.Name = "peminjamanToolStripMenuItem";
            this.peminjamanToolStripMenuItem.Size = new System.Drawing.Size(143, 31);
            this.peminjamanToolStripMenuItem.Text = "Peminjaman";
            this.peminjamanToolStripMenuItem.Click += new System.EventHandler(this.peminjamanToolStripMenuItem_Click);
            // 
            // pengembalianToolStripMenuItem
            // 
            this.pengembalianToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengembalianToolStripMenuItem.Name = "pengembalianToolStripMenuItem";
            this.pengembalianToolStripMenuItem.Size = new System.Drawing.Size(159, 31);
            this.pengembalianToolStripMenuItem.Text = "Pengembalian";
            this.pengembalianToolStripMenuItem.Click += new System.EventHandler(this.pengembalianToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laporanToolStripMenuItem1,
            this.laporanDataAnggotaToolStripMenuItem,
            this.laporanPeminjamanToolStripMenuItem,
            this.laporanPengembalianToolStripMenuItem});
            this.laporanToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(105, 31);
            this.laporanToolStripMenuItem.Text = "Laporan";
            this.laporanToolStripMenuItem.Click += new System.EventHandler(this.laporanToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem1
            // 
            this.laporanToolStripMenuItem1.Name = "laporanToolStripMenuItem1";
            this.laporanToolStripMenuItem1.Size = new System.Drawing.Size(318, 32);
            this.laporanToolStripMenuItem1.Text = "Laporan Data Buku";
            this.laporanToolStripMenuItem1.Click += new System.EventHandler(this.laporanToolStripMenuItem1_Click);
            // 
            // laporanDataAnggotaToolStripMenuItem
            // 
            this.laporanDataAnggotaToolStripMenuItem.Name = "laporanDataAnggotaToolStripMenuItem";
            this.laporanDataAnggotaToolStripMenuItem.Size = new System.Drawing.Size(318, 32);
            this.laporanDataAnggotaToolStripMenuItem.Text = "Laporan Data Anggota";
            this.laporanDataAnggotaToolStripMenuItem.Click += new System.EventHandler(this.laporanDataAnggotaToolStripMenuItem_Click);
            // 
            // laporanPeminjamanToolStripMenuItem
            // 
            this.laporanPeminjamanToolStripMenuItem.Name = "laporanPeminjamanToolStripMenuItem";
            this.laporanPeminjamanToolStripMenuItem.Size = new System.Drawing.Size(318, 32);
            this.laporanPeminjamanToolStripMenuItem.Text = "Laporan Peminjaman";
            this.laporanPeminjamanToolStripMenuItem.Click += new System.EventHandler(this.laporanPeminjamanToolStripMenuItem_Click);
            // 
            // laporanPengembalianToolStripMenuItem
            // 
            this.laporanPengembalianToolStripMenuItem.Name = "laporanPengembalianToolStripMenuItem";
            this.laporanPengembalianToolStripMenuItem.Size = new System.Drawing.Size(318, 32);
            this.laporanPengembalianToolStripMenuItem.Text = "Laporan Pengembalian";
            this.laporanPengembalianToolStripMenuItem.Click += new System.EventHandler(this.laporanPengembalianToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(89, 31);
            this.loginToolStripMenuItem.Text = "Keluar";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // axCrystalReport1
            // 
            this.axCrystalReport1.Enabled = true;
            this.axCrystalReport1.Location = new System.Drawing.Point(803, 7);
            this.axCrystalReport1.Name = "axCrystalReport1";
            this.axCrystalReport1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCrystalReport1.OcxState")));
            this.axCrystalReport1.Size = new System.Drawing.Size(28, 28);
            this.axCrystalReport1.TabIndex = 1;
            // 
            // FormMenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 608);
            this.Controls.Add(this.axCrystalReport1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenuUtama";
            this.Text = "Menu Utama";
            this.Load += new System.EventHandler(this.FormMenuUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axCrystalReport1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataAnggotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peminjamanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengembalianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem laporanDataAnggotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanPeminjamanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanPengembalianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private AxCrystal.AxCrystalReport axCrystalReport1;
    }
}

