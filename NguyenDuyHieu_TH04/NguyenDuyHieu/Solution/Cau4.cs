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
        SqlCommand cmd;
        SqlDataReader reader;
        private string svName = "DESKTOP-ISH3HH8\\SQLEXPRESS";
        private string dbName = "DieuTraDS_TH04";
        private string Security = "SSPI";
        public Cau4()
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                connect();
                string MaCD = txtMaCD.Text;


                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"DELETE FROM CongDan WHERE MaCD = '{MaCD}'";
                int sl = cmd.ExecuteNonQuery();
                if (sl == 1)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                    MessageBox.Show("Không có công dân phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }
    }
}
