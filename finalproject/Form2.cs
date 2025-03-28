using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YourNamespace
{
    public partial class Form2 : Form
    {
        private string connectionString = "your_connection_string_here"; // Thay thế bằng chuỗi kết nối của bạn

        public Form2()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Products"; // Thay thế bằng bảng của bạn
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Products (Name, Price, Quantity) VALUES (@Name, @Price, @Quantity)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtProductName.Text);
                        cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text));
                        cmd.ExecuteNonQuery();
                    }
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE Products SET Name=@Name, Price=@Price, Quantity=@Quantity WHERE ID=@ID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", txtProductName.Text);
                            cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                            cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text));
                            cmd.Parameters.AddWithValue("@ID", id);
                            cmd.ExecuteNonQuery();
                        }
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Products WHERE ID=@ID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ID", id);
                            cmd.ExecuteNonQuery();
                        }
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtProductName.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                txtQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            }
        }
    }
}
