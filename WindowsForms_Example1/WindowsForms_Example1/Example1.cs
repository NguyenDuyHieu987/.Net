using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Example1
{
    public partial class Example1 : Form
    {
        public Example1()
        {
            InitializeComponent();
            this.btnKiemTra.Enabled = false;
                   
        }

        private bool KT_SoSim(string sosim)
        {
            foreach(char c in sosim)
            {
                if(!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            string sosim = txtSoSim.Text;
            
            if(sosim.Length != 10 || !KT_SoSim(sosim))
            {

                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show($"Vui lòng nhập đúng 10 số và không được là ký tự", "Thông Báo"); 
                          
            }
            else
            {
                txtSoSim.Focus();
                txtSoSim.Text = "";
            }
        }

        private void txtSoSim_TextChanged(object sender, EventArgs e)
        {
            btnKiemTra.Enabled = true;
            if(txtSoSim.Text == "")
            {
                btnKiemTra.Enabled = false;
            }

        }

        private void txtSoSim_Leave(object sender, EventArgs e)
        {
            string sosim = txtSoSim.Text;

            if (sosim.Length != 10 || !KT_SoSim(sosim))
            {

                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show($"Vui lòng nhập đúng 10 số và không được là ký tự", "Thông Báo");
                txtSoSim.Select();

            }
        }
 

        private void Example1_Load(object sender, EventArgs e) // Trước khi from được mở lên 
        {
            //ActiveControl = txtSoSim;
            txtSoSim.Select();
        }

        private void Example1_Shown(object sender, EventArgs e)// Sau Khi form được mở lên và khi form tử Hide -> Show
        {
            //txtSoSim.Focus();
        }

        private void Example1_Activated(object sender, EventArgs e)// Khi chuyển từ form khác về form này
        {
            txtSoSim.Focus();
        }

        

     
    }
}
