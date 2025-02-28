using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatformImpact2
{
    public partial class ApprovalForm : Form
    {
        koneksi connect = new koneksi();
        string id;
        public ApprovalForm()
        {
            InitializeComponent();
        }

        private void ApprovalForm_Load(object sender, EventArgs e)
        {
            tampilData();
            
        }
        void tampilData()
        {
            SqlConnection con = connect.GetConnection();
            con.Open(); 
            SqlDataAdapter adapter = new SqlDataAdapter("select Content.id_content as 'ID',jenis_content as 'Jenis Content', nama_product as 'Nama Product',planning as 'Planning',design as 'Design',development as 'Development',tanggal_laporan as 'Tanggal Laporan' from Content join Product on Content.id_product = Product.id_product join ProgresPembuatan on Content.id_content = ProgresPembuatan.id_content where status_siap = 'true' and status_develope = 'false'", con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            adapter = new SqlDataAdapter("select * from Platform", con);
            table = new DataTable();
            adapter.Fill(table);
            comboBox1.Items.Add("Pilih Platform");
            foreach(DataRow row in table.Rows)
            {
                comboBox1.Items.Add(row[1].ToString());
            }
            comboBox1.SelectedIndex = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            label1.Text = row.Cells["Jenis Content"].Value.ToString();
            label2.Text = row.Cells["Nama Product"].Value.ToString();
            label3.Text = row.Cells["Planning"].Value.ToString();
            label4.Text = row.Cells["Design"].Value.ToString();
            label5.Text = row.Cells["Development"].Value.ToString();
            label6.Text = row.Cells["Tanggal Laporan"].Value.ToString();
            id = row.Cells["ID"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Anda yakin content ini ingin di publish?","Konfirmasi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                SqlConnection con = connect.GetConnection();
                con.Open();
                string platform = comboBox1.SelectedItem.ToString();
                SqlCommand cmd = new SqlCommand($"select id_platform from Platform where nama_platform = '{platform}'", con);
                string idPlatform = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand("update Content set status_develope = @status,id_platform = @platform where id_content = @id", con);
                cmd.Parameters.AddWithValue("@status", "true");
                cmd.Parameters.AddWithValue("@platform", idPlatform);
                cmd.Parameters.AddWithValue("@id", id);
                int check = cmd.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Berhasil mempublish content");
                    tampilData();
                }
                else
                {
                    MessageBox.Show("Gagal mempublish content");
                    tampilData();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
