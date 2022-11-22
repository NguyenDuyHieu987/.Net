using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; // Thư vieenk của Dataset
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Thư viện của Data provider


namespace Demo1___WindowsForms
{
    public partial class frmTest : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private string svName = "DESKTOP-ISH3HH8\\SQLEXPRESS";
        private string dbName = "Quanlynhanvien";
        private string Security = "SSPI";
        //private string userID = "hieu";
        //private string passWord = "123";
        public frmTest()
        {
            InitializeComponent();

            
        }

        private void connect()
        {
            try
            {
                string con_str = $"Data Source = {svName}; Initial Catalog = {dbName}; Integrated Security = {Security}";
                //string con_str = $"Data Source = {svName}; Initial Catalog = {dbName}; User ID = {userID}; Password = {passWord}";
                //Bước 2: Tạo đối tượng kết nối
                conn = new SqlConnection(con_str);

                //Bước 3: Mở kết nối
                conn.Open();
            }
            catch(Exception ex)
            {
                conn.Close();
                throw new Exception(ex.Message);
            }       
        }
            


        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            // Thêm mới 1 chức vụ vào cơ sở dữ liệu
            try
            {
                connect();
                //Bước 4: Thực thi các truy vấn Insert
                //Buoc 5: Tạo truy vấn
                //Đọc dữ liệu người dùng nhập trên ô text;
                string MaChucVu = txtMaChucVu.Text;
                string TenChucVu = txtTenChucVu.Text;
                float HsPC = float.Parse(txtHeSoPhuCap.Text);
                string insert = $"INSERT INTO Chucvu (macv, tencv, hesopc) VALUES ('{MaChucVu}', '{TenChucVu}', {HsPC})";

                //Bước 5:Tạo đối tượng thục thi truy vấn
                cmd = new SqlCommand(insert, conn);
                //Bước 6:Thực thi truy vấn =? Truy vấn thực thi là insert -+ chọn phương thức thực thi là ExecuteNonQuery()
                int sl = cmd.ExecuteNonQuery();//Trả về số row được insert
                if(sl == 1)
                {
                    MessageBox.Show("Thêm mới thành công");
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }     
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            conn.Close();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                this.connect();
                string Query = "SELECT * FROM NhanVien";
                //Thông tin phòng có nhiều nhân viên nhất
                string Query1 = "SELECT NhanVien.maph, tenph, diachiphong, COUNT(manv) " +
                                    "FROM NhanVien, Phong " +
                                    "WHERE NhanVien.maph = Phong.maph " +
                                    "GROUP BY NhanVien.maph, tenph, diachiphong " +
                                    "HAVING COUNT(manv) = (SELECT TOP 1 COUNT(manv) " +
                                                            "FROM NhanVien " +
                                                            "GROUP BY maph " +
                                                            "ORDER BY COUNT(manv) DESC)";
                cmd = new SqlCommand(Query, conn);
                reader = cmd.ExecuteReader();

                //or
                //cmd = new SqlCommand();
                //cmd.Connection = conn; 
                //cmd.CommandText = $"{Query1}";


                //while (reader.Read())
                //{
                //    MessageBox.Show($"{reader["macv"]} \t {reader["tencv"]} \t {reader["hesopc"]}");
                //   
                //}

                //while (reader.Read())
                //{
                //    int i = 0;
                //    MessageBox.Show($"{reader[i]} \t {reader[++i]} \t {reader[++i]} \t {reader[++i]}");
                //}

                while (reader.Read())
                {
                    MessageBox.Show(String.Format("{0} \t {1} \t {2} \t {3}", reader[0], reader[1], reader[2], reader[3]));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            finally
            {
                conn.Close();
            }                  
        }


        private void btnSoNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                this.connect();
                string Query = "SELECT COUNT(manv) FROM NhanVien";
                string Query1 = "SELECT MAX(Thuclinh) FROM NhanVien";
                cmd = new SqlCommand(Query, conn);
                
                int SoNV = (int)cmd.ExecuteScalar();
                MessageBox.Show($"Số nhân viên : {SoNV}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnPROC_Click(object sender, EventArgs e)
        {
            try
            {
                connect();
                string Proc = "Proc_HienThi_Thuclinh";
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"{Proc}"; // Mặc định là truy vấn trực tiếp -> Text
                cmd.CommandType = CommandType.StoredProcedure;// Chuyển sang truy vấn theo Procedure
                cmd.Parameters.Add(
                    new SqlParameter
                    {
                        ParameterName = "@Thuclinh",
                        SqlDbType = SqlDbType.Float,
                        SqlValue = 10000000 // Or Value = 10000000
                       
                    }
                );
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    int i = 0;
                    MessageBox.Show($"{reader[i]}\t {reader[++i]}\t {reader[++i]}\t {reader["Thuclinh"]}");
                }
                reader.Close();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Proc_HienThi";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show(String.Format("{0}\t{1}\t{2}\t{3}", reader[0], reader[1], reader[3], reader[4]));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            conn.Close();
        }
    }
}
