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
    public partial class FormPenerbit : Form
    {
        public FormPenerbit()
        {
            InitializeComponent();
        }

        void ambildata()
        {
            Perpustakaan.tblPenerbit.Clear();
            Perpustakaan.daPenerbit.Fill(Perpustakaan.tblPenerbit);
        }

        void bersih()
        {
            TextIDPenerbit.Clear();
            TextNamaPenerbit.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormPenerbit_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            Perpustakaan.con = Perpustakaan.konek_db();

            Perpustakaan.daPenerbit = new OleDbDataAdapter("SELECT * FROM Penerbit", Perpustakaan.con);
            ambildata();

            dataGridView1.DataSource = Perpustakaan.tblPenerbit;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Columns[0].HeaderText = "Kode Penerbit";
            dataGridView1.Columns[0].Width = 120;

            dataGridView1.Columns[1].HeaderText = "Nama Penerbit";
            dataGridView1.Columns[1].Width = 150;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSimpanPenerbit_Click(object sender, EventArgs e)
        {
            Perpustakaan.cmd = new OleDbCommand
                ("Select * From Penerbit where Kode_Penerbit='" + TextIDPenerbit.Text + "'", Perpustakaan.con);
            Perpustakaan.dtr = Perpustakaan.cmd.ExecuteReader();

            if (Perpustakaan.dtr.HasRows)
            {
                MessageBox.Show("Kode Penerbit tersebut sudah ada", "pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextIDPenerbit.Clear();
                TextIDPenerbit.Focus();
            }
            else if (TextIDPenerbit.Text.Trim() == "")
            {
                MessageBox.Show("Kode Penerbit masih kosong", "pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextIDPenerbit.Clear();
                TextIDPenerbit.Focus();
            }
            else
            {
                Perpustakaan.cmd = new OleDbCommand
                    ("INSERT INTO Penerbit (Kode_Penerbit, Nama_Penerbit)" +
                    "VALUES ('" + TextIDPenerbit.Text + "'," +
                    "'" + TextNamaPenerbit.Text + "')", Perpustakaan.con);
                Perpustakaan.cmd.ExecuteNonQuery();
                ambildata();

                MessageBox.Show("Data Sudah Tersimpan.", "pesan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                bersih();
            }
        }

        private void ButtonHapusPenerbit_Click(object sender, EventArgs e)
        {
            int brs;
            string kode;

            brs = dataGridView1.CurrentRow.Index;
            kode = dataGridView1[0, brs].Value.ToString();

            if (MessageBox.Show("Apakah Kode Penerbit =" + kode + "\n" +
                "ingin dihapus?", "pesan", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Perpustakaan.cmd = new OleDbCommand
                    ("DELETE FROM Penerbit where Kode_Penerbit='" + kode + "'", Perpustakaan.con);
                Perpustakaan.cmd.ExecuteNonQuery();
                ambildata();

                MessageBox.Show("Data Sudah Terhapus.", "pesan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextCariPenerbit.Focus();
        }

        private void TextCariPenerbit_TextChanged(object sender, EventArgs e)
        {
            if (ComboPilihanPenerbit.SelectedIndex == 0)
            {
                Perpustakaan.daPenerbit = new OleDbDataAdapter("SELECT * FROM Penerbit where Kode_Penerbit like '%" + TextCariPenerbit.Text + "%'", Perpustakaan.con);
            }
            else if (ComboPilihanPenerbit.SelectedIndex == 1)
            {
                Perpustakaan.daPenerbit = new OleDbDataAdapter("SELECT * FROM Penerbit where Nama_Penerbit like '%" + TextCariPenerbit.Text + "%'", Perpustakaan.con);
            }
            ambildata();
        }

        private void ButtonKoreksiPenerbit_Click(object sender, EventArgs e)
        {
            if (ButtonKoreksiPenerbit.Text == "Koreksi")
            {
                ButtonKoreksiPenerbit.Text = "Edit";
                ButtonSimpanPenerbit.Enabled = false;
                ButtonHapusPenerbit.Enabled = false;
                TextIDPenerbit.Enabled = false;

                int brs;
                brs = dataGridView1.CurrentRow.Index;
                TextIDPenerbit.Text = dataGridView1[0, brs].Value.ToString();
                TextNamaPenerbit.Text = dataGridView1[1, brs].Value.ToString();
            }
            else if (ButtonKoreksiPenerbit.Text == "Edit")

            {
                ButtonKoreksiPenerbit.Text = "Koreksi";
                ButtonSimpanPenerbit.Enabled = true;
                ButtonHapusPenerbit.Enabled = true;
                TextIDPenerbit.Enabled = true;

                Perpustakaan.cmd = new OleDbCommand
                    ("UPDATE Penerbit set " +
                    "Kode_Penerbit ='" + TextIDPenerbit.Text + "'," +
                    "Nama_Penerbit = '" + TextNamaPenerbit.Text + "'", Perpustakaan.con);
                Perpustakaan.cmd.ExecuteNonQuery();
                ambildata();

                MessageBox.Show("Data sudah terEdit", "Pesan",
                                 MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                bersih();
            }

        }

        private void TextIDPenerbit_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ComboPilihanPenerbit.SelectedIndex = -1;
            TextCariPenerbit.Clear();

            Perpustakaan.daPenerbit = new OleDbDataAdapter
                ("select * from Penerbit", Perpustakaan.con);
            ambildata();
            ButtonSimpanPenerbit.Enabled = true;
            ButtonHapusPenerbit.Enabled = true;
            TextIDPenerbit.Enabled = true;

            if (ButtonKoreksiPenerbit.Text == "Edit")
            {
                ButtonKoreksiPenerbit.Text = "Koreksi";
            }
            bersih();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
