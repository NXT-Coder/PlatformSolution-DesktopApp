using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatformImpact2
{
    public partial class Form1 : Form
    {
        koneksi connect = new koneksi();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbPassword.Text.Equals("") || tbUsername.Text.Equals(""))
                {
                    MessageBox.Show("Silahkan lengkapi data anda!");
                }
                else
                {
                    SqlConnection con = connect.GetConnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from Login join Role on Login.id_role = Role.id_role where Login.username = @username", con);
                    cmd.Parameters.AddWithValue("@username", tbUsername.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        string hashPasword = connect.hashPassword(tbPassword.Text);
                        string sqlPassword = table.Rows[0][3].ToString();
                        if (sqlPassword.Equals(hashPasword))
                        {
                            if (table.Rows[0][7].ToString().Equals("admin"))
                            {
                                // Masuk Product & Platform
                                string name = table.Rows[0][1].ToString();
                                DashboardForm DF = new DashboardForm(name, table.Rows[0][7].ToString());
                                DF.Show();
                                this.Hide();

                            }
                            else if (table.Rows[0][7].ToString().Equals("manager"))
                            {
                                // Masuk Producer
                                string name = table.Rows[0][1].ToString();
                                DashboardForm DF = new DashboardForm(name, table.Rows[0][7].ToString());
                                DF.Show();
                                this.Hide();
                            }
                            else if (table.Rows[0][7].ToString().Equals("producer"))
                            {
                                string name = table.Rows[0][1].ToString();
                                DashboardForm DF = new DashboardForm(name, table.Rows[0][7].ToString());
                                DF.Show();
                                this.Hide();
                            }
                            else if (table.Rows[0][7].ToString().Equals("developer"))
                            {
                                string name = table.Rows[0][1].ToString();
                                DashboardForm DF = new DashboardForm(name, table.Rows[0][7].ToString());
                                DF.Show();
                                this.Hide();
                            }
                            else if (table.Rows[0][7].ToString().Equals("realtime"))
                            {
                                RealTimeForm realTimeForm = new RealTimeForm();
                                realTimeForm.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password salah");
                        }
                    }
                    else
                    {
                        cmd = new SqlCommand("select * from Producer where username = @username", con);
                        cmd.Parameters.AddWithValue("@username", tbUsername.Text);
                        adapter = new SqlDataAdapter(cmd);
                        table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            string hashPassword = connect.hashPassword(tbPassword.Text);
                            string sqlPassword = table.Rows[0][3].ToString();
                            if (sqlPassword.Equals(hashPassword))
                            {
                                // Masuk Navigasi Konten & Platform
                            }
                        }
                        else
                        {
                            MessageBox.Show("Akun belum terdaftar, silahkan hubungi admin");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something error : " + ex.Message);
            }
        }
    }
}
