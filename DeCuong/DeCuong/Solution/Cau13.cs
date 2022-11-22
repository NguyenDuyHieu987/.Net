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
    public partial class Cau13 : Form
    {
        SqlConnection conn;
        SqlDataAdapter DA;
        DataSet DS;
        public Cau13()
        {
            InitializeComponent();
        }

        private void Connect()
        {
            string con_str = "Server = DESKTOP-ISH3HH8\\SQLEXPRESS; Database = PMStore; Integrated Security = SSPI";
            conn = new SqlConnection(con_str);
            conn.Open();
        }
        private void BTNSapXep_Click(object sender, EventArgs e)
        {
            try
            {
                Connect();
                conn.Close();

                DA = new SqlDataAdapter("SELECT * FROM SanPham ORDER BY SoLuongTon ASC", conn);
                DS = new DataSet();
                DA.Fill(DS, "SanPham");

                dataGridView1.DataSource = DS.Tables["SanPham"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cau13_Load(object sender, EventArgs e)
        {
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
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Cau13_Load(sender, e);
        }
    }
}
