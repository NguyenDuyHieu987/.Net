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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int i = 0;
            int sqr = (int)Math.Sqrt(n);
            if (sqr * sqr == n)
            {
                MessageBox.Show($"{n} là số chính phương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
                MessageBox.Show($"{n} không phải là số chính phương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
