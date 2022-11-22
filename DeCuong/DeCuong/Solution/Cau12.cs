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
    public partial class Cau12 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter DA;
        DataSet DS;
        public Cau12()
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
                conn.Close();
                throw new Exception(ex.Message);
            }
        }
        private void Cau12_Load(object sender, EventArgs e)
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
            cmd.CommandText = $"UPDATE BeNgoan SET TenBN = N'{txtTenBN.Text}' WHERE MaBN = '{txtMaBn.Text}'";

            int check = cmd.ExecuteNonQuery();
            if(check == 1)
            {
                MessageBox.Show("Sửa Thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cau12_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
