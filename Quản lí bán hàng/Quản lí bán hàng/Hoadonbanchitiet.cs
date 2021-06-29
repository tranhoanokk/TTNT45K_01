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
    public partial class Hoadonbanctiet : Form
    {
        public int MaHD { get; set; }
        string sCon = "Data Source=DESKTOP-BTBDGRO\\SQLEXPRESS;Initial Catalog=CuaHangTapHoa;Integrated Security=True";
        public Hoadonbanctiet(int k)
        {
            MaHD = k;
            InitializeComponent();
            SetGUI(k);
        }
        public void SetGUI(int k)
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
            string sQuery = "select * from HoaDonBan where MaHD = '" + k + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "HoaDonBan");
            //dataGridView1.DataSource = ds.Tables["HD_Ban_Chitiet"];
            DataTable dt = ds.Tables["HoaDonBan"];
            DataRow r = dt.Rows[0];
            txtThanhtien.Text = r["TongTien"].ToString();
            txtMaHDB.Text = r["MaHD"].ToString();


            string ssQuery = "select * from HD_Ban_Chitiet where MaHDB = '" + txtMaHDB.Text + "'";
            SqlDataAdapter sadapter = new SqlDataAdapter(ssQuery, con);
            DataSet dss = new DataSet();
            sadapter.Fill(dss, "HD_Ban_Chitiet");
            dataGridView1.DataSource = dss.Tables["HD_Ban_Chitiet"];
            con.Close();
        }
        public void ShoWHDCT()
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
            string sQuery = "select * from HD_Ban_Chitiet where MaHDB = '" + txtMaHDB.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "HD_Ban_Chitiet");
            dataGridView1.DataSource = ds.Tables["HD_Ban_Chitiet"];
            con.Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
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
                string sMaHDB = txtMaHDB.Text;
                string sDongia = txtDongiaban.Text;
                string sThanhtien = txtThanhtien.Text;
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
                txtThanhtien.Text = (Convert.ToInt32(txtThanhtien.Text) - tien).ToString();
                ShoWHDCT();
                con.Close();
            }
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
            string sQuery = "select * from Hang where MaH = '" + txtMaH.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Hang");
            DataTable dt = ds.Tables["Hang"];
            DataRow r = dt.Rows[0];
            txtTenhang.Text = r["TenH"].ToString();
            txtDongiaban.Text = r["Dongiaban"].ToString();
            con.Close();
        }

        private void btLuu_Click(object sender, EventArgs e)
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
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
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

            txtThanhtien.Text = (Convert.ToInt32(txtThanhtien.Text) + tien).ToString();
            ShoWHDCT();
            con.Close();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
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
                int slcu = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Soluongban"].Value.ToString());
                string sMahang = txtMaH.Text;
                string sDongia = txtDongiaban.Text;
                string sSlban = txtSlban.Text;
                int tien = Convert.ToInt32(sDongia) * Convert.ToInt32(sSlban);
                string sMaHDB = txtMaHDB.Text;
                string sMaH = txtMaH.Text;
                string squery = "update HD_Ban_Chitiet set Soluongban = @slban, Thanhtien = @tt where MaHDB = @MaHD and MaH = @MaH ";
                SqlCommand cmd = new SqlCommand(squery, con);
                cmd.Parameters.AddWithValue("@MaH", sMahang);
                cmd.Parameters.AddWithValue("@slban", sSlban);
                cmd.Parameters.AddWithValue("@tt", tien);
                cmd.Parameters.AddWithValue("@MaHD", sMaHDB);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình sửa!", "Thông báo");
                }
                int ttien = (slcu - Convert.ToInt32(sSlban)) * Convert.ToInt32(sDongia);
                txtThanhtien.Text = (Convert.ToInt32(txtThanhtien.Text) - ttien).ToString();
                ShoWHDCT();
                con.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            string sQuery = "select * from Hang where MaH = '" + txtMaH.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Hang");
            DataTable dt = ds.Tables["Hang"];
            DataRow r = dt.Rows[0];
            txtTenhang.Text = r["TenH"].ToString();
            txtDongiaban.Text = r["Dongiaban"].ToString();
            con.Close();
        }

        private void txtMaH_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hoadonbanctiet_Load(object sender, EventArgs e)
        {

        }
    }
}

