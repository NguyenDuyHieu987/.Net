using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NguyenDuyHieu.Solution
{
    public partial class Cau1 : Form
    { 
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        private Connect connect = new Connect();
        //private string svName = "DESKTOP-ISH3HH8\\SQLEXPRESS";
        //private string dbName = "DieuTraDS_TH04";
        //private string Security = "SSPI";
        public Cau1()
        {
            InitializeComponent();
        }
        //private void connect()
        //{
        //    try
        //    {
        //        string con_str = $"Data Source = {svName}; Initial Catalog = {dbName}; Integrated Security = {Security}";
        //        conn = new SqlConnection(con_str);
        //        conn.Open();
        //    }
        //    catch (Exception ex)
        //    {
        //        conn.Close();
        //        throw new Exception(ex.Message);
        //    }

        //}

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn = connect.Connect_DieuTraDS();
                string MaCD = txtMaCD.Text;
                string MaPhuong = txtMaPhuong.Text;
                string TenCD = txtTenCD.Text;
                int CMND = int.Parse(txtCMND.Text);
                string GioiTinh = cbGioiTinh.SelectedItem.ToString() ;
                int NamSinh = int.Parse(maskedtxtNamSinh.Text);
                int SDT = int.Parse(txtSDT.Text);

                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"INSERT INTO CongDan (MaCD, MaPhuong, TenCD, CMND, GioiTinh, NamSinh, SDT) VALUES " +
                                        $"('{MaCD}', '{MaPhuong}', '{TenCD}', {CMND}, '{GioiTinh}', {NamSinh}, {SDT})";

                int sl = cmd.ExecuteNonQuery();
                if (sl == 1)
                {
                    MessageBox.Show("Thêm mới thành công");
                }
                else
                    MessageBox.Show("Thêm mới thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }
    }
}
