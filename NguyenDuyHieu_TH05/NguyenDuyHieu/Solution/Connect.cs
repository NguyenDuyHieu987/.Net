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
        private SqlConnection conn;
        public Connect()
        {
            InitializeComponent();
        }

        public SqlConnection Connect_DieuTraDS()
        {
            try
            {
                conn = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = DieuTraDS_TH05; Integrated Security = SSPI");
                conn.Open();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return conn;         
        }

        public SqlConnection Connect_HoaHong()
        {
            try
            {
                conn = new SqlConnection("Server = DESKTOP-ISH3HH8\\SQLEXPRESS; Database = HoaHong_TH05; Integrated Security = SSPI");
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return conn;
        }

        public SqlConnection Connect_PMStore()
        {
            try
            {
                conn = new SqlConnection("Data Source = DESKTOP-ISH3HH8\\SQLEXPRESS; Initial Catalog = PMStore_TH05; Integrated Security = SSPI");
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return conn;
        }

        public SqlConnection Connect_SimThe()
        {
            try
            {
                conn = new SqlConnection("Data Source = DESKTOP-ISH3HH8\\SQLEXPRESS; Initial Catalog = SimThe_TH05; Integrated Security = SSPI");
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return conn;
        }
    }
}
