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

namespace Quản_lí_bán_hàng
{
    public partial class frmHanghoa : Form
    {
        string sCon="Data Source=DESKTOP-BTBDGRO\\SQLEXPRESS;Initial Catalog=CuaHangTapHoa;Integrated Security=True";
        public frmHanghoa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmHanghoa_Load(object sender, EventArgs e)
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
            string sQuery = "select * from hang";
            SqlDataAdapter adapter= new SqlDataAdapter(sQuery,con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "HangHoa");
            dataGridView1.DataSource = ds.Tables["HangHoa"];
            con.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkInforIsEmpty(txtMahang.Text) || checkInforIsEmpty(txtTenhang.Text) || checkInforIsEmpty(txtSLton.Text) || checkInforIsEmpty(txtGianhap.Text) || checkInforIsEmpty(txtGiaban.Text))
            {
                MessageBox.Show("Có thông tin chưa nhập, vui lòng nhập lại", "Thông báo");
                return;
            }
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối Database!", "Thông báo");
            }
            string sMahang = txtMahang.Text;
            string sTenhang = txtTenhang.Text;
            string sSLton = txtSLton.Text;
            string sGianhap = txtGianhap.Text;
            string sGiaBan = txtGiaban.Text;

            string sQuery = "Insert dbo.Hang values(@MaH,@TenH,@Soluonglon,@Dongianhap,@Dongiaban)";
            SqlCommand cmd = new SqlCommand(sQuery,con);
            cmd.Parameters.AddWithValue("@MaH", sMahang);
            cmd.Parameters.AddWithValue("@TenH", sTenhang);
            cmd.Parameters.AddWithValue("@Soluonglon", sSLton);
            cmd.Parameters.AddWithValue("@Dongianhap", sGianhap);
            cmd.Parameters.AddWithValue("@Dongiaban", sGiaBan);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới!", "Thông báo");
            }
            con.Close();
        }
        private bool checkInforIsEmpty(String str)
        {
            if (str == "")
            {

                return true;
            }
            return false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMahang.Text = dataGridView1.Rows[e.RowIndex].Cells["MaH"].Value.ToString();
            txtTenhang.Text = dataGridView1.Rows[e.RowIndex].Cells["TenH"].Value.ToString();
            txtSLton.Text = dataGridView1.Rows[e.RowIndex].Cells["Soluonglon"].Value.ToString();
            txtGianhap.Text = dataGridView1.Rows[e.RowIndex].Cells["Dongianhap"].Value.ToString();
            txtGiaban.Text = dataGridView1.Rows[e.RowIndex].Cells["Dongiaban"].Value.ToString();

            
        }

        private void btnSua_Click(object sender, EventArgs e)
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
            string sMahang = txtMahang.Text;
            string sTenhang = txtTenhang.Text;
            string sSLton = txtSLton.Text;
            string sGianhap = txtGianhap.Text;
            string sGiaBan = txtGiaban.Text;

            string sQuery = "update dbo.Hang set TenH=@TenH,Soluonglon=@Soluonglon, Dongianhap=@Dongianhap,Dongiaban=@Dongiaban where MaH=@MaH";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaH", sMahang);
            cmd.Parameters.AddWithValue("@TenH", sTenhang);
            cmd.Parameters.AddWithValue("@Soluonglon", sSLton);
            cmd.Parameters.AddWithValue("@Dongianhap", sGianhap);
            cmd.Parameters.AddWithValue("@Dongiaban", sGiaBan);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật!", "Thông báo");
            }
            con.Close();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
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
                string sMahang = txtMahang.Text;
                string sQuery = "delete Hang where Mah=@MaH";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@MaH", sMahang);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình xóa!", "Thông báo");
                }
                con.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
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
            txtGiaban.Text = "";
            txtGianhap.Text = "";
            txtMahang.Text = "";
            txtSLton.Text = "";
            txtTenhang.Text = "";
            txtTimkiem.Text = "";
            string sQuery = "select * from hang";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "HangHoa");
            dataGridView1.DataSource = ds.Tables["HangHoa"];
            con.Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
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
            string sTenhang = txtTimkiem.Text;
            string sQuery = "select * from dbo.Hang where UPPER(tenH) like  UPPER(N'%" + sTenhang + "%')";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "HangHoaTimKiem");
                if (ds.Tables["HangHoaTimKiem"].Rows.Count == 0)
                {
                    MessageBox.Show("Không có kết quả tìm kiếm", "Thông báo");
                }
                else
                {
                    dataGridView1.DataSource = ds.Tables["HangHoaTimKiem"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình tìm kiếm!", "Thông báo");
               
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
            txtTimkiem.Text = "";
            string sQuery = "select * from hang";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "HangHoa");
            dataGridView1.DataSource = ds.Tables["HangHoa"];
            con.Close();
        }
    }
}
