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
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            dem = 0;
            sum = 0;
            lst.Clear();
        }
       

        int sum = 0, dem = 0;
        List<int> lst = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số phần tử của mảng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int n = int.Parse(textBox1.Text);
                int[] a = new int[n];
                if (textBox5.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập 1 phần tử", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {  
                    if (dem < n)
                    {
                        a[dem] = int.Parse(textBox5.Text);
                        lst.Add(a[dem]);
                        textBox2.Text += lst[dem].ToString() + " ";
                    }
                    dem++;
                    if (dem > n)
                    {
                        MessageBox.Show("Nhập quá số phần tử của mảng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    for (int i = 0; i < n; i++)
                    {
                        sum += a[i];
                    }
                    textBox3.Text = $"{sum}";
                }        
            }          
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            lst.Sort();
            
            for (int i = 0; i < lst.Count; i++)
            {
                textBox4.Text += lst[i].ToString() + " ";
            }
        }
    }
}
