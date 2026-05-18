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

namespace Restaurant_project
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent(); 
            ApplyFullTheme();
        }

        private void ApplyFullTheme()
        {
            this.BackColor = Color.FromArgb(242, 245, 248);

            DataGridView[] grids = { dgvHistory, dgvOrderDetails };
            foreach (var g in grids)
            {
                if (g == null) continue;

                g.BackgroundColor = Color.White;
                g.BorderStyle = BorderStyle.None;
                g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                g.RowHeadersVisible = false;
                g.AllowUserToAddRows = false;
                g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                g.MultiSelect = false;

                g.EnableHeadersVisualStyles = false;
                g.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 52, 71); 
                g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                g.ColumnHeadersHeight = 40;

                g.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                g.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
                g.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 240, 254); 
                g.DefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 120, 215);
                g.RowTemplate.Height = 35;

                g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                g.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 251, 252);
            }

            lblOrdersCount.TextAlign = ContentAlignment.MiddleCenter;
            lblTotalSalesSum.TextAlign = ContentAlignment.MiddleCenter;
            lblmostOrderedmeal.TextAlign = ContentAlignment.MiddleCenter;

            lblOrdersCount.Font = new Font("Segoe UI Semibold", 20, FontStyle.Bold);
            lblTotalSalesSum.Font = new Font("Segoe UI Semibold", 20, FontStyle.Bold);
            lblmostOrderedmeal.Font = new Font("Segoe UI Semibold", 16, FontStyle.Bold);
        }

        private void LoadDataToDashboard(DateTime targetDate)
        {
            try
            {
                using (SqlConnection conn = DatabaseConfig.GetConnection())
                {
                    string query = "SELECT ID, Date, total_price FROM [Order] WHERE CAST(Date AS DATE) = @date ORDER BY Date DESC";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@date", targetDate.Date);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvHistory.DataSource = dt;
                    lblOrdersCount.Text = dt.Rows.Count.ToString();

                    decimal total = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["total_price"] != DBNull.Value)
                            total += Convert.ToDecimal(row["total_price"]);
                    }
                    lblTotalSalesSum.Text = total.ToString("N2") + " EGP";

                    GetMostRequestedMeal(targetDate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ في تحميل البيانات: " + ex.Message);
            }
        }

        private void GetMostRequestedMeal(DateTime targetDate)
        {
            try
            {
                using (SqlConnection conn = DatabaseConfig.GetConnection())
                {
                    string query = @"SELECT TOP 1 m.meal_name
                             FROM Sold_Items s
                             JOIN Menu m ON s.meal_id = m.meal_id
                             JOIN [Order] o ON s.order_id = o.ID
                             WHERE CAST(o.Date AS DATE) = @date
                             GROUP BY m.meal_name
                             ORDER BY SUM(s.quantity) DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@date", targetDate.Date);
                    conn.Open();

                    var result = cmd.ExecuteScalar();
                    lblmostOrderedmeal.Text = result != null ? result.ToString() : "No Orders";
                }
            }
            catch { lblmostOrderedmeal.Text = "No Orders"; }
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            ApplyFullTheme(); 
            LoadDataToDashboard(DateTime.Now);
        }

        private void dgvHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int orderId = Convert.ToInt32(dgvHistory.Rows[e.RowIndex].Cells[0].Value);
                LoadOrderItems(orderId);
            }
        }

        private void LoadOrderItems(int orderId)
        {
            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {
                string query = @"SELECT m.meal_name AS [The meal], 
                                s.item_price AS [Price], 
                                s.quantity AS [Quantity]
                         FROM Sold_Items s
                         JOIN Menu m ON s.meal_id = m.meal_id
                         WHERE s.order_id = @oid";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@oid", orderId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOrderDetails.DataSource = dt;
            }
        }

        private void dtpFilterDate_ValueChanged(object sender, EventArgs e)
        {
            LoadDataToDashboard(dtpFilterDate.Value);
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            loginform login = new loginform();
            login.Show();
            this.Close();
        }

       
    }
}