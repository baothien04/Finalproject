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
    public partial class trangchu : Form
    {
        public trangchu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Xử lý đăng xuất
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng form hiện tại
                // Mở lại form đăng nhập nếu cần
                // new LoginForm().Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Xử lý khi nhấn nút HOME
            MessageBox.Show("Bạn đang ở trang chủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Mở form sản phẩm
            ProductForm productForm = new ProductForm();
            productForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Hiển thị thông tin ứng dụng hoặc trợ giúp
            MessageBox.Show("Ứng dụng Quản lý cửa hàng trang sức\nPhiên bản 1.0\nHỗ trợ: support@jewelryshop.com", "Giới thiệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Mở form thông tin khách hàng
            CustomerInfoForm customerForm = new CustomerInfoForm();
            customerForm.Show();
        }
    }
}
