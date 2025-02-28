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
    public partial class PlatformForm : Form
    {
        koneksi connect = new koneksi();
        string id;
        public PlatformForm()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNamaPlatform.Text.Equals(""))
                {
                    MessageBox.Show("Silahkan mengisi nama paltform");
                }
                else
                {
                    SqlConnection con = connect.GetConnection();
                    con.Open();
                    SqlCommand cmd;
                    if (!tbLinkPlatform.Text.Equals(""))
                    {
                        cmd = new SqlCommand("insert into Platform (nama_platform,link_platform) values (@nama,@link)", con);
                        cmd.Parameters.AddWithValue("@nama", tbNamaPlatform.Text);
                        cmd.Parameters.AddWithValue("@link", tbLinkPlatform.Text);
                    }
                    else
                    {
                        cmd = new SqlCommand("insert into Platform (nama_platform) values (@nama)", con);
                        cmd.Parameters.AddWithValue("@nama", tbNamaPlatform.Text);
                    }
                    int check = cmd.ExecuteNonQuery();
                    if (check > 0)
                    {
                        MessageBox.Show("Berhasil");
                        tampilData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something error : " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = connect.GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("update Platform set nama_platform = @nama,link_platform = @link where id_platform = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nama", tbNamaPlatform.Text);
                cmd.Parameters.AddWithValue("@link", tbLinkPlatform.Text);
                int check = cmd.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Berhasil");
                    tampilData();
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

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Yakin data yang dipilih mau dihapus?", "Korfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    SqlConnection con = connect.GetConnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Platform where id_platform = @id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    int check = cmd.ExecuteNonQuery();
                    if (check > 0)
                    {
                        MessageBox.Show("Berhasil");
                        tampilData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something error : " + ex.Message);
            }
        }

        private void PlatformForm_Load(object sender, EventArgs e)
        {
            tampilData();
        }
        void tampilData()
        {
            try
            {
                SqlConnection con = connect.GetConnection();
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select id_platform as 'ID',nama_platform as 'Nama Platform', link_platform as 'Link' from Platform", con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvPlatform.DataSource = table;
                dgvPlatform.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something error : " + ex.Message);
            }
        }

        private void dgvPlatform_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvPlatform.Rows[e.RowIndex];
                tbNamaPlatform.Text = row.Cells["Nama Platform"].Value.ToString();
                tbLinkPlatform.Text = row.Cells["Link"].Value.ToString();
                id = row.Cells["ID"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something error : " + ex.Message);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {

        }
    }
}
