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
    public partial class MayBay : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter DA;
        DataSet DS;
        public MayBay()
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

        private bool KiemTra_MaHangSX(string MaHangSX)
        {
            foreach (char c in MaHangSX)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
  
                if (!KiemTra_MaHangSX(txtMaHangSX.Text) || txtMaHangSX.Text == "")
                {
                    MessageBox.Show("Mã hãng không được rỗng và chỉ được là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (DS.Tables["HangSanXuat"].Rows.Count > 0)
                    {
                        DA = new SqlDataAdapter($"SELECT * FROM HangSanXuat WHERE MaHangSanXuat = {txtMaHangSX.Text}", conn);
                        DS = new DataSet();
                        DA.Fill(DS, "HangSanXuat");
                        dataGridView1.DataSource = DS.Tables["HangSanXuat"];
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã hãng sản xuất " + txtMaHangSX.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MayBay_Load(object sender, EventArgs e)
        {
            try
            {
                txtMaMB.Select();
                Connect();
                conn.Close();

                DA = new SqlDataAdapter($"SELECT * FROM HangSanXuat", conn);
                DS = new DataSet();
                DA.Fill(DS, "HangSanXuat");

                dataGridView1.DataSource = DS.Tables["HangSanXuat"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
