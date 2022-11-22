using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1___WindowsForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int index = listBox1.SelectedIndex;//Trả về vị trí của dòng được chọn 
            //string item = listBox1.SelectedItem.ToString();// Trả vế giá trị của dòng được chọn  
            //MessageBox.Show($"Nguoi dung chon vi tri {index}: {item}");

            foreach (int index in listBox1.SelectedIndices)
            {
                string items = listBox1.Items[index].ToString();
                MessageBox.Show($"Nguoi dung chon vi tri {index}: {items}, is Selected, Selected state is: {listBox1.GetSelected(index)}");

            }

            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    if (listBox1.GetSelected(i)) // return true/false
            //    {
            //        MessageBox.Show($"nguoi dung chon {listBox1.Items[i]}");
            //    }
            //}

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                //if (checkedListBox1.GetItemChecked(i)) // return true/false
                //{
                //    MessageBox.Show($"nguoi dung chon {checkedListBox1.Items[i]}");
                //}
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked) // return Checked/Unchecked
                {
                    MessageBox.Show($"nguoi dung chon {checkedListBox1.Items[i]}");
                }
            }



            //foreach (int indexChecked in checkedListBox1.CheckedIndices)
            //{
            //    // The indexChecked variable contains the index of the item.
            //    MessageBox.Show("Index: " + indexChecked.ToString() + ", Item: " + checkedListBox1.Items[indexChecked]
            //                    + ", is checked. Checked state is: " + checkedListBox1.GetItemCheckState(indexChecked) + ".");
            //}

            //foreach(string items in checkedListBox1.CheckedItems)
            //{
            //    MessageBox.Show("Items: " + items);
            //}



        }



    }
    
}
