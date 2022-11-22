using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NguyenDuyHieu.Solution
{
    public partial class Cau6 : Form
    {
        SqlConnection conn;
        SqlDataAdapter DA;
        DataSet DS;
        Connect connect = new Connect();
        public Cau6()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                conn = connect.Connect_PMStore();
                conn.Close();
                DA = new SqlDataAdapter($"SELECT * FROM SanPham WHERE NhaCungCap = '{txtNCC.Text}'", conn);
                DS = new DataSet();
                DA.Fill(DS, "SanPham");

                dataGridViewThongTin_NCC.DataSource = DS.Tables["SanPham"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cau6_Load(object sender, EventArgs e)
        {
            try
            {
                conn = connect.Connect_PMStore();
                conn.Close();
                DA = new SqlDataAdapter($"SELECT * FROM SanPham", conn);
                DS = new DataSet();
                DA.Fill(DS, "SanPham");

                dataGridViewThongTin_NCC.DataSource = DS.Tables["SanPham"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Cau6_Load(sender, e);
        }
    }
}
