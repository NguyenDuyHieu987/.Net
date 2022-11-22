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
    public partial class Cau3 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter DA;
        DataSet DS;

        public Cau3()
        {
            InitializeComponent();
        }

        private void Connect()
        {
            try
            {
                string con_str = "Server = DESKTOP-ISH3HH8\\SQLEXPRESS; Database = DieuTraDS_Train; Integrated Security = SSPI";
                conn = new SqlConnection(con_str);
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Connect();

                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"INSERT INTO CongDan(MaCD, MaPhuong, TenCD, CMND, GioiTinh, NgaySinh, SDT)VALUES " +
                    $"('{txtMaCD.Text}', '{txtMaPhuong.Text}', N'{txtTenCD.Text}', {txtCMND.Text}, N'{comboBoxGT.SelectedItem}', '{maskedTextBoxNS.Text}', {txtSDT.Text})";

                int check = cmd.ExecuteNonQuery();
                if(check == 1)
                {
                    MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cau3_Load(sender, e);
                }
                else
                    MessageBox.Show("Thêm mới thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cau3_Load(object sender, EventArgs e)
        {
            try
            {
                Connect();
                conn.Close();

                DA = new SqlDataAdapter("SELECT * FROM CongDan", conn);
                DS = new DataSet();
                DA.Fill(DS, "CongDan");

                dataGridView1.DataSource = DS.Tables["CongDan"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
