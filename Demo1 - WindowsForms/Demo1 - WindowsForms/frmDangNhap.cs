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

namespace Demo1___WindowsForms
{
    public partial class frmDangNhap : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private frmMain frmMain;
        private Connect connect = new Connect();
        public frmDangNhap()
        {
            InitializeComponent();
            //this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.UseSystemPasswordChar = true;
            //this.txtTaiKhoan.Enabled = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // or
            //this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }

            //if (checkBox1.Checked == true)
            //{
            //    txtMatKhau.PasswordChar = '\0';
            //}
            //else
            //{
            //    txtMatKhau.PasswordChar = '*';
            //}
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Kiểm tra đăng nhập của người đùng với hệ thống bằng cách
            try
            {
                conn = connect.Connect_Quanlynhanvien();
                string TaiKhoan = txtTaiKhoan.Text;
                string MatKhau = txtMatKhau.Text;
                //Mật khảu phải được mã hóa =? phải có hàm mã hóa mật khẩu nếu là hệ thống thực tế đảm bảo ATBMTT
 
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"SELECT COUNT(*) FROM NguoiDung WHERE TaiKhoan = '{TaiKhoan}' AND MatKhau = '{MatKhau}'";

                //Truy vấn có 1 dữ liệu trả về duy nhất => chọnExecuteScalar()
                int SoLuong = (int)cmd.ExecuteScalar();
                conn.Close();

                if(SoLuong == 1)
                {
                    MessageBox.Show("Dăng nhập thành công");
                    frmMain = new frmMain();        
                    
                    this.Hide();
                    frmMain.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Dăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }



        //private void frmDangNhap_Load(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Giao diện đang được thực hiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        //private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    MessageBox.Show("Giao diện đang được đóng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
    }
}
