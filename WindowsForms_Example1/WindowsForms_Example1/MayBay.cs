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

namespace WindowsForms_Example1
{
    public partial class MayBay : Form
    {
        SqlConnection conn;
        SqlDataAdapter DA;
        SqlCommand cmd;
        DataSet DS;
        public MayBay()
        {
            InitializeComponent();
        }

        private void Connect()
        {
            try
            {
                string con_str = "Server = DESKTOP-ISH3HH8\\SQLEXPRESS; Database = SanBay_Train; Integrated Security = SSPI";
                conn = new SqlConnection(con_str);
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MayBay_Load(object sender, EventArgs e)
        {
            txtMaMB.Select();
            try
            {
                Connect();
                conn.Close();

                DA = new SqlDataAdapter($"SELECT * FROM MayBay WHERE KhuVucDo = 'Khu B'", conn);
                DS = new DataSet();
                DA.Fill(DS, "MayBay");

                dataGridView1.DataSource = DS.Tables["Maybay"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool KT_MaMB(string MaMB)
        {
            foreach(char c in MaMB)
            { 
                if(!Char.IsDigit(c))
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
                Connect();
                conn.Close();

                DA = new SqlDataAdapter($"SELECT * FROM MayBay WHERE HangSanXuat = '{txthangSX.Text}'", conn);
                DS = new DataSet();
                DA.Fill(DS, "MayBay");

                if(DS.Tables["MayBay"].Rows.Count > 0)
                {

                    dataGridView1.DataSource = DS.Tables["Maybay"];
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy máy bay nào có hãng " + txthangSX.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!KT_MaMB(txtMaMB.Text) || txtMaMB.Text == "")
                {
                    MessageBox.Show("Mã máy bay chỉ được nhập số và không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaMB.Focus();
                }
                else
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
