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
    public partial class Cau8 : Form
    {
        SqlCommand cmd;
        SqlDataAdapter DA;
        DataSet DS;
        SqlConnection conn;
        private Connect connect = new Connect();
        public Cau8()
        {
            InitializeComponent();
        }

        private void Cau8_Load(object sender, EventArgs e)
        {
            try
            {
                conn = connect.Connect_SimThe();
                conn.Close();
                DA = new SqlDataAdapter($"SELECT Sim.*, TenMang FROM Sim, Mang WHERE Sim.MangID = Mang.ID", conn);
                DS = new DataSet();
                DA.Fill(DS, "SanPham");

                dataGridView1.DataSource = DS.Tables["SanPham"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                conn = connect.Connect_SimThe();
                conn.Close();
                
                DA = new SqlDataAdapter($"SELECT Sim.ID, NgayHetHan FROM Sim, Mang WHERE Sim.MangID = Mang.ID AND SoSim = '{txtSoSim.Text}'", conn);
                DS = new DataSet();
                DA.Fill(DS, "SanPham");

                dataGridView1.DataSource = DS.Tables["SanPham"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlamMoi_Click(object sender, EventArgs e)
        {
            Cau8_Load(sender, e);
        }
    }
}
