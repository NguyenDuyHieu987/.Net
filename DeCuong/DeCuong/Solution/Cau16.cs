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
    public partial class Cau16 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter DA;
        DataSet DS;

        public Cau16()
        {
            InitializeComponent();
        }

        private void Connect()
        {
            try
            {
                string con_str = "Server = DESKTOP-ISH3HH8\\SQLEXPRESS; Database = PMStore_Train; Integrated Security = SSPI";
                conn = new SqlConnection(con_str);
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Cau16_Load(object sender, EventArgs e)
        {
            ActiveControl = txtMaSP;
            try
            {
                Connect();
                conn.Close();

                DA = new SqlDataAdapter("SELECT * FROM SanPham", conn);
                DS = new DataSet();
                DA.Fill(DS, "SanPham");

                dataGridView1.DataSource = DS.Tables["SanPham"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
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
                cmd.CommandText = $"INSERT INTO SanPham(MaSP, TenSP, SoLuongTon, NgaySanXuat, NgayHetHan, NhaCungCap)VALUES " +
                    $"('{txtMaSP.Text}', N'{txtTenSP.Text}', {txtSLT.Text}, '{maskedTextBoxNSX.Text}', '{maskedTextBoxNHH.Text}', N'{txtNCC.Text}')";

                int check = cmd.ExecuteNonQuery();
                conn.Close();

                if(check == 1)
                {
                    MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cau16_Load(sender, e);
                }
                else
                    MessageBox.Show("Thêm mới thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
