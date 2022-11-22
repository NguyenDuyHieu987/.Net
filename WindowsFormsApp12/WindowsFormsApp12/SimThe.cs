using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{   
    public partial class SimThe : Form
    {
        public SimThe()
        {
            InitializeComponent();

        }
        public void ketnoi()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=TUTINHHAO\\SQLEXPRESS;Initial Catalog=SimThe;User ID=sa;Password=A07180295e");
                conn.Open();


                //SqlDataAdapter da = new SqlDataAdapter("select Count(*) from Sim where ID ='" + txt_ma.Text + "'", conn);
                SqlCommand cmddd = new SqlCommand("select count (*) from table_sosim where id_sosim =@ID", conn);
                cmddd.Parameters.Add(new SqlParameter("@ID", txt_ma.Text));
                int dem = (int)cmddd.ExecuteScalar();

                if (dem > 0)
                {
                    MessageBox.Show(" nhap ID trung, nhap lai");
                    //  SqlCommand cmd = new SqlCommand("delete from Sim where ID=@ID", conn);
                    // cmd.Parameters.Add(new SqlParameter("@ID", txt_ma.Text));

                    //  SqlCommand cmdd = new SqlCommand("delete from Mang where ID=@ID", conn);
                    //  cmdd.Parameters.Add(new SqlParameter("@ID", txt_ma.Text));
                    //   cmd.ExecuteNonQuery();
                    //  cmdd.ExecuteNonQuery();
                    //MessageBox.Show("xoa thanh cong");
                    SqlDataAdapter da = new SqlDataAdapter("select * from table_sosim ", conn);
                    DataSet dataset1 = new DataSet();
                    da.Fill(dataset1, "table_sosim");
                    dataGridView1.DataSource = dataset1.Tables["table_sosim"];

                }
                else
                {
                    //  MessageBox.Show("Khong tim thay ma de xoa");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //cach1
            String a;
            a = txt_ma.Text;
            if (a.Length < 10)
            {
                MessageBox.Show("vietlai label1 vi sdt nho hon 10");
                //  txt_ma.Text = "";
                
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_ma.Text, "  ^ [0-9]"))
            {
                MessageBox.Show("nhap lai khong duoc nhan ki tu");
                // txt_ma.Text = "";
            }
            else
            { txt_ma.Text = "";}
        }

        private void txt_ma_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

            
        }

        private void txt_ma_KeyDown(object sender, KeyEventArgs e)
        {   //c1
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.NumPad7|| e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.NumPad0  )
            {
                
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();// chon cai nao tuy cac em
                Console.Beep();//1 trong 2 cai bip :))
                MessageBox.Show("nhap lai khong duoc nhan ki tu");
            }
            //c2
            //
            //if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "  ^ [0-9]"))
            // MessageBox.Show("nhap lai khong duoc nhan ki tu");

            //
            //
        }
        // public event EventHandler TabIndexChanged;
        private void Control1_TabIndexChanged(Object sender, EventArgs e)
        {

           // MessageBox.Show("You are in the Control.TabIndexChanged event.");
        }
        private void txt_ma_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_ma_KeyUp(object sender, KeyEventArgs e)
        {
            
           // {
           //     if (e.KeyCode == Keys.Tab)
            //    {
            //       MessageBox.Show("Phím tab vừa được nhấn");
            //    }
           // }
        }

        private void txt_ma_TabIndexChanged(object sender, EventArgs e)
        {
            //  MessageBox.Show("You are in the Control.TabIndexChanged event.");
           // MessageBox.Show("Phím tab vừa được nhấn");
        }

        private void txt_ma_Leave(object sender, EventArgs e)
        {
            //cach1
            String a;
            a = txt_ma.Text;
                 if(a.Length<10)
            {
                MessageBox.Show("vietlai label1 vi sdt nho hon 10");
            }
          //  if (System.Text.RegularExpressions.Regex.IsMatch(txt_ma.Text, "  ^ [0-9]"))
          //  MessageBox.Show("nhap lai khong duoc nhan ki tu");


        }
    }
}
