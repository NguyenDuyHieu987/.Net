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

namespace NguyenDuyHieu_D15CNPM2
{
    public partial class HangSanXuat : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter DA;
        DataSet DS;
        public HangSanXuat()
        {
            InitializeComponent();
        }
        private void Connect()
        {
            try
            {
                string con_str = "Server = DESKTOP-ISH3HH8\\SQLEXPRESS; Database = SanBay; Integrated Security = SSPI";
                conn = new SqlConnection(con_str);
                conn.Open();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HangSanXuat_Load(object sender, EventArgs e)
        {
            try
            {
                txtMaHangSX.Select();
                Connect();
                conn.Close();

                DA = new SqlDataAdapter($"SELECT * FROM HangSanXuat WHERE MaHangSanXuat = '01'", conn);
                DS = new DataSet();
                DA.Fill(DS, "HangSanXuat");

                dataGridView1.DataSource = DS.Tables["HangSanXuat"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
