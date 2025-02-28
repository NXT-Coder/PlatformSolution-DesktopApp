using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PlatformImpact2
{
    public partial class AddProducerFrom : Form
    {
        string role,id;
        koneksi connect = new koneksi();
        public AddProducerFrom(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void AddProducerFrom_Load(object sender, EventArgs e)
        {
            tampilData();
        }
        void tampilData()
        {
            SqlConnection con = connect.GetConnection();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select id_login as 'ID',name as 'Name',username as 'Username' from Login where id_role = 3", con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvProducer.DataSource = table;
        }

        private void btnCampaign_Click(object sender, EventArgs e)
        {
            CampaignForm form = new CampaignForm(role);
            form.Show();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpaProducer_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = connect.GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Login (name,username,password,id_role) values (@name,@username,@password,@role)", con);
                string hashPassword = connect.hashPassword(tbPasswordProducer.Text);
                cmd.Parameters.AddWithValue("@name", tbNameProducer.Text);
                cmd.Parameters.AddWithValue("@username", tbUsernameProducer.Text);
                cmd.Parameters.AddWithValue("@password", hashPassword);
                cmd.Parameters.AddWithValue("@role", "3");
                int check = cmd.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Berhasil");
                    tampilData();
                }
                else
                {
                    MessageBox.Show("Gagal");
                    tampilData();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Someting error : " + ex.Message);
            }
        }

        private void btnEditProducer_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = connect.GetConnection();
                con.Open();
                SqlCommand cmd;
                if (tbPasswordProducer.Text.Equals(""))
                {
                    cmd = new SqlCommand("update Login set name = @name, username = @username where id_login = @id", con);
                    cmd.Parameters.AddWithValue("@name",tbNameProducer.Text);
                    cmd.Parameters.AddWithValue("@username",tbUsernameProducer.Text);
                    cmd.Parameters.AddWithValue("@id", id);
                } else
                {
                    cmd = new SqlCommand("update Login set name = @name, username = @username,password = @password where id_login = @id", con);
                    string hashPassword = connect.hashPassword(tbPasswordProducer.Text);
                    cmd.Parameters.AddWithValue("@name", tbNameProducer.Text);
                    cmd.Parameters.AddWithValue("@username", tbUsernameProducer.Text);
                    cmd.Parameters.AddWithValue("@password", hashPassword);
                    cmd.Parameters.AddWithValue("@id", id);
                }
                int check = cmd.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Berhasil diedit");
                    tampilData();
                }
                else
                {
                    MessageBox.Show("Gagal diedit");
                    tampilData();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Something error : " + ex.Message);
            }
        }

        private void btnHapusProducer_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Data ini mau dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    SqlConnection con = connect.GetConnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Login where id_login = @id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    int check = cmd.ExecuteNonQuery();
                    if (check > 0)
                    {
                        MessageBox.Show("Berhasil dihapus");
                        tampilData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal dihapus");
                        tampilData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something error : " + ex.Message);
            }
        }

        private void dgvProducer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvProducer.Rows[e.RowIndex];
            tbNameProducer.Text = row.Cells["Name"].Value.ToString();
            tbUsernameProducer.Text = row.Cells["Username"].Value.ToString();
            id = row.Cells["ID"].Value.ToString();
        }
    }
}
