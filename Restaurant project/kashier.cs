using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_project
{
    public partial class kashier : Form
    {
        public kashier()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategories();
            dgvOrderList.BackgroundColor = Color.White;
            dgvOrderList.BorderStyle = BorderStyle.None;
            dgvOrderList.RowHeadersVisible = false; 
            dgvOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            dgvOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
            dgvOrderList.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrderList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrderList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

      

        private void LoadCategories()
        {
            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {
                string query = "SELECT id, cat_name FROM Category";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                flp.Controls.Clear();

                while (reader.Read())
                {
                    Button btnCat = new Button();
                    btnCat.Text = reader["cat_name"].ToString();
                    int catId = Convert.ToInt32(reader["id"]);

                    btnCat.Text = reader["cat_name"].ToString().ToUpper(); 
                    btnCat.Size = new Size(140, 60); 
                    btnCat.BackColor = Color.FromArgb(52, 152, 219); 
                    btnCat.ForeColor = Color.White;
                    btnCat.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                    btnCat.FlatStyle = FlatStyle.Flat;
                    btnCat.FlatAppearance.BorderSize = 0; 
                    btnCat.Cursor = Cursors.Hand; 
                    btnCat.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
                    
                    btnCat.Click += (s, e) => {
                        LoadMealsByCategory(catId);
                    };

                    flp.Controls.Add(btnCat);
                }
            }
        }

        private void LoadMealsByCategory(int catId)
        {
            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {
                string query = "SELECT meal_id,meal_name, price FROM Menu WHERE cat_id = @catId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@catId", catId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                flp.Controls.Clear();

                while (reader.Read())
                {
                    Button btnMeal = new Button();
                    string name = reader["meal_name"].ToString();
                    decimal price = Convert.ToDecimal(reader["price"]);
                    int mId = Convert.ToInt32(reader["meal_id"]);

                    btnMeal.Tag = reader["meal_id"];
                    btnMeal.Text = name + "\n" + price + " EGP";
                    btnMeal.Size = new Size(160, 100);
                    btnMeal.BackColor = Color.FromArgb(230, 126, 34); 
                    btnMeal.ForeColor = Color.White;
                    btnMeal.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    btnMeal.FlatStyle = FlatStyle.Flat;
                    btnMeal.FlatAppearance.BorderSize = 0;
                    btnMeal.Cursor = Cursors.Hand;
                    btnMeal.FlatAppearance.MouseOverBackColor = Color.FromArgb(211, 84, 0);

                    btnMeal.Click += (s, ev) => {
                        bool found = false;

                        foreach (DataGridViewRow row in dgvOrderList.Rows)
                        {
                            if (row.Cells[3].Value != null && row.Cells[3].Value.ToString() == mId.ToString())
                            {
                                int currentQty = Convert.ToInt32(row.Cells[2].Value);
                                int newQty = currentQty + 1;

                                row.Cells[2].Value = newQty; 

                                row.Cells[1].Value = (newQty * price).ToString("N2");

                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            dgvOrderList.Rows.Add(name, price.ToString("N2"), 1, mId);
                        }

                        CalculateTotal();
                    };
                        flp.Controls.Add(btnMeal);
                }
            }
        }
        private void CalculateTotal()
        {
            double total = 0;

            foreach (DataGridViewRow row in dgvOrderList.Rows)
            {
                if (row.Cells["colPrice"].Value != null)
                {
                    total += Convert.ToDouble(row.Cells["colPrice"].Value);
                }
            }

            lblTotalPrice.Text = total.ToString("N2");
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
        
            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    string sqlOrder = "INSERT INTO [Order] (Date, total_price) OUTPUT INSERTED.id VALUES (GETDATE(), @total)";
                    SqlCommand cmdOrder = new SqlCommand(sqlOrder, conn, tran);

                    cmdOrder.Parameters.AddWithValue("@total", Convert.ToDecimal(lblTotalPrice.Text));

                    int newOrderId = (int)cmdOrder.ExecuteScalar();

                    foreach (DataGridViewRow row in dgvOrderList.Rows)
                    {
                        if (row.Cells["colName"].Value != null) 
                        {
                            string sqlItems = "INSERT INTO Sold_Items (order_id, meal_id, quantity, item_price) VALUES (@oid, @mid, @qty, @price)";
                            SqlCommand cmdItems = new SqlCommand(sqlItems, conn, tran);

                            cmdItems.Parameters.AddWithValue("@oid", newOrderId); 
                            cmdItems.Parameters.AddWithValue("@mid", row.Cells[3].Value);
                            cmdItems.Parameters.AddWithValue("@qty", row.Cells["colQty"].Value);
                            cmdItems.Parameters.AddWithValue("@price", Convert.ToDecimal(row.Cells["colPrice"].Value));

                            cmdItems.ExecuteNonQuery();
                        }
                    }

                    tran.Commit();
                    MessageBox.Show("The order has been sent");

                    dgvOrderList.Rows.Clear();
                    lblTotalPrice.Text = "0.00";
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("ERROR " + ex.Message);
                }
            }
        }

        private void dgvOrderList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvOrderList.Rows)
            {
                if (row.Cells["colPrice"].Value != null)
                    total += Convert.ToDecimal(row.Cells["colPrice"].Value);
            }
            lblTotalPrice.Text = total.ToString("N2");
        }

        private void flpCat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeleteRow_Click_1(object sender, EventArgs e)
        {
            if (dgvOrderList.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvOrderList.SelectedRows)
                {
                    dgvOrderList.Rows.Remove(row);
                }

                CalculateTotal();
            }
            else
            {
                MessageBox.Show("Select row first");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            flp.Controls.Clear();
            LoadCategories();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform login = new loginform();
            login.ShowDialog(); 
            this.Close();
        }
    }
}
