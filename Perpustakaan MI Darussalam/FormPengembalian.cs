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
    public partial class FormPengembalian : Form
    {
        Perpustakaan KoneksiBaru = new Perpustakaan();

        public FormPengembalian()
        {
            InitializeComponent();
        }

        void ambildata()
        {
            Perpustakaan.tblPengembalian.Clear();
            Perpustakaan.daPengembalian.Fill(Perpustakaan.tblPengembalian);
        }

        void bersih()
        {
            ComboBoxKodePinjam.Text = "";
            TextDendaKembali.Clear();

        }
        private void FormPengembalian_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            Perpustakaan.con = Perpustakaan.konek_db();

            Perpustakaan.daPengembalian = new OleDbDataAdapter("SELECT * FROM Pengembalian", Perpustakaan.con);
            ambildata();

            dataGridView1.DataSource = Perpustakaan.tblPengembalian;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Columns[0].HeaderText = "Kode Pinjam";
            dataGridView1.Columns[0].Width = 130;

            dataGridView1.Columns[1].HeaderText = "Tanggal Pengembalian";
            dataGridView1.Columns[1].Width = 150;

            dataGridView1.Columns[2].HeaderText = "Denda";
            dataGridView1.Columns[2].Width = 120;

            ComboBoxKodePinjam.Items.Clear();
            Perpustakaan.cmd = new OleDbCommand
                ("select * from Peminjaman", Perpustakaan.con);
            Perpustakaan.dtr = Perpustakaan.cmd.ExecuteReader();
            while (Perpustakaan.dtr.Read())
            {
                ComboBoxKodePinjam.Items.Add(Perpustakaan.dtr["Kode_Pinjam"].ToString());
            }
        }

        private void ButtonCekDenda_Click(object sender, EventArgs e)
        {
            Perpustakaan.cmd = new OleDbCommand
                ("select * From Peminjaman where Kode_Pinjam='" + ComboBoxKodePinjam.Text + "'", Perpustakaan.con);
            Perpustakaan.dtr = Perpustakaan.cmd.ExecuteReader();
            Perpustakaan.dtr.Read();

            if (Perpustakaan.dtr.HasRows)
            {
                dateTimePicker1.Value = Convert.ToDateTime(Perpustakaan.dtr["Tanggal_BatasPinjam"]);
            }
            else if (ComboBoxKodePinjam.Text.Trim() == "")
            {
                MessageBox.Show("Kode Pinjam Masih Kosong", "pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bersih();
                ComboBoxKodePinjam.Focus();
            }
            else
            {
                MessageBox.Show("Kode Pinjam tersebut tidak ada", "pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ButtonHitungDenda_Click(object sender, EventArgs e)
        {
            DateTime tanggal1 = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime tanggal2 = Convert.ToDateTime(dateTimePicker2.Text);
            TimeSpan ts = new TimeSpan();
            ts = tanggal2.Subtract(tanggal1);
            TextDendaKembali.Text = ts.Days + "hari";
            double a = 1000 * ts.Days;
            TextDendaKembali.Text = Convert.ToString(a);
        }

        private void TextDendaKembali_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonKonfirmasi_Click(object sender, EventArgs e)
        {
            Perpustakaan.cmd = new OleDbCommand
                ("INSERT INTO Pengembalian (Kode_Pinjam, Tanggal_Pengembalian, denda)" +
                "VALUES ('" + ComboBoxKodePinjam.Text + "'," +
                "'" + dateTimePicker2.Value + "'," +
                "'" + TextDendaKembali.Text + "')", connection: Perpustakaan.con);
            Perpustakaan.cmd.ExecuteNonQuery();
            ambildata();

            Perpustakaan.cmd = new OleDbCommand
                ("UPDATE Peminjaman SET " +
                "status='" + "Dikembalikan" + "' where " +
                "Kode_Pinjam ='" + ComboBoxKodePinjam.Text + "'", Perpustakaan.con);

            MessageBox.Show("Data Sudah Tersimpan", "pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            bersih();
        }
    }
}
