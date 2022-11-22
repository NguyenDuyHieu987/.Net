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
    public partial class Cau4 : Form
    {
        SqlConnection conn;
        SqlDataAdapter DA;
        DataSet DS;
        private Connect connect = new Connect();
        public Cau4()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                conn = connect.Connect_HoaHong();
                conn.Close();
                string MaLop = txtMaLop_BN.Text;
                DA = new SqlDataAdapter($"SELECT TenLop, BeNgoan.* FROM BeNgoan, LopHoc " +
                    $"WHERE BeNgoan.MaLop = LopHoc.MaLop AND BeNgoan.MaLop = '{MaLop}'", conn);
                DS = new DataSet();
                DA.Fill(DS, "BeNgoan");

                dataGridViewThongTin.DataSource = DS.Tables["BeNgoan"];

              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Cau4_Load(sender, e);
        }

        private void Cau4_Load(object sender, EventArgs e)
        {
            try
            {
                conn = connect.Connect_HoaHong();
                conn.Close();
                string MaLop = txtMaLop_BN.Text;
                DA = new SqlDataAdapter($"SELECT TenLop, BeNgoan.* FROM BeNgoan, LopHoc " +
                    $"WHERE BeNgoan.MaLop = LopHoc.MaLop", conn);
                DS = new DataSet();
                DA.Fill(DS, "BeNgoan");

                dataGridViewThongTin.DataSource = DS.Tables["BeNgoan"];


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
