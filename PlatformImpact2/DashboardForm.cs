using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ActivationContext;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace PlatformImpact2
{
    public partial class DashboardForm : Form
    {
        string name,idContent;
        string role;
        koneksi connect = new koneksi();
        public DashboardForm(string nama,string role)
        {
            InitializeComponent();
            this.name = nama;
            this.role = role;
        }

        private void smPlatform_Click(object sender, EventArgs e)
        {
            PlatformForm PF = new PlatformForm();
            PF.Show();
        }

        private void smKontenProject_Click(object sender, EventArgs e)
        {
            ContentForm CF = new ContentForm(name, role);
            CF.Show();
        }

        private void smProduct_Click(object sender, EventArgs e)
        {
            ProductForm PF = new ProductForm(role);
            PF.Show();
        }

        private void smCampaign_Click(object sender, EventArgs e)
        {
            CampaignForm CF = new CampaignForm(role);
            CF.Show();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            if (role.Equals("admin"))
            {
                smKontenProject.Enabled = false;
                smAddProducer.Enabled = false;
                btnTakedown.Enabled = false;
            }
            else if (role.Equals("producer"))
            {
                smProduct.Enabled = false;
                smAddProducer.Enabled = false;
            }
            else if (role.Equals("manager"))
            {
                smKontenProject.Enabled = false;
                smPlatform.Enabled = false;
                smProduct.Enabled = false;
                btnTakedown.Enabled = false;
            } else if (role.Equals("developer"))
            {
                smPlatform.Enabled = false;
                smProduct.Enabled = false;
                smAddProducer.Enabled=false;
                btnTakedown.Enabled=false;
            }
            tampilData();
        }
        void tampilData()
        {
            try
            {
                SqlConnection con = connect.GetConnection();
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select Content.id_content as 'ID',nama_platform as 'Platform',nama_product as 'Product',discover as 'Discovery',folows as 'Follows',reach as 'Reach',impressions as 'Impressions',from_hashtag as 'Hastag',from_home as 'From Home',from_explore as 'From Explorer', from_other as 'From Other' from Analisis left join Content on Content.id_content = Analisis.id_content left join Platform on Content.id_platform = Platform.id_platform left join Product on Content.id_product = Product.id_product where status_siap = 'true' AND status_develope = 'true'", con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something error : " + ex.Message);
            }
        }

        private void smAddProducer_Click(object sender, EventArgs e)
        {
            AddProducerFrom addProducerFrom = new AddProducerFrom(role);
            addProducerFrom.Show();
        }

        private void btnTakedown_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = connect.GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Analisis where id_content = @idContent", con);
                cmd.Parameters.AddWithValue("@idContent", idContent);
                int check = cmd.ExecuteNonQuery();
                if (check > 0)
                {
                    cmd = new SqlCommand("delete from Content where id_content = @id", con);
                    cmd.Parameters.AddWithValue("@id", idContent);
                    int check2 = cmd.ExecuteNonQuery();
                    if (check2 > 0)
                    {
                        MessageBox.Show("Berhasil men Takedown Content");
                        tampilData();
                    } else
                    {
                        MessageBox.Show("hai1");
                        tampilData();
                    }
                } else
                {
                    MessageBox.Show("hai2");
                    tampilData();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Something error : " + ex.Message);
            }
        }

        private void msLogout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tampilData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            idContent = row.Cells["ID"].Value.ToString();
        }
    }
}
