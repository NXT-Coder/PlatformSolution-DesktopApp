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
    public partial class RegisterForm : Form
    {
        koneksi connect = new koneksi();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = connect.GetConnection();
                con.Open();

                string role = cbRole.SelectedItem.ToString();
                SqlCommand adapter = new SqlCommand($"select id_role from Role where role = '{role}'", con);
                string id = adapter.ExecuteScalar().ToString();

                SqlCommand cmd = new SqlCommand("insert into Login (name,username,password,id_role) values (@name,@username,@password,@role)", con);
                string hashPassword = connect.hashPassword(tbPassword.Text);
                cmd.Parameters.AddWithValue("@name", tbName.Text);
                cmd.Parameters.AddWithValue("@username", tbUsername.Text);
                cmd.Parameters.AddWithValue("@password", hashPassword);
                cmd.Parameters.AddWithValue("@role", id);
                int check = cmd.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Berhasil");
                }
                else
                {
                    MessageBox.Show("Gagal");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something error : " + ex.Message);
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = connect.GetConnection();
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Role", con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                cbRole.Items.Add("Pilih Role");
                foreach (DataRow dr in table.Rows)
                {
                    cbRole.Items.Add(dr[1].ToString());
                }
                cbRole.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something error : " + ex.Message);
            }
        }
    }
}
