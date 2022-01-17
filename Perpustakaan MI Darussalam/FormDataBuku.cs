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
    public partial class FormDataBuku : Form
    {
        public FormDataBuku()
        {
            InitializeComponent();
        }
        void ambildata()
        {
            Perpustakaan.tblBuku.Clear();
            Perpustakaan.daBuku.Fill(Perpustakaan.tblBuku);
        }

        void bersih()
        {
            TextBuku.Clear();
            TextJudulBuku.Clear();
            TextPengarang.Clear();
            TextPenerbit.Clear();
            TextTahunTerbit.Clear();
            TextJumlahBuku.Clear();
        }

        private void FormDataBuku_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            Perpustakaan.con = Perpustakaan.konek_db();

            Perpustakaan.daBuku = new OleDbDataAdapter("SELECT * FROM Buku", Perpustakaan.con);
            ambildata();

            dataGridView1.DataSource = Perpustakaan.tblBuku;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Columns[0].HeaderText = "Kode Buku";
            dataGridView1.Columns[0].Width = 120;

            dataGridView1.Columns[1].HeaderText = "Judul Buku";
            dataGridView1.Columns[1].Width = 130;

            dataGridView1.Columns[2].HeaderText = "Pengarang";
            dataGridView1.Columns[2].Width = 150;

            dataGridView1.Columns[3].HeaderText = "Penerbit";
            dataGridView1.Columns[3].Width = 120;

            dataGridView1.Columns[4].HeaderText = "Tahun Terbit";
            dataGridView1.Columns[4].Width = 120;

            dataGridView1.Columns[5].HeaderText = "Jumlah";
            dataGridView1.Columns[5].Width = 120;
        }

        private void ButtonSimpanBuku_Click(object sender, EventArgs e)
        {
            Perpustakaan.cmd = new OleDbCommand
                ("select * From Buku where Kode_Buku=" + TextBuku.Text + "", Perpustakaan.con);
            Perpustakaan.dtr = Perpustakaan.cmd.ExecuteReader();

            if (Perpustakaan.dtr.HasRows)
            {
                MessageBox.Show("Kode Buku tersebut sudah ada", "pesan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                TextBuku.Clear();
                TextBuku.Focus();
            }
            else if (TextBuku.Text.Trim() == "")
            {
                MessageBox.Show("Kode Buku masih kosong", "pesan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                TextBuku.Clear();
                TextBuku.Focus();
            }
            else
            {
                Perpustakaan.cmd = new OleDbCommand
                    ("INSERT INTO Buku (Kode_Buku, Judul_Buku, Pengarang, Penerbit, Tahun_Terbit, Jumlah)" +
                    "VALUES ('" + TextBuku.Text + "'," +
                    "'" + TextJudulBuku.Text + "'," +
                    "'" + TextPengarang.Text + "'," +
                    "'" + TextPenerbit.Text + "'," +
                    "'" + TextTahunTerbit.Text + "'," +
                    "'" + TextJumlahBuku.Text + "')", Perpustakaan.con);
                Perpustakaan.cmd.ExecuteNonQuery();
                ambildata();

                MessageBox.Show("Data Sudah Tersimpan.", "pesan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                bersih();
            }

        }

        private void ButtonHapusBuku_Click(object sender, EventArgs e)
        {
            int brs;
            string kode;

            brs = dataGridView1.CurrentRow.Index;
            kode = dataGridView1[0, brs].Value.ToString();

            if (MessageBox.Show("Apakah Kode Buku =" + kode + "\n" +
                "ingin dihapus?", "pesan", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Perpustakaan.cmd = new OleDbCommand
                    ("DELETE FROM Buku where Kode_Buku=" + kode + "", Perpustakaan.con);
                Perpustakaan.cmd.ExecuteNonQuery();
                ambildata();

                MessageBox.Show("Data Sudah Terhapus.", "pesan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComboPilihanBuku.SelectedIndex = -1;
            TextCariBuku.Clear();

            Perpustakaan.daBuku = new OleDbDataAdapter
                ("select * from Buku", Perpustakaan.con);
            ambildata();
            ButtonSimpanBuku.Enabled = true;
            ButtonHapusBuku.Enabled = true;
            TextBuku.Enabled = true;

            if (ButtonKoreksiBuku.Text == "Edit")
            {
                ButtonKoreksiBuku.Text = "Koreksi";
            }
            bersih();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonKoreksiBuku_Click(object sender, EventArgs e)
        {
            if (ButtonKoreksiBuku.Text == "Koreksi")
            {
                ButtonKoreksiBuku.Text = "Edit";
                ButtonSimpanBuku.Enabled = false;
                ButtonHapusBuku.Enabled = false;
                TextBuku.Enabled = false;

                int brs;
                brs = dataGridView1.CurrentRow.Index;
                TextBuku.Text = dataGridView1[0, brs].Value.ToString();
                TextJudulBuku.Text = dataGridView1[1, brs].Value.ToString();
                TextPengarang.Text = dataGridView1[2, brs].Value.ToString();
                TextPenerbit.Text = dataGridView1[3, brs].Value.ToString();
                TextTahunTerbit.Text = dataGridView1[4, brs].Value.ToString();
            }
            else if (ButtonKoreksiBuku.Text == "Edit")
            {
                ButtonKoreksiBuku.Text = "Koreksi";
                ButtonSimpanBuku.Enabled = true;
                ButtonHapusBuku.Enabled = true;
                TextBuku.Enabled = true;

                Perpustakaan.cmd = new OleDbCommand
                    ("UPDATE Buku set " +
                    "Judul_Buku ='" + TextJudulBuku.Text + "'," +
                    "Penerbit ='" + TextPenerbit.Text + "'," +
                    "Pengarang ='" + TextPengarang.Text + "'," +
                    "Tahun_Terbit ='" + TextTahunTerbit.Text + "',"+
                    "Jumlah =" + TextJumlahBuku.Text + " where " +
                    "Kode_Buku = " + TextBuku.Text + "", Perpustakaan.con);
                Perpustakaan.cmd.ExecuteNonQuery();
                ambildata();

                MessageBox.Show("Data sudah terEdit", "Pesan",
                                 MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                bersih();
            }
        }

        private void ComboPilihanBuku_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextCariBuku.Focus();
        }

        private void TextCariBuku_TextChanged(object sender, EventArgs e)
        {
            if (ComboPilihanBuku.SelectedIndex == 0)
            {
                Perpustakaan.daBuku = new OleDbDataAdapter("SELECT * FROM Buku where Kode_Buku like '%" + TextCariBuku.Text + "%'", Perpustakaan.con);
            }
            else if (ComboPilihanBuku.SelectedIndex == 1)
            {
                Perpustakaan.daBuku = new OleDbDataAdapter("SELECT * FROM Buku where Judul_Buku like '%" + TextCariBuku.Text + "%'", Perpustakaan.con);
            }
            else if (ComboPilihanBuku.SelectedIndex == 2)
            {
                Perpustakaan.daBuku = new OleDbDataAdapter("SELECT * FROM Buku where Pengarang like '%" + TextCariBuku.Text + "%'", Perpustakaan.con);
            }
            else if (ComboPilihanBuku.SelectedIndex == 3)
            {
                Perpustakaan.daBuku = new OleDbDataAdapter("SELECT * FROM Buku where Penerbit like '%" + TextCariBuku.Text + "%'", Perpustakaan.con);
            }
            else if (ComboPilihanBuku.SelectedIndex == 4)
            {
                Perpustakaan.daBuku = new OleDbDataAdapter("SELECT * FROM Buku where Tahun_Terbit like '%" + TextCariBuku.Text + "%'", Perpustakaan.con);
            }
            ambildata();

        }
    }
}
