using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // khai bao thu vien 

namespace WindowsFormsApplication1
{
    public partial class frmHoaDon : Form
    {
        string sCon = "Data Source=LAPTOP-SMKPHOFO;Initial Catalog=CuaHangTapHoa;Integrated Security=True";// xau ket noi 
        public frmHoaDon()
        {
            InitializeComponent();
        }
        public void ShowHD() // ham hien thi hoa don sau khi cap nhat 
        {
            SqlConnection con = new SqlConnection(sCon); // khoi tao ket noi 
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu!", "Thông Báo");
            }
            string sQuery = "select * from HD_Ban_Chitiet"; // su dung cau lenh SQL 
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con); // lấy dữ liệu về 
            DataSet ds = new DataSet();// khoi tao dataset , ds là bản sao của dữ liệu 
            adapter.Fill(ds, "HD_Ban_Chitiet");// đẩy dữ liệu vào dataset
            dataGridView1.DataSource = ds.Tables["HD_Ban_Chitiet"];// đổ dữ liệu vào datagridv
            con.Close(); // đóng kết nối 
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaHDB.Text != "")
            {
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối Database!", "Thông báo");
                }
                //lấy dữ liệu 
                string sMaHD = txtMaHDB.Text; 
                string sTongtien = "0";
                string sNgayban = DateTime.Now.ToString("yyyy-MM-dd");
                string sGioban = DateTime.Now.ToString("hh:mm tt");
                // sử dụng câu lệnh sql 
                string squery = "insert dbo.HoaDonBan values(@MaHD,@NgayBan,@Gioban,@Tongtien)";
                SqlCommand cmd = new SqlCommand(squery, con);
                cmd.Parameters.AddWithValue("@MaHD", sMaHD);
                cmd.Parameters.AddWithValue("@Tongtien", sTongtien);
                cmd.Parameters.AddWithValue("@NgayBan", sNgayban);
                cmd.Parameters.AddWithValue("@Gioban", sGioban);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới!", "Thông báo");
                }
                GetHDCTByIDHD(sMaHD);
                txtThanhtien.Text = "0";
                con.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn!", "Thông báo");
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            ShowHD(); // hien thi hoa don 
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)// ktra hang can xoa 
            {
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối Database!", "Thông báo");
                }
                //lay dl tu gdien 
                string sMaH = txtMaH.Text;
                string sSlban = txtSlban.Text;
                string sMaHDB = txtMaHDB.Text;
                string sDongia = txtDongiaban.Text;
                string sThanhtien = txtThanhtien.Text;
                // tinh so tien bi mat di 
                int tien = Convert.ToInt32(sDongia) * Convert.ToInt32(sSlban);
                string squery = "Delete HD_Ban_Chitiet where MaHDB = @MaHDB and MaH = @MaH";
                SqlCommand cmd = new SqlCommand(squery, con);
                cmd.Parameters.AddWithValue("@MaHDB", sMaHDB);
                cmd.Parameters.AddWithValue("@MaH", sMaH);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu!", "Thông báo");
                }
                //cap nhat thanh tien 
                txtThanhtien.Text = (Convert.ToInt32(txtThanhtien.Text) - tien).ToString();
                // cap nhat lai hdct
                GetHDCTByIDHD(sMaHDB);
                con.Close();
            }
        }


        private void btSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1) // ktra mot lan sua chi duoc sua 1 mat hang 
            {
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối Database!", "Thông báo");
                }
                // lay sl truoc khi cap nhat 
                int slcu = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Soluongban"].Value.ToString());
                //gan du lieu vao bien
                string sMahang = txtMaH.Text;
                string sDongia = txtDongiaban.Text;
                string sSlban = txtSlban.Text;
                // tinh tien sau khi cap nhat  = don gia * slban moi 
                int tien = Convert.ToInt32(sDongia) * Convert.ToInt32(sSlban);
                string sMaHDB = txtMaHDB.Text;
                string sMaH = txtMaH.Text;
                // chuan bi cau truy van 
                string squery = "update HD_Ban_Chitiet set Soluongban = @slban, Thanhtien = @tt where MaHDB = @MaHD and MaH = @MaH ";
                SqlCommand cmd = new SqlCommand(squery, con);
                //thiet lap bien de biet gia tri bien 
                cmd.Parameters.AddWithValue("@MaH", sMahang);
                cmd.Parameters.AddWithValue("@slban", sSlban);
                cmd.Parameters.AddWithValue("@tt", tien);
                cmd.Parameters.AddWithValue("@MaHD", sMaHDB);
                try
                {
                    cmd.ExecuteNonQuery();// đẩy những lệnh vào insert/ update / delete vao sql     
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình sửa!", "Thông báo");
                }
                // tinh hieu tien 
                int ttien = (slcu - Convert.ToInt32(sSlban)) * Convert.ToInt32(sDongia);
                // update textbox thanh tien 
                txtThanhtien.Text = (Convert.ToInt32(txtThanhtien.Text) - ttien).ToString();
                GetHDCTByIDHD(sMaHDB);
                con.Close();
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối Database!", "Thông báo");
            }
            // thực hiện câu truy vấn sql 
            string sQuery = "update dbo.HoaDonBan set Tongtien = @TT  where MaHD =@MaHDB";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaHDB", txtMaHDB.Text);
            cmd.Parameters.AddWithValue("@TT", txtThanhtien.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lưu thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình Lưu!", "Thông báo");
            }
            con.Close();
            ShowHD();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            txtMaHDB.Text = "";
            txtMaH.Text = "";
            txtSlban.Text = "";
            txtSlban.Text = "";
            txtThanhtien.Text = "";
            txtTenhang.Text = "";
            txtDongiaban.Text = ""; 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaH.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSlban.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //txtDongiaban.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối Database!", "Thông báo");
            }
            //lay hang khi biet mah va truyen vao gd (tb) 
            string sQuery = "select * from Hang where MaH = '" + txtMaH.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Hang");
            DataTable dt = ds.Tables["Hang"];
            DataRow r = dt.Rows[0]; // lay hang dau tien trong data tble
            // hien thi tenh va dongia
            txtTenhang.Text = r["TenH"].ToString();
            txtDongiaban.Text = r["Dongiaban"].ToString();
            con.Close();
        }
        public void GetHDCTByIDHD(string ID)
        {
            SqlConnection con = new SqlConnection(sCon); // khoi tao ket noi 
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu!", "Thông Báo");
            }
            string sQuery = "select * from HD_Ban_Chitiet where MaHDB = '" + ID + "'"; // su dung cau lenh SQL 
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con); // lấy dữ liệu về 
            DataSet ds = new DataSet();// khoi tao dataset , ds là bản sao của dữ liệu 
            adapter.Fill(ds, "HD_Ban_Chitiet");// đẩy dữ liệu vào dataset
            dataGridView1.DataSource = ds.Tables["HD_Ban_Chitiet"];// đổ dữ liệu vào datagridv
            con.Close(); // đóng kết nối 
        }
        private void btTimkiem_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text != "")
            {
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối Database!", "Thông báo");
                }
                //lay hang khi biet mah va truyen vao gd (tb) 
                string sQuery = "select * from HoaDonBan where MaHD = '" + txttimkiem.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Hang");
                DataTable dt = ds.Tables["Hang"];
                if (dt.Rows.Count > 0)
                {
                     DataRow r = dt.Rows[0]; // lay hang dau tien trong data tble
                    // hien thi tenh va dongia
                     txtMaHDB.Text = r["MaHD"].ToString();
                     txtThanhtien.Text = r["TongTien"].ToString();
                     dtpkgioban.Value = Convert.ToDateTime(r["GioBan"].ToString());
                     dtpkngayban.Value = Convert.ToDateTime(r["NgayBan"].ToString());
                     GetHDCTByIDHD(txtMaHDB.Text);
                }
                else
                {
                    MessageBox.Show("Không tồn tại mã hóa đơn này!", "Thông báo");
                }
                con.Close();
            }
        }

        private void btghang_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối Database!", "Thông báo");
            }
            string sMaH = txtMaH.Text;
            string sSlban = txtSlban.Text;
            string sMaHD = txtMaHDB.Text;
            string sDongia = txtDongiaban.Text;
            string sThanhtien = txtThanhtien.Text;
            int tien = Convert.ToInt32(sDongia) * Convert.ToInt32(sSlban);

            string squery = "insert dbo.HD_Ban_Chitiet values(@MaHD,@MaH,@Soluongban,@Thanhtien)";
            SqlCommand cmd = new SqlCommand(squery, con);
            cmd.Parameters.AddWithValue("@MaHD", sMaHD);
            cmd.Parameters.AddWithValue("@MaH", sMaH);
            cmd.Parameters.AddWithValue("@Soluongban", sSlban);
            cmd.Parameters.AddWithValue("@Thanhtien", tien.ToString());
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới!", "Thông báo");
            }
            // cap nhat lai thanh tien 
            txtThanhtien.Text = (Convert.ToInt32(txtThanhtien.Text) + tien).ToString();
            GetHDCTByIDHD(sMaHD);
            con.Close();
        }
    }
}
    
    