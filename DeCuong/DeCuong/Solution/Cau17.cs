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
    public partial class Cau17 : Form
    {
        SqlConnection conn;
        SqlDataAdapter DA;
        DataSet DS;
        SqlCommand cmd;
        public Cau17()
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
                throw new Exception(ex.Message);
            }
        }
        private void Cau17_Load(object sender, EventArgs e)
        {
            try
            {
                Connect();
                conn.Close();
                DA = new SqlDataAdapter("SELECT * FROM SanPham", conn);
                DS = new DataSet();
                SqlCommandBuilder builder = new SqlCommandBuilder(DA);
                DA.Fill(DS, "SanPham");
                DS.Tables["SanPham"].PrimaryKey = new DataColumn[] {DS.Tables["SanPham"].Columns["MaSP"] };

                dataGridView1.DataSource = DS.Tables["SanPham"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Connect();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"UPDATE SanPham SET NhaCungCap = N'{txtNCC.Text}' WHERE MaSP = '{txtMaSP.Text}'";

                int check = cmd.ExecuteNonQuery();
                if(check == 1)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cau17_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
