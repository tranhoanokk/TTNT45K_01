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
    public partial class frmHoadon : Form
    {
        string scon = "Data Source=DESKTOP-BTBDGRO\\SQLEXPRESS;Initial Catalog=CuaHangTapHoa;Integrated Security=True";

        public frmHoadon()
        {
            InitializeComponent();
        }

        public void ShowHD()
        {
            SqlConnection con = new SqlConnection(scon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu!", "Thông Báo");
            }
            string sQuery = "select * from HoaDonBan";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "HoaDonBan");
            dataGridView1.DataSource = ds.Tables["HoaDonBan"];
            con.Close();
        }
        private void frmHoadon_Load(object sender, EventArgs e)
        {
            ShowHD();
        }

        private void btthem(object sender, EventArgs e)
        {

            if (txtMaHD.Text != "")
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
                string sTongtien = txtTongtien.Text;
                string sNgayban = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string sGioban = dateTimePicker2.Value.ToString("hh:mm tt");

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
            txtMaHD.Text = dataGridView1.Rows[e.RowIndex].Cells["MaHD"].Value.ToString();
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
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int MaHD = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MaHD"].Value.ToString());
                Hoadonbanctiet f = new Hoadonbanctiet(MaHD);
                f.ShowDialog();
                ShowHD();
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
        }
    }
}
