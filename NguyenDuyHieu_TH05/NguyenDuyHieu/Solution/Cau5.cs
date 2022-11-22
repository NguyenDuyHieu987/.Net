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
    public partial class Cau5 : Form
    {
        SqlConnection conn;
        SqlDataAdapter DA;
        DataSet DS;
        Connect connect = new Connect();
        public Cau5()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {

            try
            {
                conn = connect.Connect_PMStore();
                conn.Close();
                DA = new SqlDataAdapter("SELECT * FROM SanPham WHERE NgayHetHan < GETDATE() OR SoLuongTon = 0", conn);
                DS = new DataSet();
                DA.Fill(DS, "SanPham");

                dataGridViewThongTin_Hethan.DataSource = DS.Tables["SanPham"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cau5_Load(object sender, EventArgs e)
        {
            try
            {
                conn = connect.Connect_PMStore();
                conn.Close();
                DA = new SqlDataAdapter($"SELECT * FROM SanPham", conn);
                DS = new DataSet();
                DA.Fill(DS, "SanPham");

                dataGridViewThongTin_Hethan.DataSource = DS.Tables["SanPham"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Cau5_Load(sender, e);
        }
    }
}
