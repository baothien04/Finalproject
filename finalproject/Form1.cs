using System;
using System.Windows.Forms;

namespace finalproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Có thể thêm logic khởi tạo ở đây nếu cần
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ hộp văn bản
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            // Kiểm tra nếu thông tin nhập vào còn trống
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra thông tin đăng nhập
            if (username == "admin" && password == "123")
            {
                // Khởi tạo và hiển thị Form2 nếu thông tin đăng nhập đúng
                Form2 form2 = new Form2();
                this.Hide(); // Ẩn Form1
                form2.ShowDialog(); // Hiển thị Form2 như một hộp thoại
                this.Show(); // Hiển thị lại Form1 nếu Form2 đóng
            }
            else
            {
                // Hiển thị thông báo nếu thông tin đăng nhập sai
                MessageBox.Show("Sai tài khoản hoặc mật khẩu, vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            // Hiển thị hoặc ẩn mật khẩu
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Logic để mở Form đăng ký (Form2 hoặc một form khác)
            // Có thể thay đổi theo nhu cầu của bạn
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Đóng ứng dụng
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Lấy thông tin từ hộp văn bản
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            // Kiểm tra nếu thông tin nhập vào còn trống
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra thông tin đăng nhập
            if (username == "admin" && password == "123")
            {
                // Khởi tạo và hiển thị Form2 nếu thông tin đăng nhập đúng
                Form2 form2 = new Form2();
                this.Hide(); // Ẩn Form1
                form2.ShowDialog(); // Hiển thị Form2 như một hộp thoại
                this.Show(); // Hiển thị lại Form1 nếu Form2 đóng
            }
            else
            {
                // Hiển thị thông báo nếu thông tin đăng nhập sai
                MessageBox.Show("Sai tài khoản hoặc mật khẩu, vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Đóng ứng dụng
            Application.Exit();
        }

       
    }
}


