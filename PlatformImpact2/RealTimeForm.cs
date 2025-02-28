using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatformImpact2
{
    public partial class RealTimeForm : Form
    {
        koneksi connect = new koneksi();
        string id;
        public RealTimeForm()
        {
            InitializeComponent();
        }

        private void RealTimeForm_Load(object sender, EventArgs e)
        {
            tampilData();
            tampilCombo();
        }
        void tampilData()
        {
            SqlConnection con = connect.GetConnection();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select Content.id_content as 'ID',id_analisis as 'ID Analisis',jenis_content as 'Jenis Content',nama_platform as 'Nama Platform',discover as 'Discovery',folows as 'Follows',reach as 'Reach',impressions as 'Impressions',from_hashtag  'Hastag',from_home as 'Home',from_explore as 'Explorer',from_other as 'Other' from Content left join Analisis on Content.id_content = Analisis.id_content left join Platform on Content.id_platform = Platform.id_platform where status_develope = 'true' and status_siap = 'true'", con);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }
        void tampilCombo()
        {
            SqlConnection con = connect.GetConnection();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Content where status_siap = 'true' and status_develope = 'true'", con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox1.Items.Add("Pilih Content");
            foreach(DataRow row in table.Rows)
            {
                comboBox1.Items.Add(row[2].ToString());
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = connect.GetConnection();
                con.Open();
                string content = comboBox1.SelectedItem.ToString();
                SqlCommand cmd = new SqlCommand($"select id_content from Content where jenis_content = '{content}'", con);
                string idContent = cmd.ExecuteScalar().ToString();
                if (!id.ToString().Equals(""))
                {
                    cmd = new SqlCommand("update Analisis set discover = @discov,folows = @folow,reach = @reach,impressions = @impres,from_hashtag = @hastag, from_home = @home,from_explore = @explorer, from_other = @other, id_content = @content where id_analisis = @analisis", con);
                    cmd.Parameters.AddWithValue("@discov", textBox1.Text);
                    cmd.Parameters.AddWithValue("@folow", textBox2.Text);
                    cmd.Parameters.AddWithValue("@reach", textBox3.Text);
                    cmd.Parameters.AddWithValue("@impres", textBox4.Text);
                    cmd.Parameters.AddWithValue("@hastag", textBox5.Text);
                    cmd.Parameters.AddWithValue("@home", textBox6.Text);
                    cmd.Parameters.AddWithValue("@explorer", textBox7.Text);
                    cmd.Parameters.AddWithValue("@other", textBox8.Text);
                    cmd.Parameters.AddWithValue("@content", idContent);
                    cmd.Parameters.AddWithValue("@analisis", id);
                    /*MessageBox.Show("Hai");*/
                }
                else
                {
                    cmd = new SqlCommand("insert into Analisis (discover,folows,reach,impressions,from_hashtag,from_home,from_explore,from_other,id_content) values (@discov,@folow,@reach,@impres,@hastag,@home,@explorer,@other,@content)", con);
                    cmd.Parameters.AddWithValue("@discov", textBox1.Text);
                    cmd.Parameters.AddWithValue("@folow", textBox2.Text);
                    cmd.Parameters.AddWithValue("@reach", textBox3.Text);
                    cmd.Parameters.AddWithValue("@impres", textBox4.Text);
                    cmd.Parameters.AddWithValue("@hastag", textBox5.Text);
                    cmd.Parameters.AddWithValue("@home", textBox6.Text);
                    cmd.Parameters.AddWithValue("@explorer", textBox7.Text);
                    cmd.Parameters.AddWithValue("@other", textBox8.Text);
                    cmd.Parameters.AddWithValue("@content", idContent);
                }

                int check = cmd.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Berhasil menambahkan data");
                    tampilData();
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan data");
                    tampilData();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Somethinh error : " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells["Discovery"].Value.ToString();
            textBox2.Text = row.Cells["Follows"].Value.ToString();
            textBox3.Text = row.Cells["Reach"].Value.ToString();
            textBox4.Text = row.Cells["Impressions"].Value.ToString();
            textBox5.Text = row.Cells["Hastag"].Value.ToString();
            textBox6.Text = row.Cells["Home"].Value.ToString();
            textBox7.Text = row.Cells["Explorer"].Value.ToString();
            textBox8.Text = row.Cells["Other"].Value.ToString();

            comboBox1.SelectedItem = row.Cells["Jenis Content"].Value.ToString();

            id = row.Cells["ID Analisis"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refresh();
        }
        void refresh()
        {

        }
    }
}
