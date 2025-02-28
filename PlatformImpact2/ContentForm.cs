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
using System.Xml.Linq;

namespace PlatformImpact2
{
    public partial class ContentForm : Form
    {
        string name, role,id,idProgres;
        koneksi connect = new koneksi();
        public ContentForm(string nama,string role)
        {
            InitializeComponent();
            this.name = nama;
            this.role = role;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbJenisKonten.Text.Equals("") || cbProduk.SelectedIndex == 0)
                {
                    MessageBox.Show("Silahkan lengkapi data konten");
                }
                else
                {
                    SqlConnection con = connect.GetConnection();
                    con.Open();

                    string product = cbProduk.SelectedItem.ToString();
                    SqlCommand cmd = new SqlCommand($"select * from Product where nama_product = '{product}'", con);
                    string idProduct = cmd.ExecuteScalar().ToString();

                    cmd = new SqlCommand("insert into Content (id_product,jenis_content,status_siap,status_develope) values (@idProduct,@jenisContent,@statusSiap,@statusDevelope)", con);
                    cmd.Parameters.AddWithValue("@idProduct", idProduct);
                    cmd.Parameters.AddWithValue("@jenisContent", tbJenisKonten.Text);
                    cmd.Parameters.AddWithValue("@statusSiap", "false");
                    cmd.Parameters.AddWithValue("@statusDevelope", "false");
                    int check = cmd.ExecuteNonQuery();
                    if (check > 0)
                    {
                        MessageBox.Show("Berhasil");
                        tampilCombo();
                        cbProduk.SelectedIndex = 0;
                        tampilData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something error : " + ex.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = connect.GetConnection();
                con.Open();
                string product = cbProduk.SelectedItem.ToString();
                SqlCommand cmd = new SqlCommand($"select * from Product where nama_product = '{product}'", con);
                string idProduct = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand("update Content set id_product = @product, jenis_content = @jenis where id_content = @id", con);
                cmd.Parameters.AddWithValue("@product", idProduct);
                cmd.Parameters.AddWithValue("@jenis", tbJenisKonten.Text);
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

        private void dgvContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvContent.Rows[e.RowIndex];
                tbJenisKonten.Text = row.Cells["Jenis Konten"].Value.ToString();
                cbProduk.SelectedItem = row.Cells["Nama Product"].Value.ToString();
                id = row.Cells["ID"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something error : " + ex.Message);
            }
        }

        private void ContentForm_Load(object sender, EventArgs e)
        {
            tampilCombo();
            cbProduk.SelectedIndex = 0;
            tampilData();
            label2.Text = DateTime.Now.ToLongDateString();

            if (role.Equals("producer"))
            {
                groupBox3.Enabled = false;
            }
            else if (role.Equals("developer"))
            {
                groupBox2.Enabled = false;
            }
            tbPlanning.Text = "0";
            tbDevelopment.Text = "0";
            tbDesign.Text = "0";
        }
        void tampilCombo()
        {
            SqlConnection con = connect.GetConnection();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter($"select id_campaign as 'ID',Product.nama_product as 'Nama Product',Login.username as 'Producer' from Campaign join Product on Campaign.id_product = Product.id_product join Login on Campaign.id_producer = Login.id_login where Login.Username = '{name}'", con);
            DataTable table = new DataTable();
            adapter.Fill(table);

            cbProduk.Items.Add("Pilih Product");
            foreach (DataRow row in table.Rows)
            {
                cbProduk.Items.Add(row[1].ToString());
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = connect.GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Content where id_content = @id", con);
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

        private void btnMinPlanning_Click(object sender, EventArgs e)
        {
            if(Int32.Parse(tbPlanning.Text) > 0)
            {
                tbPlanning.Text = Convert.ToString(Int32.Parse(tbPlanning.Text) - 5);
            }
        }

        private void btnPlanning_Click(object sender, EventArgs e)
        {
            if(Int32.Parse(tbPlanning.Text) < 100)
            {
                tbPlanning.Text = Convert.ToString(Int32.Parse(tbPlanning.Text) + 5);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = connect.GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from ProgresPembuatan where id_content = @id", con);
                cmd.Parameters.AddWithValue("@id", idProgres);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count>0)
                {
                    cmd = new SqlCommand("update ProgresPembuatan set planning = @plan,design = @design,development = @dev,deskripsi_content = @deskripsi,tanggal_laporan = @tanggal where id_content = @id", con);
                    cmd.Parameters.AddWithValue("@plan",tbPlanning.Text);
                    cmd.Parameters.AddWithValue("@design",tbDesign.Text);
                    cmd.Parameters.AddWithValue("@dev",tbDevelopment.Text);
                    cmd.Parameters.AddWithValue("@tanggal", DateTime.Now.ToLongDateString());
                    cmd.Parameters.AddWithValue("@deskripsi", tbDeskripsi.Text);
                    cmd.Parameters.AddWithValue("@id", idProgres);
                    
                } else
                {
                    cmd = new SqlCommand("insert into ProgresPembuatan (id_content,planning,design,development,tanggal_laporan,deskripsi_content) values (@id,@plan,@design,@dev,@tanggal,@deskripsi)", con);
                    cmd.Parameters.AddWithValue("@id", idProgres);
                    cmd.Parameters.AddWithValue("@plan", tbPlanning.Text);
                    cmd.Parameters.AddWithValue("@design", tbDesign.Text);
                    cmd.Parameters.AddWithValue("@dev", tbDevelopment.Text);
                    cmd.Parameters.AddWithValue("@tanggal", DateTime.Now.ToLongDateString());
                    cmd.Parameters.AddWithValue("@deskripsi", tbDeskripsi.Text);
                    
                }
                int check = cmd.ExecuteNonQuery();
                if (check > 0)
                {
                    if (tbPlanning.Text.Equals("100") && tbDesign.Text.Equals("100") && tbDevelopment.Text.Equals("100"))
                    {
                        cmd = new SqlCommand("update Content set status_siap = 'true' where id_content = @id", con);
                        cmd.Parameters.AddWithValue("@id", idProgres);
                        int check2 = cmd.ExecuteNonQuery();
                        if (check2 > 0)
                        {
                            MessageBox.Show("Berhasil di simpan");
                            tampilData();
                        }
                    } else
                    {
                        MessageBox.Show("Berhasil di simpan");
                        tampilData();
                    }
                }
            
                else
                {
                    MessageBox.Show("Gagal di simpan");
                    tampilData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something error : " + ex.ToString());
            }
        }

        private void btnMinDesign_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(tbDesign.Text) > 0)
            {
                tbDesign.Text = Convert.ToString(Int32.Parse(tbDesign.Text) - 5);
            }
        }

        private void btnPlusDesign_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(tbDesign.Text) < 100)
            {
                tbDesign.Text = Convert.ToString(Int32.Parse(tbDesign.Text) + 5);
            }
        }

