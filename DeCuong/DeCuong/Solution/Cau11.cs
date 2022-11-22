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
    public partial class Cau11 : Form
    {
        SqlConnection conn;
        DataSet DS;
        SqlDataAdapter DA;
        SqlCommand cmd;

        public void Connect()
        {
            try
            {
                string conn_str = "Server = DESKTOP-ISH3HH8\\SQLEXPRESS; Database = HoaHong_Train; Integrated Security = SSPI";
                conn = new SqlConnection(conn_str);
                conn.Open();
            }
            catch(Exception ex)
            {
                conn.Close();
                throw new Exception(ex.Message);
            }
        }
        public Cau11()
        {
            InitializeComponent();
        }

        private void Cau11_Load(object sender, EventArgs e)
        {
            Connect();
            conn.Close();
            DA = new SqlDataAdapter("SELECT * FROM BeNgoan", conn);
            DS = new DataSet();
            DA.Fill(DS, "BeNgoan");

            dataGridView1.DataSource = DS.Tables["BeNgoan"];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Connect();

            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"UPDATE BeNgoan SET MaLop = '{comboBox1.SelectedItem}' WHERE MaBN = '{txtMaBN.Text}'";

            int check = cmd.ExecuteNonQuery();
            conn.Close();
            if(check == 1)
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cau11_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
