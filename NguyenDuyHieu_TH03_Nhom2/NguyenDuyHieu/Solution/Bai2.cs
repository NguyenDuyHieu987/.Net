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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
            txtChuVi.Enabled = false;
            txtDienTich.Enabled = false;
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if(txtA.Text != "" && txtB.Text != "")
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                txtChuVi.Text = $"{(a + b) * 2}";
                txtDienTich.Text = $"{a * b}";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtChuVi.Text = "";
            txtDienTich.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