        private void btnPlusDevelopment_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(tbDevelopment.Text) < 100)
            {
                tbDevelopment.Text = Convert.ToString(Int32.Parse(tbDevelopment.Text) + 5);
            }
        }

        private void btnMinDevelopment_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(tbDevelopment.Text) > 0)
            {
                tbDevelopment.Text = Convert.ToString(Int32.Parse(tbDevelopment.Text) - 5);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApprovalForm ap = new ApprovalForm();
            ap.Show();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProgresContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvProgresContent.Rows[e.RowIndex];
                if (!row.Cells["Planning"].Value.ToString().Equals("") || !row.Cells["Design"].Value.ToString().Equals("")|| !row.Cells["Development"].Value.ToString().Equals(""))
                {
                    tbDesign.Text = row.Cells["Design"].Value.ToString();
                    tbDevelopment.Text = row.Cells["Development"].Value.ToString();
                    tbPlanning.Text = row.Cells["Planning"].Value.ToString();
                    tbDeskripsi.Text = row.Cells["Deskripsi"].Value.ToString();
                    idProgres = row.Cells["ID"].Value.ToString();
                } else
                {
                    idProgres = row.Cells["ID"].Value.ToString();
                    tbPlanning.Text = "0";
                    tbDevelopment.Text = "0";
                    tbDesign.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something error : " + ex.Message);
            }
        }

        private void btnProgres_Click(object sender, EventArgs e)
        {
            DiagramForm diagramForm = new DiagramForm();
            diagramForm.Show();
        }

        void tampilData()
        {
            try
            {
                SqlConnection con = connect.GetConnection();
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select id_content as 'ID', nama_product as 'Nama Product',jenis_content as 'Jenis Konten' from Content join Product on Content.id_product = Product.id_product", con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvContent.DataSource = table;

                adapter = new SqlDataAdapter("select Content.id_content as 'ID',jenis_content as 'Jenis Konten',planning as 'Planning',design as 'Design', development as 'Development', tanggal_laporan as 'Tanggal Laporan',deskripsi_content as 'Deskripsi' from Content left join ProgresPembuatan on Content.id_content = ProgresPembuatan.id_content;", con);
                table = new DataTable();
                adapter.Fill(table);
                dgvProgresContent.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something error : " + ex.Message);
            }
        }
    }
}
