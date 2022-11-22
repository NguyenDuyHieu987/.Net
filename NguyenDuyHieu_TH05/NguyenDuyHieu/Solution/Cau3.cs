﻿using System;
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
    public partial class Cau3 : Form
    {
        SqlConnection conn;
        SqlDataAdapter DA;
        DataSet DS;
        private Connect connect = new Connect();
        public Cau3()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                conn = connect.Connect_DieuTraDS();
                conn.Close();

                DA = new SqlDataAdapter($"SELECT * FROM CongDan WHERE CMND = {txtCMND_Search.Text}", conn);
                DS = new DataSet();
                DA.Fill(DS, "CongDan");

                dataGridViewThongTin.DataSource = DS.Tables["CongDan"];                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }


        private void Cau3_Load(object sender, EventArgs e)
        {
            try
            {
                conn = connect.Connect_DieuTraDS();
                conn.Close();

                DA = new SqlDataAdapter($"SELECT * FROM CongDan", conn);
                DS = new DataSet();
                DA.Fill(DS, "CongDan");

                dataGridViewThongTin.DataSource = DS.Tables["CongDan"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Cau3_Load(sender, e);
        }
    }
}
