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
        SqlCommand cmd;
        SqlDataReader reader;
        private string svName = "DESKTOP-ISH3HH8\\SQLEXPRESS";
        private string dbName = "HoaHong_TH04";
        private string Security = "SSPI";
        public Cau6()
        {
            InitializeComponent();
        }
        private void connect()
        {
            try
            {
                string con_str = $"Data Source = {svName}; Initial Catalog = {dbName}; Integrated Security = {Security}";
                conn = new SqlConnection(con_str);
                conn.Open();
            }
            catch (Exception ex)
            {
                conn.Close();
                throw new Exception(ex.Message);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                connect();
                string MaBN = txtMaBN.Text;
                string MaLop = txtMapLop_BN.Text;
                string TenBN = txtTenBN.Text;
                string NgaySinh = maskedtxtDate.Text;
                string GioiTinh = cbGioiTinh.SelectedItem.ToString();
                string HoTenBo = txtHoTenBo.Text;
                string HoTenMe = txtHoTenMe.Text;
                string DiaChi = txtDiaChi.Text;

                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"INSERT INTO BeNgoan (MaBN, MaLop, TenBeNgoan, NgaySinh, GioiTinh, HoTenBo, HoTenMe, DiaChi) VALUES" +
                                        $"('{MaBN}', '{MaLop}', '{TenBN}', '{NgaySinh}', '{GioiTinh}', '{HoTenBo}', '{HoTenMe}', '{DiaChi}')";
                int sl = cmd.ExecuteNonQuery();
                if (sl == 1)
                {
                    MessageBox.Show("Thêm mới thành công");
                }
                else
                    MessageBox.Show("Thêm mới thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }
    }
}
