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
namespace Demo1___WindowsForms
{
    public partial class Connect : Form
    {
        private SqlConnection conn;
        private string svName = "DESKTOP-ISH3HH8\\SQLEXPRESS";
        private string dbName = "Quanlynhanvien";
        private string Security = "SSPI";
        public Connect()
        {
            InitializeComponent();
        }

        public SqlConnection Connect_Quanlynhanvien()
        {
            try
            {
                string con_str = $"Data Source = {svName}; Initial Catalog = {dbName};  Integrated Security = {Security}";
                conn = new SqlConnection(con_str);
                conn.Open();
                return conn;             
            }
            catch(Exception ex)
            {
                //conn.Close();
                throw new Exception(ex.Message);
            }
        }

    }
}
