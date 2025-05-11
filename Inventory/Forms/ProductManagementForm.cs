using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.Helpers;

namespace Inventory.Forms
{
    public partial class ProductManagementForm : Form
    {
        private DatabaseHelper dbHelper;
        public ProductManagementForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            LoadProducts();
        }
        private void LoadProducts()
        {
            DataTable dt = dbHelper.ExecuteQuery("SELECT * FROM Products");
            dataGridViewProducts.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (txtProductName.Text.Trim() == "")
            {
                MessageBox.Show("من فضلك اكتب اسم المنتج");
                return;
            }
            if (txtQuantity.Text.Trim() == "")
            {
                MessageBox.Show("من فضلك اكتب  الكميه");
                return;
            }
            if (txtPurchasePrice.Text.Trim() == "")
            {
                MessageBox.Show("من فضلك اكتب  سعر الشراء");
                return;
            }
            if (txtSellingPrice.Text.Trim() == "")
            {
                MessageBox.Show("من فضلك اكتب  سعر البيع");
                return;
            }
            string query = $"INSERT INTO Products (ProductName, PurchasePrice, Quantity, SellingPrice) VALUES (N'{txtProductName.Text}', {txtPurchasePrice.Text}, {txtQuantity.Text}, {txtSellingPrice.Text})";
            dbHelper.ExecuteNonQuery(query);
            LoadProducts();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text.Trim() == "")
            {
                MessageBox.Show("من فضلك اكتب اسم المنتج");
                return;
            }
            if (txtQuantity.Text.Trim() == "")
            {
                MessageBox.Show("من فضلك اكتب  الكميه");
                return;
            }
            if (txtPurchasePrice.Text.Trim() == "")
            {
                MessageBox.Show("من فضلك اكتب  سعر الشراء");
                return;
            }
            if (txtSellingPrice.Text.Trim() == "")
            {
                MessageBox.Show("من فضلك اكتب  سعر البيع");
                return;
            }

            string query = $"UPDATE Products SET ProductName = N'{txtProductName.Text}', PurchasePrice = {txtPurchasePrice.Text}, Quantity = {txtQuantity.Text}, SellingPrice = {txtSellingPrice.Text} WHERE ProductID = {txtProductID.Text}";
            dbHelper.ExecuteNonQuery(query);
            LoadProducts();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "")
            {
                MessageBox.Show("من فضلك  اختر منتج");
                return;
            }
            DataTable dt = dbHelper.ExecuteQuery($"SELECT * FROM PurchaseInvoiceDetails where ProductID= {txtProductID.Text}");

            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("لا يمكنك حذف المنتج لوجود فواتير مشتريات له");

                return;
            }

            DataTable dtSale= dbHelper.ExecuteQuery($"SELECT * FROM SalesInvoiceDetails where ProductID= {txtProductID.Text}");

            if (dtSale.Rows.Count > 0)
            {
                MessageBox.Show("لا يمكنك حذف المنتج لوجود فواتير مبيعات له");

                return;
            }

            string query = $"DELETE FROM Products WHERE ProductID = {txtProductID.Text}";
            dbHelper.ExecuteNonQuery(query);
            LoadProducts();
            ClearFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Products WHERE ProductName LIKE '%{txtSearch.Text}%'";
            DataTable dt = dbHelper.ExecuteQuery(query);
            dataGridViewProducts.DataSource = dt;
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProducts.Rows[e.RowIndex];
                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                txtPurchasePrice.Text = row.Cells["PurchasePrice"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                txtSellingPrice.Text = row.Cells["SellingPrice"].Value.ToString();
            }
        }
        private void ClearFields()
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtPurchasePrice.Text = "";
            txtQuantity.Text = "";
            txtSellingPrice.Text = "";
            txtSearch.Text = "";
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtSellingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
