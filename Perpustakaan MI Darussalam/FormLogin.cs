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
    public partial class FormLogin : Form
    {

        Perpustakaan connection = new Perpustakaan();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
                Application.Exit();
                this.Dispose();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        private void LoginUser()
        {
            try
            {
                string sql;
                OleDbCommand cmd;
                OleDbDataAdapter da;

                DataSet ds = new DataSet("ds");

                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = "Provider=Microsoft.ace.oledb.12.0;Data Source=" + Application.StartupPath + "/DbPerpustakaan.accdb";

                connection.Open();

                sql = "select * from admin where username = '" + TextUsername.Text + "'";
                cmd = new OleDbCommand(sql, connection);
                da = new OleDbDataAdapter(cmd);

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (TextPassword.Text.ToLower().Trim() == ds.Tables[0].Rows[0]["Password"].ToString().Trim().ToLower())
                    {
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password Salah");
                        TextPassword.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("User ID Tidak Terdaftar");
                    TextUsername.Focus();
                }
                connection.Close();
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
            }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        private void TextUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

