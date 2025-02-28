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
    public partial class DiagramForm : Form
    {
        koneksi connect = new koneksi();
        public DiagramForm()
        {
            InitializeComponent();
        }

        private void DiagramForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = connect.GetConnection();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from ProgresPembuatan join Content on ProgresPembuatan.id_content = Content.id_content", con);
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach (DataRow dr in table.Rows)
            {
                chart1.Series[0].Points.AddXY(dr[9], dr[2]);
                chart1.Series[1].Points.AddXY(dr[9], dr[3]);
                chart1.Series[2].Points.AddXY(dr[9], dr[4]);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
