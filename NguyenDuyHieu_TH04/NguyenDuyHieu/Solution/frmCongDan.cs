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
    public partial class frmCongDan : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter DA;
        private DataSet DS;
        private Connect connect = new Connect();
       
        public frmCongDan()
        {
            InitializeComponent();
        }

        private void frmCongDan_Load(object sender, EventArgs e)
        {
            getDataSet();
        }

        private void getDataSet()
        {
            try
            {
                conn = connect.Connect_DieuTraDS();
                conn.Close();
                string Select_Query = "SELECT * FROM CongDan";
                DA = new SqlDataAdapter(Select_Query, conn);
                DS = new DataSet();
                SqlCommandBuilder builder = new SqlCommandBuilder(DA);
                DA.Fill(DS, "CongDan");
                DS.Tables["CongDan"].PrimaryKey = new DataColumn[] { DS.Tables["CongDan"].Columns["MaCD"] };

                dataGridView1.DataSource = DS.Tables["CongDan"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClearText()
        {
            btnThem.Enabled = true;

            txtMaCD.Text = "";
            txtCMND.Text = "";
            txtMaPhuong.Text = "";
            txtSDT.Text = "";
            txtTenCD.Text = "";
            maskedtxtNgaySinh.Text = "";
            cbGioiTinh.Text = "";
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearText();
            getDataSet();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn = connect.Connect_DieuTraDS();
                conn.Close();

                DataRow row = DS.Tables["CongDan"].NewRow();
                row["MaCD"] = txtMaCD.Text;
                row["MaPhuong"] = txtMaPhuong.Text;
                row["TenCD"] = txtTenCD.Text;
                row["CMND"] = int.Parse(txtCMND.Text);
                row["GioiTinh"] = cbGioiTinh.SelectedItem;
                row["NgaySinh"] = maskedtxtNgaySinh.Text;
                row["SDT"] = int.Parse(txtSDT.Text);
                DS.Tables["CongDan"].Rows.Add(row);

                int SL = DA.Update(DS, "CongDan");
                if (SL == 1)
                {
                    MessageBox.Show("Thêm mới công dân thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getDataSet();
                }
                else
                {
                    MessageBox.Show("Thêm mới công dân thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                conn = connect.Connect_DieuTraDS();
                conn.Close();

                DataRow row = DS.Tables["CongDan"].Rows.Find(txtMaCD.Text);
                if (row == null)
                {
                    throw new Exception("Không tim thấy mã công dân: " + txtMaCD);
                }
                row.BeginEdit();
                row["MaPhuong"] = txtMaPhuong.Text;
                row["TenCD"] = txtTenCD.Text;
                row["CMND"] = txtCMND.Text;
                row["GioiTinh"] = cbGioiTinh.SelectedItem.ToString();
                row["NgaySinh"] = maskedtxtNgaySinh.Text;
                row["SDT"] = txtSDT.Text;
                row.EndEdit();

                int SL = DA.Update(DS, "CongDan");

                if (SL == 1)
                {
                    MessageBox.Show($"Sửa công dân có mã {txtMaCD.Text} thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getDataSet();
                }
                else
                {
                    MessageBox.Show($"Sửa công dân có mã {txtMaCD.Text} thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn = connect.Connect_DieuTraDS();
                conn.Close();

                DataRow row = DS.Tables["CongDan"].Rows.Find(txtMaCD.Text);
                if(row == null)
                {
                    throw new Exception("Không tim thấy mã công dân: " + txtMaCD);
                }
                row.Delete();

                int SL = DA.Update(DS, "CongDan");
                if (SL == 1)
                {
                    MessageBox.Show($"Xóa công dân có mã {txtMaCD.Text} thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getDataSet();
                }
                else
                {
                    MessageBox.Show($"Xóa công dân có mã {txtMaCD.Text} thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IndexRow = e.RowIndex;
            if(IndexRow >= 0)
            {
                btnThem.Enabled = false;

                txtMaCD.Text = dataGridView1.Rows[IndexRow].Cells["MaCD"].Value.ToString();
                txtMaPhuong.Text = dataGridView1.Rows[IndexRow].Cells["MaPhuong"].Value.ToString();
                txtTenCD.Text = dataGridView1.Rows[IndexRow].Cells["TenCD"].Value.ToString();
                txtCMND.Text = dataGridView1.Rows[IndexRow].Cells["CMND"].Value.ToString();
                cbGioiTinh.Text = dataGridView1.Rows[IndexRow].Cells["GioiTinh"].Value.ToString();
                maskedtxtNgaySinh.Text = String.Format("{0:MM/dd/yyyy}", dataGridView1.Rows[IndexRow].Cells["NgaySinh"].Value);
                txtSDT.Text = dataGridView1.Rows[IndexRow].Cells["SDT"].Value.ToString();
            }
        }
    }
}
