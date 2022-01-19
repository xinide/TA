using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;


namespace Perpustakaan_MI_Darussalam
{
    class Perpustakaan
    {
        public static OleDbConnection con;
        public static OleDbCommand cmd;
        public static OleDbDataReader dtr;

        public static OleDbDataAdapter daAdmin;
        public static DataTable tblAdmin = new DataTable();

        public static OleDbDataAdapter daPenerbit;
        public static DataTable tblPenerbit = new DataTable();

        public static OleDbDataAdapter daPengarang;
        public static DataTable tblPengarang = new DataTable();

        public static OleDbDataAdapter daBuku;
        public static DataTable tblBuku = new DataTable();

        public static OleDbDataAdapter daPeminjaman;
        public static DataTable tblPeminjaman = new DataTable();

        public static OleDbDataAdapter daPengembalian;
        public static DataTable tblPengembalian = new DataTable();

        public static OleDbDataAdapter daAnggota;
        public static DataTable tblAnggota = new DataTable();

        public static OleDbConnection konek_db()
        {
            OleDbConnection con = new OleDbConnection
                ("Provider=microsoft.ace.oledb.12.0; data source=DbPerpustakaan.accdb");
            con.Open();
            return con;
        }

    }
}
