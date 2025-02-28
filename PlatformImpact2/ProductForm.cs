using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatformImpact2
{
    public partial class ProductForm : Form
    {
        koneksi connect = new koneksi();
        string id,role;
        public ProductForm(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNamaProduk.Text.Equals("") || tbHargaProduk.Text.Equals("") || tbDeskripsiProduk.Text.Equals(""))
                {
                    MessageBox.Show("Silahkan lengkapi data");
                }
                else
                {
                    SqlConnection con = connect.GetConnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Product (nama_product,harga_product,deskripsi_product) values (@nama,@harga,@deskripsi)", con);
                    cmd.Parameters.AddWithValue("@nama", tbNamaProduk.Text);
                    cmd.Parameters.AddWithValue("@harga", tbHargaProduk.Text);
                    cmd.Parameters.AddWithValue("@deskripsi", tbDeskripsiProduk.Text);
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
                SqlCommand cmd = new SqlCommand("update Product set nama_product = @nama, harga_product = @harga, deskripsi_product = @deskripsi where id_product = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nama", tbNamaProduk.Text);
                cmd.Parameters.AddWithValue("@harga", tbHargaProduk.Text);
                cmd.Parameters.AddWithValue("@deskripsi", tbDeskripsiProduk.Text);
                int check = cmd.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Berhasil");
                    tampilData();
                    btnEdit.Enabled = false;
                    btnHapus.Enabled = false;
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
            DialogResult dialog = MessageBox.Show("Yakin data yang dipilih mau dihapus?", "Korfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                SqlConnection con = connect.GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Product where id_product = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                int check = cmd.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Berhasil");
                    tampilData();
                    btnEdit.Enabled = false;
                    btnHapus.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Gagal");
                }
            }
        }

        private void btnCampaign_Click(object sender, EventArgs e)
        {
            CampaignForm CF = new CampaignForm(role);
            CF.Show();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            tampilData();
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvProduct.Rows[e.RowIndex];
                tbNamaProduk.Text = row.Cells["Nama Product"].Value.ToString();
                tbHargaProduk.Text = row.Cells["Harga"].Value.ToString();
                tbDeskripsiProduk.Text = row.Cells["Deskripsi"].Value.ToString();
                id = row.Cells["ID"].Value.ToString();
                btnEdit.Enabled = true;
                btnHapus.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something error : " + ex.Message);
            }
        }

        void tampilData()
        {
            try
            {
                SqlConnection con = connect.GetConnection();
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select id_product as 'ID',nama_product as 'Nama Product',harga_product as 'Harga',deskripsi_product as 'Deskripsi' from Product", con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvProduct.DataSource = table;
                dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something error : " + ex.ToString());
            }
        }
    }
}
