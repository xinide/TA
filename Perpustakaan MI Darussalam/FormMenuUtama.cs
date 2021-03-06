using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Perpustakaan_MI_Darussalam
{
    public partial class FormMenuUtama : Form
    {
        public FormMenuUtama()
        {
            InitializeComponent();
        }

        private void FormMenuUtama_Load(object sender, EventArgs e)
        {
            this.Show();
            // new FormLogin().ShowDialog();

            using(FormLogin formLogin = new FormLogin())
            {
                var result = formLogin.ShowDialog();
                Debug.WriteLine(result);
                if(result != DialogResult.OK)
                {
                this.Close();
                }
            }
        }

        private void dataBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormDataBuku().ShowDialog();
        }

        private void dataAnggotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormDataAnggota().ShowDialog();
        }

        private void peminjamanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormPeminjaman().ShowDialog();
        }

        private void pengembalianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormPengembalian().ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void laporanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axCrystalReport1.ReportFileName = "laporan_buku.rpt";
            axCrystalReport1.DiscardSavedData = true;
            axCrystalReport1.WindowLeft = 0;
            axCrystalReport1.WindowTop = 0;
            axCrystalReport1.WindowWidth = 1000;
            axCrystalReport1.WindowHeight = 700;
            axCrystalReport1.Action = 1;
        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void laporanDataAnggotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axCrystalReport1.ReportFileName = "laporan_anggota.rpt";
            axCrystalReport1.DiscardSavedData = true;
            axCrystalReport1.WindowLeft = 0;
            axCrystalReport1.WindowTop = 0;
            axCrystalReport1.WindowWidth = 1000;
            axCrystalReport1.WindowHeight = 700;
            axCrystalReport1.Action = 1;
        }

        private void laporanPeminjamanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axCrystalReport1.ReportFileName = "laporan_peminjaman.rpt";
            axCrystalReport1.DiscardSavedData = true;
            axCrystalReport1.WindowLeft = 0;
            axCrystalReport1.WindowTop = 0;
            axCrystalReport1.WindowWidth = 1000;
            axCrystalReport1.WindowHeight = 700;
            axCrystalReport1.Action = 1;
        }

        private void laporanPengembalianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axCrystalReport1.ReportFileName = "laporan_pengembalian.rpt";
            axCrystalReport1.DiscardSavedData = true;
            axCrystalReport1.WindowLeft = 0;
            axCrystalReport1.WindowTop = 0;
            axCrystalReport1.WindowWidth = 1000;
            axCrystalReport1.WindowHeight = 700;
            axCrystalReport1.Action = 1;
        }

        private void axCrystalReport1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripDataPengarang_Click(object sender, EventArgs e)
        {
            new FormPengarang().ShowDialog();
        }

        private void DataPenerbittoolStrip_Click(object sender, EventArgs e)
        {
            new FormPenerbit().ShowDialog(); 
        }
    }
}
