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


namespace finalproject
{
    public partial class sanpham : Form
    {
        SqlConnection conn = new SqlConnection("your_connection_string_here");

        public sanpham()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO SanPham (MaSP, TenSP, Gia, SoLuong) VALUES (@MaSP, @TenSP, @Gia, @SoLuong)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaSP", txt_masp.Text);
                cmd.Parameters.AddWithValue("@TenSP", txt_tensp.Text);
                cmd.Parameters.AddWithValue("@Gia", txt_gia.Text);
                cmd.Parameters.AddWithValue("@SoLuong", txt_soluong.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string query = "UPDATE SanPham SET TenSP = @TenSP, Gia = @Gia, SoLuong = @SoLuong WHERE MaSP = @MaSP";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaSP", txt_masp.Text);
                cmd.Parameters.AddWithValue("@TenSP", txt_tensp.Text);
                cmd.Parameters.AddWithValue("@Gia", txt_gia.Text);
                cmd.Parameters.AddWithValue("@SoLuong", txt_soluong.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            LoadData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM SanPham WHERE MaSP = @MaSP";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaSP", txt_masp.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            LoadData();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SanPham WHERE TenSP LIKE @TenSP";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TenSP", "%" + txt_timkiem.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_sanpham.DataSource = dt;
            }
        }

        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM SanPham";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_sanpham.DataSource = dt;
        }
    }
}
