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
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ chiều dài, chiều rộng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double a = double.Parse(textBox1.Text);
                    double b = double.Parse(textBox2.Text);
                    textBox3.Text = $"{a + b / 2}";
                    textBox4.Text = $"{a * b}";
                }
            }
            else if (radioButton2.Checked == true)
            {
                
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập bán kính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double r = double.Parse(textBox1.Text);                 
                    textBox3.Text = $"{Math.PI * r * 2}";
                    textBox4.Text = $"{Math.PI * r * r}";
                }
            }
            else if(radioButton3.Checked == true)
            {
                
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập độ dài cạnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double a = double.Parse(textBox1.Text);
                    textBox3.Text = $"{4 * a}";
                    textBox4.Text = $"{a * a}";
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn hình trước khi thực hiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                textBox2.ReadOnly = false;
            }
            else
            {
                textBox2.ReadOnly = true;
            }
        }



    }
}
