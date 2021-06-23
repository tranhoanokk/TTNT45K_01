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


namespace Quản_lí_bán_hàng
{
    public partial class frmHoadon : Form
    {
        string scon = "Data Source=LAPTOP-SMKPHOFO;Initial Catalog=CuaHangTapHoa;Integrated Security=True";// xau ket noi 
      
        public frmHoadon()
        {
            InitializeComponent();
        }

        public void ShowHD() // ham hien thi hoa don sau khi cap nhat 
        {
            SqlConnection con = new SqlConnection(scon); // khoi tao ket noi 
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu!", "Thông Báo");
            }
            string sQuery = "select * from HoaDonBan"; // su dung cau lenh SQL 
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con); // lấy dữ liệu về 
            DataSet ds = new DataSet();// khoi tao dataset , ds là bản sao của dữ liệu 
            adapter.Fill(ds, "HoaDonBan");// đẩy dữ liệu vào dataset
            dataGridView1.DataSource = ds.Tables["HoaDonBan"];// đổ dữ liệu vào datagridv
            con.Close(); // đóng kết nối 
        }
        private void frmHoadon_Load(object sender, EventArgs e)
        {
            ShowHD(); // hien thi hoa don 
        }

        private void btthem(object sender, EventArgs e)
        {
           
            if (txtMaHD.Text != "" ) 
            {
                SqlConnection con = new SqlConnection(scon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối Database!", "Thông báo");
                }
                //lấy dữ liệu 
                string sMaHD = txtMaHD.Text;
                string sTongtien = txtTongtien.Text;
                string sNgayban = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string sGioban = dateTimePicker2.Value.ToString("hh:mm tt");
                // sử dụng câu lệnh sql 
                string squery = "insert dbo.HoaDonBan values(@MaHD,@NgayBan,@Gioban,@Tongtien)";
                SqlCommand cmd = new SqlCommand(squery,con);
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
                ShowHD();
                con.Close();
            }
            else 
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn!", "Thông báo");
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối Database!", "Thông báo");
            }
            string sMaHD = txtMaHD.Text;
            string squery = "Delete HoaDonBan where MaHD = @MaHD";
            SqlCommand cmd = new SqlCommand(squery, con);
            cmd.Parameters.AddWithValue("@MaHD", sMaHD);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo");
            }
            catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu!", "Thông báo");
                }
            ShowHD();
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = dataGridView1.Rows[e.RowIndex].Cells["MaHD"].Value.ToString(); // vao dgv va chon hang e la chi so hang khi nguoi dung cua click, value la chuyen tu kieu text ve kieu chuoi 
            txtTongtien.Text = dataGridView1.Rows[e.RowIndex].Cells["Tongtien"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgayBan"].Value.ToString());
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Gioban"].Value.ToString());
        }

        private void btLưu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1) // chọn 1 hàng từ dữ liệu để thực hiện để sử dụng 
            {
                int MaHD = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MaHD"].Value.ToString()); //lấy dữ liệu mahd từ hàng được chọn 
                Hoadonbanctiet f = new Hoadonbanctiet(MaHD); // chuyển qua form hóa đơn chi tites bvowis tham số là mhd cần cs 
                f.ShowDialog(); // show form hdct 
                ShowHD(); // cap nhat lai ds hd sau khi cs 
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
