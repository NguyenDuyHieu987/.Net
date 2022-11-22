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
    public partial class Connect : Form
    {
        SqlConnection conn;

        private string svName = "DESKTOP-ISH3HH8\\SQLEXPRESS";
        private string dbName_DieuTraDS = "DieuTraDS_TH04";
        private string dbName_HoaHong = "HoaHong_TH04";
        private string Security = "SSPI";
        public Connect()
        {
            InitializeComponent();
        }
        public SqlConnection Connect_DieuTraDS()
        {
            try
            {
                string con_str = $"Server = {svName}; Database = {dbName_DieuTraDS}; Integrated Security = {Security}";
                conn = new SqlConnection(con_str);
                conn.Open();
                
            }
            catch (Exception ex)
            {
                conn.Close();
                throw new Exception(ex.Message);
            }
            return conn;

        }

        public SqlConnection Connect_HoaHong()
        {
            try
            {
                string con_str = $"Data Source = {svName}; Initial Catalog = {dbName_HoaHong}; Integrated Security = {Security}";
                conn = new SqlConnection(con_str);
                conn.Open();
               
            }
            catch (Exception ex)
            {
                conn.Close();
                throw new Exception(ex.Message);
            }
            return conn;

        }


    }
}
