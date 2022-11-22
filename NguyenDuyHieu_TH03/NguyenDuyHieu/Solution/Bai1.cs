using System;
using System.Windows.Forms;

namespace NguyenDuyHieu.Solution
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn vừa nhấn vào Yes", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn vừa nhấn vào No", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn vừa nhấn vào Maybe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
