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
    public partial class Cau21 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter DA;
        DataSet DS;
        public Cau21()
        {
            InitializeComponent();
        }

        private void Connect()
        {
            try
            {
                string con_str = "Server = MSI\\SQLEXPRESS; Database = SimThe_Train; Integrated Security = SSPI";
                conn = new SqlConnection(con_str);
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool KT_SoSim(string SoSim)
        {
            foreach(char c in SoSim)
            {
                if(!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void KT_IDSim_IDMang()
        {
            if(txtIDSim.Text == "" || txtIDMang.Text == "")
            {
                MessageBox.Show("ID Sim và ID Mạng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cau21_Load(object sender, EventArgs e)
        {
            try
            {
                txtIDSim.Select();
                Connect();
                conn.Close();

                DA = new SqlDataAdapter("SELECT Sim.*, Mang.TenMang FROM Sim, Mang WHERE Sim.MangID = Mang.ID", conn);
                DS = new DataSet();
                DA.Fill(DS, "Sim");

                dataGridView1.DataSource = DS.Tables["Sim"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
                Connect();
                KT_IDSim_IDMang();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"INSERT INTO Sim(ID, SoSim, MangID, NgayKichHoat, NgayHetHan)VALUES " +
                    $"('{txtIDSim.Text}', {txtSoSim.Text}, '{txtIDMang.Text}','{txtNKH.Text}', '{txtNHH.Text}')";
                
                
                if (!KT_SoSim(txtSoSim.Text) || txtSoSim.Text.Length != 10 )
                {
                    MessageBox.Show("Số sim phải có độ dài là 10 ký tự và chỉ là kí tự số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoSim.Focus();
                }
                else
                {
                    int check = cmd.ExecuteNonQuery();
                    
                    if(check == 1)
                    {
                        MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cau21_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Thêm mới thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close(); 
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                Connect();
                conn.Close();
                DA = new SqlDataAdapter($"SELECT * FROM Sim WHERE SoSim = {txtSoSim.Text}", conn);
                DS = new DataSet();
                DA.Fill(DS, "Sim");

                if(DS.Tables["Sim"].Rows.Count > 0)
                {
                    dataGridView1.DataSource = DS.Tables["Sim"];
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sim có số " + txtSoSim.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
