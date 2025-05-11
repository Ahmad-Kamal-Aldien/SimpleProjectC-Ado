using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.Helpers;

namespace Inventory.Forms
{
    public partial class SalesInvoiceForm : Form
    {
        private DatabaseHelper dbHelper;
        private DataTable invoiceDetails;

        public SalesInvoiceForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            invoiceDetails = new DataTable();
            invoiceDetails.Columns.Add("ProductID", typeof(int));
            invoiceDetails.Columns.Add("ProductName", typeof(string));
            invoiceDetails.Columns.Add("Quantity", typeof(int));
            invoiceDetails.Columns.Add("SellingPrice", typeof(decimal));
            dataGridViewDetails.DataSource = invoiceDetails;
            LoadProducts();

        }
        private void LoadProducts()
        {
            DataTable dt = dbHelper.ExecuteQuery("SELECT ProductID, ProductName FROM Products");
            comboBoxProducts.DataSource = dt;
            comboBoxProducts.DisplayMember = "ProductName";
            comboBoxProducts.ValueMember = "ProductID";
        }

        private void AddDetail_Click(object sender, EventArgs e)
        {
            if (comboBoxProducts.SelectedValue == null)
            {
                MessageBox.Show("من فضلك اخنر اسم المنتج");
                return;
            }
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("من فضلك اكتب  الكميه");
                return;
            }

            if (txtSellingPrice.Text == "")
            {
                MessageBox.Show("من فضلك اكتب  سعر البيع");
                return;
            }

            DataRow row = invoiceDetails.NewRow();
            row["ProductID"] = comboBoxProducts.SelectedValue;
            row["ProductName"] = comboBoxProducts.Text;
            row["Quantity"] = txtQuantity.Text;
            row["SellingPrice"] = txtSellingPrice.Text;
            invoiceDetails.Rows.Add(row);
            CalculateTotal();
        }
        private void CalculateTotal()
        {
            decimal total = 0;
            foreach (DataRow row in invoiceDetails.Rows)
            {
                total += Convert.ToInt32(row["Quantity"]) * Convert.ToDecimal(row["SellingPrice"]);
            }
            txtTotalAmount.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction(); 

                try
                {
                    // حفظ Master
                    string query = $"INSERT INTO SalesInvoices (CustomerName, TotalAmount, InvoiceDate) OUTPUT INSERTED.InvoiceID VALUES (N'{txtCustomerName.Text}', {txtTotalAmount.Text}, '{dateTimePickerInvoiceDate.Value.ToString("yyyy-MM-dd")}')";
                    SqlCommand cmd = new SqlCommand(query, conn, transaction);
                    int invoiceID = (int)cmd.ExecuteScalar();

                    // حفظ Details
                    foreach (DataRow row in invoiceDetails.Rows)
                    {
                        query = $"INSERT INTO SalesInvoiceDetails (InvoiceID, ProductID, Quantity, SellingPrice) VALUES ({invoiceID}, {row["ProductID"]}, {row["Quantity"]}, {row["SellingPrice"]})";
                        cmd = new SqlCommand(query, conn, transaction);
                        cmd.ExecuteNonQuery();

                        // تحديث الكمية في جدول المنتجات
                        query = $"UPDATE Products SET Quantity = Quantity - {row["Quantity"]} WHERE ProductID = {row["ProductID"]}";
                        cmd = new SqlCommand(query, conn, transaction);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("تم حفظ الفاتورة بنجاح");
                    ClearFields();
                }
                catch
                {
                    transaction.Rollback();
                    MessageBox.Show("حدث خطأ أثناء حفظ الفاتورة");
                }

            }
        }
        private void ClearFields()
        {
            txtCustomerName.Text = "";
            txtTotalAmount.Text = "";
            invoiceDetails.Clear();
            dateTimePickerInvoiceDate.Value = DateTime.Now;
        }

        private void txtSellingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
