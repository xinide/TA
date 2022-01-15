using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Perpustakaan_MI_Darussalam
{
    public partial class FormDataAnggota : Form
    {
        public FormDataAnggota()
        {
            InitializeComponent();
        }

        void ambildata()
        {
            Perpustakaan.tblAnggota.Clear();
            Perpustakaan.daAnggota.Fill(Perpustakaan.tblAnggota);
        }

        void bersih()
        {
            TextDataAnggota.Clear();
            TextNamaAnggota.Clear();
            ComboJenisKAnggota.SelectedIndex = -1;
            TextAlamatAnggota.Clear();
            ComboStatusAnggota.SelectedIndex = -1;
        }

        private void FormDataAnggota_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            Perpustakaan.con = Perpustakaan.konek_db();

            Perpustakaan.daAnggota = new OleDbDataAdapter("SELECT * FROM Anggota", Perpustakaan.con);
            ambildata();

            dataGridView1.DataSource = Perpustakaan.tblAnggota;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Columns[0].HeaderText = "ID Anggota";
            dataGridView1.Columns[0].Width = 120;

            dataGridView1.Columns[1].HeaderText = "Nama Anggota";
            dataGridView1.Columns[1].Width = 150;

            dataGridView1.Columns[2].HeaderText = "Jenis Kelamin";
            dataGridView1.Columns[2].Width = 120;

            dataGridView1.Columns[3].HeaderText = "Alamat";
            dataGridView1.Columns[3].Width = 120;

            dataGridView1.Columns[4].HeaderText = "Status";
            dataGridView1.Columns[4].Width = 120;
        }

        private void ButtonSimpanPeminjam_Click(object sender, EventArgs e)
        {
            Perpustakaan.cmd = new OleDbCommand
                ("select * From Anggota where ID_Anggota='" + TextDataAnggota.Text + "'", Perpustakaan.con);
            Perpustakaan.dtr = Perpustakaan.cmd.ExecuteReader();

            if (Perpustakaan.dtr.HasRows)
            {
                MessageBox.Show("ID Anggota tersebut sudah ada", "pesan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                TextDataAnggota.Clear();
                TextDataAnggota.Focus();
            }
            else if (TextDataAnggota.Text.Trim() == "")
            {
                MessageBox.Show("ID Anggota masih kosong", "pesan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                TextDataAnggota.Clear();
                TextDataAnggota.Focus();
            }
            else
            {
                Perpustakaan.cmd = new OleDbCommand
                    ("INSERT INTO Anggota (ID_Anggota, Nama_Anggota, Jenis_Kelamin, Alamat, Status )" +
                    "VALUES ('" + TextDataAnggota.Text + "'," +
                    "'" + TextNamaAnggota.Text + "'," +
                    "'" + ComboJenisKAnggota.Text + "'," +
                    "'" + TextAlamatAnggota.Text + "'," +
                    "'" + ComboStatusAnggota.Text + "')", Perpustakaan.con);
                Perpustakaan.cmd.ExecuteNonQuery();
                ambildata();

                MessageBox.Show("Data Sudah Tersimpan.", "pesan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                bersih();
            }
        }

        private void ButtonHapusAnggota_Click(object sender, EventArgs e)
        {
            int brs;
            string kode;

            brs = dataGridView1.CurrentRow.Index;
            kode = dataGridView1[0, brs].Value.ToString();

            if (MessageBox.Show ("Apakah ID Anggota =" + kode + "\n" +
                "ingin dihapus?", "pesan" , MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Perpustakaan.cmd = new OleDbCommand
                    ("DELETE FROM Anggota where ID_Anggota='" + kode + "'", Perpustakaan.con);
                Perpustakaan.cmd.ExecuteNonQuery();
                ambildata();

                MessageBox.Show("Data Sudah Terhapus.", "pesan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void ComboPilihanAnggota_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextCariAnggota.Focus();
        }

        private void TextCariAnggota_TextChanged(object sender, EventArgs e)
        {
            if (ComboPilihanAnggota.SelectIndex == 0)
            {
                Perpustakaan.daBuku = new OleDbDataAdapter("SELECT * FROM Anggota where ID_Anggota")
            }
        }
    }
}
