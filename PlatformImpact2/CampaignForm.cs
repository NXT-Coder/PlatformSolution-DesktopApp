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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PlatformImpact2
{
    public partial class CampaignForm : Form
    {
        koneksi connect = new koneksi();
        string role,id;
        public CampaignForm(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = connect.GetConnection();
                con.Open();
                string product = cbProduct.SelectedItem.ToString();
                string producer = cbProducer.SelectedItem.ToString();

                SqlCommand cmd = new SqlCommand($"select id_product from Product where nama_product = '{product}'", con);
                string idProduct = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand($"select id_login from Login where username = '{producer}'", con);
                string idProducer = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand("insert into Campaign (nama_campaign,id_product,id_producer) values (@nama,@product,@producer)", con);
                cmd.Parameters.AddWithValue("@nama", tbNamaCampaign.Text);
                cmd.Parameters.AddWithValue("@product", idProduct);
                cmd.Parameters.AddWithValue("@producer", idProducer);
                int check = cmd.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Berhasil");
                    tampilData();
                    tampilCOmbo();
                }
                else
                {
                    MessageBox.Show("Gagal");
                    tampilData();
                    tampilCOmbo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something error : " + ex.Message);
            }
        }

        private void btnSimpaProducer_Click(object sender, EventArgs e)
        {
            
        }

        private void CampaignForm_Load(object sender, EventArgs e)
        {
            tampilData();
            tampilCOmbo();
        }
        void tampilData()
        {
            SqlConnection con = connect.GetConnection();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select id_campaign as 'ID',nama_campaign as 'Nama Campaign',Product.nama_product as 'Nama Product',Login.username as 'Producer' from Campaign join Product on Campaign.id_product = Product.id_product join Login on Campaign.id_producer = Login.id_login", con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvProducer.DataSource = table;
        }
        void tampilCOmbo()
        {
            try
            {
                SqlConnection con = connect.GetConnection();
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from product", con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                cbProduct.Items.Add("Pilih data");
                foreach (DataRow row in table.Rows)
                {
                    cbProduct.Items.Add(row[1].ToString());
                }
                cbProduct.SelectedIndex = 0;
                adapter = new SqlDataAdapter("select * from Login where id_role = 3", con);
                table = new DataTable();
                adapter.Fill(table);
                cbProducer.Items.Add("Pilih Produser");
                foreach (DataRow row in table.Rows)
                {
                    cbProducer.Items.Add(row[1].ToString());
                }
                cbProducer.SelectedIndex = 0;
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
                string product = cbProduct.SelectedItem.ToString();
                string producer = cbProducer.SelectedItem.ToString();

                SqlCommand cmd = new SqlCommand($"select id_product from Product where nama_product = '{product}'", con);
                string idProduct = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand($"select id_login from Login where username = '{producer}'", con);
                string idProducer = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand("update Campaign set nama_campaign = @nama,id_producer = @producer, id_product = @product where id_campaign = @id", con);
                cmd.Parameters.AddWithValue("@nama",tbNamaCampaign.Text);
                cmd.Parameters.AddWithValue("@producer", idProducer);
                cmd.Parameters.AddWithValue("@product", idProduct);
                cmd.Parameters.AddWithValue("@id", id);
                int check = cmd.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Berhasil diedit");
                    tampilData();
                } else
                {
                    MessageBox.Show("Gagal diedit");
                    tampilData();
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
                SqlConnection con = connect.GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Campaign where id_campaign = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                int check = cmd.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Berhasil dihapus");
                    tampilData();
                } else
                {
                    MessageBox.Show("Gagal dihapus");
                    tampilData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something error : " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void dgvProducer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvProducer.Rows[e.RowIndex];
                tbNamaCampaign.Text = row.Cells["Nama Campaign"].Value.ToString();
                cbProduct.SelectedItem = row.Cells["Nama Product"].Value.ToString();
                cbProducer.SelectedItem = row.Cells["Producer"].Value.ToString();
                id = row.Cells["ID"].Value.ToString();
            } catch(Exception ex)
            {
                MessageBox.Show("Something error : " + ex.Message);
            }
        }
    }
}
