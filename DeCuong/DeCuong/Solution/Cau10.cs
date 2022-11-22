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

namespace DeCuong.Solution
{
    public partial class Cau10 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter DA;
        DataSet DS;
        public Cau10()
        {
            InitializeComponent();
        }

        private void Connect()
        {
            try
            {
                string con_str = "Server = DESKTOP-ISH3HH8\\SQLEXPRESS; Database = HoaHong_Train; Integrated Security = SSPI";
                conn = new SqlConnection(con_str);
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Connect();

                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"INSERT INTO BeNgoan(MaBN, MaLop, TenBN, NgaySinh, GioiTinh, HoTenBo, HoTenMe, DiaChi)VALUES " +
                    $"('{txtMaBN.Text}', '{txtMaLop.Text}', N'{txtTenBN.Text}', '{maskedTextBoxNS.Text}', N'{comboBoxGT.SelectedItem}', N'{txtHoTenBo.Text}', N'{txtHoTenMe.Text}', N'{txtDiaChi.Text}')";

                int check = cmd.ExecuteNonQuery();
                conn.Close();

                if(check == 1)
                {
                    MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cau10_Load(sender, e);
                }
                else
                    MessageBox.Show("Thêm mới thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Cau10_Load(object sender, EventArgs e)
        {
            try
            {
                Connect();
                conn.Close();

                DA = new SqlDataAdapter("SELECT BeNgoan.*, LopHoc.TenLop FROM BeNgoan, LopHoc WHERE BeNgoan.MaLop = LopHoc.MaLop", conn);
                DS = new DataSet();
                DA.Fill(DS, "BeNgoan");

                dataGridView1.DataSource = DS.Tables["BeNgoan"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
