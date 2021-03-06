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
    public partial class FormPeminjaman : Form
    {
        public FormPeminjaman()
        {
            InitializeComponent();
        }

        void ambildata()
        {
            Perpustakaan.tblPeminjaman.Clear();
            Perpustakaan.daPeminjaman.Fill(Perpustakaan.tblPeminjaman);
        }
        void bersih()
        {
            TextKodePinjam.Clear();
            ComboIDAnggota.Text = "";
            ComboKodeBuku.Text = "";
        }


        private void FormPeminjaman_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            Perpustakaan.con = Perpustakaan.konek_db();

            Perpustakaan.daPeminjaman = new OleDbDataAdapter("SELECT * From Peminjaman", Perpustakaan.con);
            ambildata();

            dataGridView1.DataSource = Perpustakaan.tblPeminjaman;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Columns[0].HeaderText = "Kode Pinjam";
            dataGridView1.Columns[0].Width = 120;

            dataGridView1.Columns[1].HeaderText = "ID Anggota";
            dataGridView1.Columns[1].Width = 130;

            dataGridView1.Columns[2].HeaderText = "Nama Anggota";
            dataGridView1.Columns[2].Width = 150;

            dataGridView1.Columns[3].HeaderText = "Kode Buku";
            dataGridView1.Columns[3].Width = 140;

            dataGridView1.Columns[4].HeaderText = "Judul Buku";
            dataGridView1.Columns[4].Width = 150;

            dataGridView1.Columns[5].HeaderText = "Status";
            dataGridView1.Columns[5].Width = 120;

            dataGridView1.Columns[6].HeaderText = "Tanggal Pinjam";
            dataGridView1.Columns[6].Width = 150;

            dataGridView1.Columns[6].HeaderText = "Tanggal Batas Pinjam";
            dataGridView1.Columns[6].Width = 150;

            ComboIDAnggota.Items.Clear();
            Perpustakaan.cmd = new OleDbCommand
            ("select * from Anggota", Perpustakaan.con);
            Perpustakaan.dtr = Perpustakaan.cmd.ExecuteReader();
            while (Perpustakaan.dtr.Read())
            {
                ComboIDAnggota.Items.Add(Perpustakaan.dtr["ID_Anggota"].ToString());
            }

            ComboKodeBuku.Items.Clear();
            Perpustakaan.cmd = new OleDbCommand
            ("select * from Buku", Perpustakaan.con);
            Perpustakaan.dtr = Perpustakaan.cmd.ExecuteReader();
            while (Perpustakaan.dtr.Read())
            {
                ComboKodeBuku.Items.Add(Perpustakaan.dtr["Kode_Buku"].ToString());
            }
        }

        private void ButtonGK_Click(object sender, EventArgs e)
        {
            Guid myuuid = Guid.NewGuid();

            string uuid = myuuid.ToString();

            TextKodePinjam.Text = "PEM" + DateTime.UtcNow.ToString("ddMM") + uuid;
        }

        private void ButtonSimpanPeminjaman_Click(object sender, EventArgs e)
        {
            Perpustakaan.cmd = new OleDbCommand
                ("Select * From Peminjaman where Kode_Pinjam='" + TextKodePinjam.Text + "'", Perpustakaan.con);
            Perpustakaan.dtr = Perpustakaan.cmd.ExecuteReader();

            if (Perpustakaan.dtr.HasRows)
            {
                MessageBox.Show("ID tersebut sudah ada", "pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bersih();
                TextKodePinjam.Focus();
            }
            else if (TextKodePinjam.Text.Trim() == "")
            {
                MessageBox.Show("Kode Pinjam Masih Kosong", "pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bersih();
                TextKodePinjam.Focus();
            }
            else if (ComboIDAnggota.Text.Trim() == "")
            {
                MessageBox.Show("ID Anggota masih kosong", "pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bersih();
                TextKodePinjam.Focus();
            }
            else if (TextKodePinjam.Text.Trim() == "")
            {
                MessageBox.Show("Kode Buku masih kosong", "pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bersih();
                TextKodePinjam.Focus();
            }
            else
            {
                Perpustakaan.cmd = new OleDbCommand
                    ("INSERT INTO Peminjaman (Kode_Pinjam, ID_Anggota, Nama_Anggota, Kode_Buku, Judul_Buku, Tanggal_Pinjam, Tanggal_BatasPinjam, Status)" +
                    "VALUES ('" + TextKodePinjam.Text + "'," +
                    "'" + ComboIDAnggota.Text + "'," +
                    "'" + ComboKodeBuku.Text + "'," +
                    "'" + dateTimePicker1.Value + "'," +
                    "'" + dateTimePicker2.Value + "'," +
                    "'" + "Dipinjam" + "')", connection: Perpustakaan.con);
                Perpustakaan.cmd.ExecuteNonQuery();
                ambildata();

                MessageBox.Show("Data Sudah Tersimpan.", "pesan", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                bersih();
            }
        }

        private void ComboPilihanPeminjaman_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextCariPeminjaman.Focus();
        }

        private void TextCariPeminjaman_TextChanged(object sender, EventArgs e)
        {
            if (ComboPilihanPeminjaman.SelectedIndex == 0)
            {
                Perpustakaan.daPeminjaman = new OleDbDataAdapter("SELECT * FROM Peminjaman where Kode_Pinjam like '%" + TextCariPeminjaman.Text + "%'", Perpustakaan.con);
            }
            else if (ComboPilihanPeminjaman.SelectedIndex == 1)
            {
                Perpustakaan.daPeminjaman = new OleDbDataAdapter("SELECT * FROM Peminjaman where ID_Anggota like '%" + TextCariPeminjaman.Text + "%'", Perpustakaan.con);
            }
            else if (ComboPilihanPeminjaman.SelectedIndex == 2)
            {
                Perpustakaan.daPeminjaman = new OleDbDataAdapter("SELECT * FROM Peminjaman where Kode_Buku like '%" + TextCariPeminjaman.Text + "%'", Perpustakaan.con);
            }
            else if (ComboPilihanPeminjaman.SelectedIndex == 3 )
            {
                Perpustakaan.daPeminjaman = new OleDbDataAdapter("SELECT * FROM Peminjaman where Tanggal_Pinjam like '%" + TextCariPeminjaman.Text + "%'", Perpustakaan.con);
            }
            else if (ComboPilihanPeminjaman.SelectedIndex == 4)
            {
                Perpustakaan.daPeminjaman = new OleDbDataAdapter("SELECT * FROM Peminjaman where Tanggal_Batas_Pinjam like '%" + TextCariPeminjaman.Text + "%'", Perpustakaan.con);
            }
            ambildata();
        }

        private void ButtonHapusPeminjaman_Click(object sender, EventArgs e)
        {
            int brs;
            string kode;

            brs = dataGridView1.CurrentRow.Index;
            kode = dataGridView1[0, brs].Value.ToString();

            if (MessageBox.Show("Apakah Kode_Pinjam =" + kode + "\n" + "ingin Dihapus ?", "Pesan",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Perpustakaan.cmd = new OleDbCommand
                    ("delete FROM Peminjaman where Kode_Pinjam = '" + kode + "'", Perpustakaan.con);
                Perpustakaan.cmd.ExecuteNonQuery();
                ambildata();

                MessageBox.Show("Data Sudah Terhapus", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ButtonKoreksiPeminjaman_Click(object sender, EventArgs e)
        {
            if (ButtonKoreksiPeminjaman.Text == "Koreksi")
            {
                ButtonKoreksiPeminjaman.Text = "Edit";
                ButtonSimpanPeminjaman.Enabled = false;
                ButtonHapusPeminjaman.Enabled = false;
                TextKodePinjam.Enabled = false;

                int brs;
                brs = dataGridView1.CurrentRow.Index;
                TextKodePinjam.Text = dataGridView1[0, brs].Value.ToString();
                ComboIDAnggota.Text = dataGridView1[1, brs].Value.ToString();
                ComboKodeBuku.Text = dataGridView1[2, brs].Value.ToString();
                dateTimePicker1.Value =
                    Convert.ToDateTime(dataGridView1[4, brs].Value);
                dateTimePicker2.Value =
                    Convert.ToDateTime(dataGridView1[5, brs].Value);
            }
            else if (ButtonKoreksiPeminjaman.Text == "Edit")
            {
                ButtonKoreksiPeminjaman.Text = "Koreksi";
                ButtonSimpanPeminjaman.Enabled = true;
                ButtonHapusPeminjaman.Enabled = true;
                TextKodePinjam.Enabled = true;

                Perpustakaan.cmd = new OleDbCommand
                    ("update Peminjaman set " +
                    "ID_Anggota ='" + ComboIDAnggota.Text + "'," +
                    "Kode_Buku ='" + TextKodePinjam.Text + "'," +
                    "Tanggal_Pinjam ='" + dateTimePicker1.Text + "'," +
                    "Tanggal_BatasPinjam ='" + dateTimePicker2.Text + "' where " +
                    "Kode_Pinjam = '" + TextKodePinjam.Text + "'", Perpustakaan.con);
                Perpustakaan.cmd.ExecuteNonQuery();
                ambildata();

                MessageBox.Show("Data sudah terEdit", "Pesan",
                                 MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                bersih();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ComboPilihanPeminjaman.SelectedIndex = -1;
            TextCariPeminjaman.Clear();

            Perpustakaan.daPeminjaman = new OleDbDataAdapter
                ("select * from Peminjaman", Perpustakaan.con);
            ambildata();
            ButtonSimpanPeminjaman.Enabled = true;
            ButtonHapusPeminjaman.Enabled = true;
            TextKodePinjam.Enabled = true;

            if (ButtonKoreksiPeminjaman.Text == "Edit")
            {
                ButtonKoreksiPeminjaman.Text = "Koreksi";
            }
            bersih();
        }

        private void ButtonTutupPeminjaman_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextKodePinjam_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupCariPeminjaman_Enter(object sender, EventArgs e)
        {

        }
    }
}
