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
    public partial class Cau20 : Form
    {
        SqlConnection conn;
        SqlDataAdapter DA;
        DataSet DS;
        public Cau20()
        {
            InitializeComponent();
        }

        private void Connect()
        {
            try
            {
                string con_str = "Server = DESKTOP-ISH3HH8\\SQLEXPRESS; Database = SimThe_Train; Integrated Security = SSPI";
                conn = new SqlConnection(con_str);
                conn.Open();
            }
            catch(Exception ex)
            {
                conn.Close();
                throw new Exception(ex.Message);
            }
        }


        private void btnhienThi_Click(object sender, EventArgs e)
        {
            try
            {
                Connect();
                conn.Close();
                DA = new SqlDataAdapter("SELECT * FROM Sim ORDER BY NgayKichHoat ASC", conn);
                DS = new DataSet();
                DA.Fill(DS, "Sim");

                dataGridView1.DataSource = DS.Tables["Sim"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cau20_Load(object sender, EventArgs e)
        {
            try
            {
                Connect();
                conn.Close();
                DA = new SqlDataAdapter("SELECT * FROM Sim", conn);
                DS = new DataSet();
                DA.Fill(DS, "Sim");

                dataGridView1.DataSource = DS.Tables["Sim"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlamMoi_Click(object sender, EventArgs e)
        {
            Cau20_Load(sender, e);
        }
    }
}
