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
    public partial class FormPengarang : Form
    {
        public FormPengarang()
        {
            InitializeComponent();
        }

        void ambildata()
        {
            Perpustakaan.tblPengarang.Clear();
            Perpustakaan.daPengarang.Fill(Perpustakaan.tblPengarang);
        }

        void bersih()
        {
            TextIDPengarang.Clear();
            TextNamaPengarang.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormPengarang_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            Perpustakaan.con = Perpustakaan.konek_db();

            Perpustakaan.daPengarang = new OleDbDataAdapter("SELECT * FROM Pengarang", Perpustakaan.con);
            ambildata();

            dataGridView1.DataSource = Perpustakaan.tblPengarang;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Columns[0].HeaderText = "Kode Pengarang";
            dataGridView1.Columns[0].Width = 120;

            dataGridView1.Columns[1].HeaderText = "Nama Pengarang";
            dataGridView1.Columns[1].Width = 150;
        }

        private void ButtonSimpan_Click(object sender, EventArgs e)
        {
            Perpustakaan.cmd = new OleDbCommand
                ("Select * From Pengarang where Kode_Pengarang='" + TextIDPengarang.Text + "'", Perpustakaan.con);
            Perpustakaan.dtr = Perpustakaan.cmd.ExecuteReader();

            if (Perpustakaan.dtr.HasRows)
            {
                MessageBox.Show("Kode Pengarang tersebut sudah ada", "pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextIDPengarang.Clear();
                TextIDPengarang.Focus();
            }
            else if (TextIDPengarang.Text.Trim() == "")
            {
                MessageBox.Show("Kode Pengarang masih kosong", "pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextIDPengarang.Clear();
                TextIDPengarang.Focus();
            }
            else
            {
                Perpustakaan.cmd = new OleDbCommand
                    ("INSERT INTO Pengarang (Kode_Pengarang, Nama_Pengarang)" +
                    "VALUES ('" + TextIDPengarang.Text + "'," +
                    "'" + TextNamaPengarang.Text + "')", Perpustakaan.con);
                Perpustakaan.cmd.ExecuteNonQuery();
                ambildata();

                MessageBox.Show("Data Sudah Tersimpan.", "pesan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                bersih();
            }
        }

        private void ButtonHapus_Click(object sender, EventArgs e)
        {
            int brs;
            string kode;

            brs = dataGridView1.CurrentRow.Index;
            kode = dataGridView1[0, brs].Value.ToString();

            if (MessageBox.Show("Apakah Kode Pengarang =" + kode + "\n" +
                "ingin dihapus?", "pesan", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Perpustakaan.cmd = new OleDbCommand
                    ("DELETE FROM Pengarang where Kode_Pengarang=" + kode + "", Perpustakaan.con);
                Perpustakaan.cmd.ExecuteNonQuery();
                ambildata();

                MessageBox.Show("Data Sudah Terhapus.", "pesan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void TextPilihanPengarang_TextChanged(object sender, EventArgs e)
        {
            TextCariPengarang.Focus();
        }

        private void TextCariPengarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboPilihanPengarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboPilihanPengarang.SelectedIndex == 0)
            {
                Perpustakaan.daPengarang = new OleDbDataAdapter("SELECT * FROM Pengarang where Kode_Pengarang like '%" + TextCariPengarang.Text + "%'", Perpustakaan.con);
            }
            else if (ComboPilihanPengarang.SelectedIndex == 1)
            {
                Perpustakaan.daPengarang = new OleDbDataAdapter("SELECT * FROM Pengarang where Nama_Pengarang like '%" + TextCariPengarang.Text + "%'", Perpustakaan.con);
            }
            ambildata();
        }

        private void ButtonKoreksiPengarang_Click(object sender, EventArgs e)
        {
            if (ButtonKoreksiPengarang.Text == "Koreksi")
            {
                ButtonKoreksiPengarang.Text = "Edit";
                ButtonSimpan.Enabled = false;
                ButtonHapus.Enabled = false;
                TextIDPengarang.Enabled = false;

                int brs;
                brs = dataGridView1.CurrentRow.Index;
                TextIDPengarang.Text = dataGridView1[0, brs].Value.ToString();
                TextNamaPengarang.Text = dataGridView1[1, brs].Value.ToString();
            }
            else if (ButtonKoreksiPengarang.Text == "Edit")

            {
                ButtonKoreksiPengarang.Text = "Koreksi";
                ButtonSimpan.Enabled = true;
                ButtonHapus.Enabled = true;
                TextIDPengarang.Enabled = true;

                Perpustakaan.cmd = new OleDbCommand
                    ("UPDATE Pengarang set " +
                    "Kode_Pengarang ='" + TextIDPengarang.Text + "'," +
                    "Nama_Pengarang = '" + TextNamaPengarang.Text + "'", Perpustakaan.con);
                Perpustakaan.cmd.ExecuteNonQuery();
                ambildata();

                MessageBox.Show("Data sudah terEdit", "Pesan",
                                 MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                bersih();
            }
        }

        private void ButtonBatalPengarang_Click(object sender, EventArgs e)
        {
            ComboPilihanPengarang.SelectedIndex = -1;
            TextCariPengarang.Clear();

            Perpustakaan.daPengarang = new OleDbDataAdapter
                ("select * from Pengarang", Perpustakaan.con);
            ambildata();
            ButtonSimpan.Enabled = true;
            ButtonHapus.Enabled = true;
            TextIDPengarang.Enabled = true;

            if (ButtonKoreksiPengarang.Text == "Edit")
            {
                ButtonKoreksiPengarang.Text = "Koreksi";
            }
            bersih();
        }

        private void ButtonTutupPengarang_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
