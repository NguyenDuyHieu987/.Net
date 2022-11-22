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
            int count = 0;
            if(textBox1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập 1 số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int n = int.Parse(textBox1.Text);
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if(n % i == 0)
                    {
                        count++;
                    }
                }
                if(count == 0)
                {
                    MessageBox.Show($"{n} là số nguyên tố", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{n} không phải là số nguyên tố", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
