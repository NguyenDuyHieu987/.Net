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
using Demo1___WindowsForms.Model;

namespace Demo1___WindowsForms
{
    public partial class frmPhong : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private SqlDataAdapter DA;
        private DataSet DS;
        private Connect connect = new Connect();
        public frmPhong()
        {
            InitializeComponent();
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            // Sự kiện xảy ra khi giao diệm được Load lên
            // Thực hiện đọc dữ liệu của bảng Phong và hiển thị dữ liệu này lên DataGridView
            getDataSet();
        }

        public void getData()
        {
            try
            {
                conn = connect.Connect_Quanlynhanvien();
                //Khởi tạo Collection\
                List<Phong> lstPhong = new List<Phong>();
                
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM Phong";

                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Phong obj = new Phong();
                    obj.maph = reader[0].ToString();
                    obj.tenph = (string)reader[1];
                    obj.diachiphong = (string)reader[2];
                    lstPhong.Add(obj);

                }
                conn.Close();

                dataGridViewDuLieu.DataSource = lstPhong;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getDataSet()
        {
            try
            {
                //Lấy dữ liệu từ Database thông qua Select Query, đổ lên DataSet
                conn = connect.Connect_Quanlynhanvien();
                //Không cần mở kết nối trong trường hợp làm việc với sql DataAdapter
                conn.Close();

                string Select_Query = "SELECT * FROM Phong";
                DA = new SqlDataAdapter(Select_Query, conn);
                SqlCommandBuilder Builder = new SqlCommandBuilder(DA);
                DS = new DataSet();// là 1 bản sao cơ sở dữ liệu của SQL Server lưu trữ trên RAM
                DA.Fill(DS, "Phong");// DA sẽ tự mở kết nối và đóng kết nối sau khi thực thi xong
                DS.Tables["Phong"].PrimaryKey = new DataColumn[] {DS.Tables["Phong"].Columns["maph"]};


                //Hiển thị dữ liệu được truy vấn lên DataGridView
                dataGridViewDuLieu.DataSource = DS.Tables["Phong"];



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                conn = connect.Connect_Quanlynhanvien();
                string maph = txtMaPhong.Text;
                string tenph = txtTenPhong.Text;
                string diachiphong = txtDCPhong.Text;

                //cmd = new SqlCommand();
                //cmd.Connection = conn;
                //cmd.CommandText = $"INSERT INTO Phong (maph, tenph, diachiphong) VALUES ('{maph}', '{tenph}', '{diachiphong}')";


                DataRow row = DS.Tables["Phong"].NewRow();
                row["maph"] = txtMaPhong.Text;
                row["tenph"] = txtTenPhong.Text;
                row["diachiphong"] = txtDCPhong.Text;
                DS.Tables["Phong"].Rows.Add(row);

                int SL = DA.Update(DS, "Phong");
                //int SL = cmd.ExecuteNonQuery();



                if (SL == 1)
                {
                    MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Load lại dữ liệu trên DataGridView
                    ClearText();

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
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                conn = connect.Connect_Quanlynhanvien();

                string maph = txtMaPhong.Text;
                string tenph = txtTenPhong.Text;
                string diachiphong = txtDCPhong.Text;

                //cmd = new SqlCommand();
                //cmd.Connection = conn;
                //cmd.CommandText = $"UPDATE Phong SET tenph = '{tenph}', diachiphong = '{diachiphong}' WHERE maph = '{maph}'";


                DataRow row = DS.Tables["Phong"].Rows.Find(maph);
                if(row == null)
                {
                    throw new Exception("Mã phòng không tồn tại trong bảng");
                }
                row.BeginEdit();
                row["tenph"] = txtTenPhong.Text;
                row["diachiphong"] = txtDCPhong.Text;
                row.EndEdit();
     
                 

                int SL = DA.Update(DS, "Phong");
                //int SL = cmd.ExecuteNonQuery();
                conn.Close();

                if (SL == 1)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    ClearText();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
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
                conn = connect.Connect_Quanlynhanvien();

                string maph = txtMaPhong.Text;

                //cmd = new SqlCommand();
                //cmd.Connection = conn;
                //cmd.CommandText = $"DELETE FROM Phong WHERE maph = '{maph}'";

                DataRow row = DS.Tables["Phong"].Rows.Find(maph);
                if (row == null)
                {
                    throw new Exception("Mã phòng không tồn tại trong bảng");
                }
                row.Delete();
                
                
                

                int SL = DA.Update(DS, "Phong");
                //int SL = cmd.ExecuteNonQuery();
                conn.Close();

                if (SL == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Load lại dữ liệu trên DataGridView
                    ClearText();
                }
                else
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }
        
        private void dataGridViewDuLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Xác định dòng mà người dùng đang Click
                int vtrow = e.RowIndex;
                //Xác định cột mà người dùng đang Click
                int col = e.ColumnIndex;
                if (vtrow >= 0)// Tránh trương hợp người dùng bấm vào tiêu đề của bảng (row = -1)
                {
                    //txtMaPhong.Enabled = false;
                    btnThemMoi.Enabled = false;

                    // Đọc dữ liệu của các cột trên DataGridViw, hiển thị sang phần thông tin
                    txtMaPhong.Text = dataGridViewDuLieu.Rows[vtrow].Cells[0].Value.ToString();
                    txtTenPhong.Text = dataGridViewDuLieu.Rows[vtrow].Cells[1].Value.ToString();
                    txtDCPhong.Text = dataGridViewDuLieu.Rows[vtrow].Cells[2].Value.ToString();


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ClearText()
        {
            txtMaPhong.Enabled = true;
            btnThemMoi.Enabled = true;


            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtDCPhong.Text = "";
            getDataSet();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearText();
        }

       
    }
}
