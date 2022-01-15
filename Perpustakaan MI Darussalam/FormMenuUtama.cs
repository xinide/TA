using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            new FormLogin().ShowDialog();
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
            FormLogin newform;
            newform = new FormLogin();
            newform.ShowDialog(this);
        }
    }
}
