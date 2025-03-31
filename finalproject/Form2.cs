using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trangchu trangchu = new trangchu();
            this.Hide(); // Ẩn Form2
            trangchu.ShowDialog(); // Hiển thị FormTrangChu như một hộp thoại
            this.Show(); // Hiển thị lại Form2 nếu FormTrangChu đóng
        }

        private void button5_Click(object sender, EventArgs e)
        {
           TTkhachhang TTkhachhang = new TTkhachhang();
            this.Hide(); // Ẩn Form2
            TTkhachhang.ShowDialog(); // Hiển thị FormTTKhachHang như một hộp thoại
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sanpham sanpham = new sanpham();
            this.Hide(); // Ẩn Form2
            sanpham.ShowDialog(); // Hiển thị FormSanPham như một hộp thoại
            this.Show(); // Hiển thị lại Form2 nếu FormSanPham đóng
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Đăng xuất
            this.Close(); // Đóng Form2
        }

        
    }
}
