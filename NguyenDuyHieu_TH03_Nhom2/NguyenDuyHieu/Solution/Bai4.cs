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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
            txtKetQua1.Enabled = false;
            txtKetQua2.Enabled = false;
        }
            

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (rdCong.Checked == true)
            {
                int a = int.Parse(TxtPhanThuc1.Text);
                int a1 = int.Parse(txtPhanAo1.Text);
                int b = int.Parse(txtPhanThuc2.Text);
                int b1 = int.Parse(txtPhanAo2.Text);
                txtKetQua1.Text = $"{a + b}";
                txtKetQua2.Text = $"{a1 + b1}";
            }
            else if (rdTru.Checked == true)
            {
                int a = int.Parse(TxtPhanThuc1.Text);
                int a1 = int.Parse(txtPhanAo1.Text);
                int b = int.Parse(txtPhanThuc2.Text);
                int b1 = int.Parse(txtPhanAo2.Text);
                txtKetQua1.Text = $"{a - b}";
                txtKetQua2.Text = $"{a1 - b1}";
            }
            else if (rdNhan.Checked == true)
            {
                int a = int.Parse(TxtPhanThuc1.Text);
                int a1 = int.Parse(txtPhanAo1.Text);
                int b = int.Parse(txtPhanThuc2.Text);
                int b1 = int.Parse(txtPhanAo2.Text);
                txtKetQua1.Text = $"{a * b - a1 * b1}";
                txtKetQua2.Text = $"{a * b1 + a1 * b}";
            }
            else if (rdChia.Checked == true)
            {
                int a = int.Parse(TxtPhanThuc1.Text);
                int a1 = int.Parse(txtPhanAo1.Text);
                int b = int.Parse(txtPhanThuc2.Text);
                int b1 = int.Parse(txtPhanAo2.Text);
                txtKetQua1.Text = $"{(float)(a * b + a1 * b1) / (b * b + b1 * b1)}";
                txtKetQua2.Text = $"{(float)(a1 * b - a * b1) / (b * b + b1 * b1)}";

            }
            else
            {
                MessageBox.Show("Vui lòng chọn phép tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtKetQua1.Text = null;
            txtKetQua2.Text = null;
            TxtPhanThuc1.Text = null;
            txtPhanAo1.Text = null;
            txtPhanThuc2.Text = null;
            txtPhanAo2.Text = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
