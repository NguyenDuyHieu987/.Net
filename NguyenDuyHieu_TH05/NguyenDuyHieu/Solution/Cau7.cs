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
    public partial class Cau7 : Form
    {
        SqlCommand cmd;
        SqlDataAdapter DA;
        DataSet DS;
        SqlConnection conn;
        private Connect connect = new Connect();
        public Cau7()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn = connect.Connect_PMStore();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM SanPham WHERE NgayHetHan < GETDATE() OR SoLuongTon = 0";
                int check = cmd.ExecuteNonQuery();
                conn.Close();
                if (check >= 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cau7_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cau7_Load(object sender, EventArgs e)
        {
            try
            {
                conn = connect.Connect_PMStore();
                conn.Close();
                DA = new SqlDataAdapter($"SELECT * FROM SanPham", conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(DA);
                DS = new DataSet();
                DA.Fill(DS, "SanPham");
                DS.Tables["SanPham"].PrimaryKey = new DataColumn[] { DS.Tables["SanPham"].Columns["MaSanPham"] };

                dataGridView1.DataSource = DS.Tables["SanPham"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
