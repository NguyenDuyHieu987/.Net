using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenDuyHieu.Solution
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
            txtSapXep.Enabled = false;
            txtMang.Enabled = false;
            txtTinhTong.Enabled = false;
        }

        List<int> temp = new List<int>();
        int dem = 0;
        int sum = 0;
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if(txtSoPT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số phần tử của mảng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int n = int.Parse(txtSoPT.Text);
                int[] a = new int[n];
                if(txtNhapPT.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập 1 phần tử", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                { 
                    if(dem >= n)
                    {
                        MessageBox.Show("Nhập quá số phần tử của mảng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtMang.Text += txtNhapPT.Text + " ";
                        a[dem] = int.Parse(txtNhapPT.Text);
                        temp.Add(a[dem]);
                
                    }
                    dem++;        
            
                    for(int i = 0; i < n; i++)
                    {
                        sum += a[i];
                    }
                    txtTinhTong.Text = sum.ToString();
                }         
            }        
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            temp.Sort();
            for(int i = 0; i < temp.Count; i++)
            {
                txtSapXep.Text += temp[i].ToString() + " ";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtTinhTong.Text = null;
            txtSoPT.Text = null;
            txtSapXep.Text = null;
            txtNhapPT.Text = null;
            txtMang.Text = null;
            sum = 0;
            dem = 0;
            temp.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
