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
    public partial class DangNhap : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter DA;
        DataSet DS;
        public DangNhap()
        {
            InitializeComponent();
            txtMK.UseSystemPasswordChar = true;
            txtMK.Enabled = false;
            btnDangNhap.Enabled = false;
            checkBoxQuyenAdmin.Enabled = false;
        }

        private void Connect()
        {
            try
            {
                string con_str = "Server = DESKTOP-ISH3HH8\\SQLEXPRESS; Database = NguoiDUng_Train; Integrated Security = SSPI";
                conn = new SqlConnection(con_str);
                conn.Open();
            }
            catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        bool KiemTra_TK(string TK)
        {
            foreach (char c in TK)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        bool KT_TiengAnh_TK(string TK)
        {
            foreach (char c in TK)
            {
                foreach (char c1 in "ăĂâÂêÊơƠôÔ")
                {
                    if(c == c1)
                    {
                        return false;
                    }              
                }
            }
            return true;
        }

        bool KT_TiengAnh_MK(string MK)
        {
            foreach (char c in MK)
            {
                foreach (char c1 in "ăĂâÂêÊơƠôÔ")
                {
                    if (c == c1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        bool KiemTra_MK(string MK)
        {
            foreach(char c in MK)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                Connect();

                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"SELECT COUNT(*) FROM NguoiDung WHERE TaiKhoan = '{txtTK.Text}' AND MatKhau = '{txtMK.Text}'";
 
                bool isNumeric_TK = int.TryParse(txtTK.Text, out _);
                bool isNumeric_MK = int.TryParse(txtMK.Text, out _);
                if (isNumeric_TK || isNumeric_MK)
                {
                    MessageBox.Show("Tài khoản và mật khẩu không được chứa toàn số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!KiemTra_TK(txtTK.Text) || !KiemTra_MK(txtMK.Text) || !KT_TiengAnh_TK(txtTK.Text) || !KT_TiengAnh_MK(txtMK.Text))
                    {
                        MessageBox.Show("Tài khoản và mật khẩu không được chứa ký tự ngoài từ a->z, 0->9", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txtTK.Text.Length < 5 || txtMK.Text.Length < 5)
                        {
                            if (txtTK.Text == "" || txtMK.Text == "")
                            {
                                MessageBox.Show("Mật khẩu và mật khẩu không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("Tài khoản và mật khẩu phải ít nhất 5 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            int check = (int)cmd.ExecuteScalar();

                            if(check == 1 && checkBoxQuyenAdmin.Checked == true && Check_QuyenAdmin() == 1)
                            {
                                DA = new SqlDataAdapter("SELECT * FROM NguoiDung", conn);
                                DS = new DataSet();
                                DA.Fill(DS, "NguoiDung");

                                dataGridView1.DataSource = DS.Tables["NguoiDung"];
                                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                            }
                            else if(check == 1 && checkBoxQuyenAdmin.Checked == false)
                            {
                                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if(check == 0)
                            {
                                MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }      
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();


        }

        private void checkBoxMK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMK.Checked == true)
            {
                txtMK.UseSystemPasswordChar = false;
            }
            else
                txtMK.UseSystemPasswordChar = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            //if(txtTK.Text != "" && txtMK.Text != "")
            btnDangNhap.Enabled = true;
            txtMK.Enabled = true;
            checkBoxQuyenAdmin.Enabled = true;

            if (txtTK.Text == "" || txtMK.Text == "")
            {
                btnDangNhap.Enabled = false;
                checkBoxQuyenAdmin.Enabled = false;
            }
                
            
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            //if (txtTK.Text != "" && txtMK.Text != "")
            btnDangNhap.Enabled = true;
            txtMK.Enabled = true;
            checkBoxQuyenAdmin.Enabled = true;

            if (txtTK.Text == "" || txtMK.Text == "")
            {
                btnDangNhap.Enabled = false;
                checkBoxQuyenAdmin.Enabled = false;
            }

        }

        private int Check_QuyenAdmin()
        {
            int check = 0;
            try
            {
                Connect();

                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"SELECT COUNT(*) FROM NguoiDung WHERE TaiKhoan = '{txtTK.Text}' AND MatKhau = '{txtMK.Text}' AND QuyenAdmin = 'x'";
                
                check = (int)cmd.ExecuteScalar();   
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
            return check;          
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtTK.Select();
        }
    }
}
