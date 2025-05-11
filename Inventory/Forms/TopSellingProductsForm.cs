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
    public partial class TopSellingProductsForm : Form
    {
        private DatabaseHelper dbHelper;
        public TopSellingProductsForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            LoadTopProducts();

        }
        private void LoadTopProducts()
        {
            string query = @"
SELECT TOP 10 P.ProductID, P.ProductName, SUM(SID.Quantity) as TotalSold
FROM Products P
JOIN SalesInvoiceDetails SID ON P.ProductID = SID.ProductID
GROUP BY P.ProductID, P.ProductName
ORDER BY TotalSold DESC";
            DataTable dt = dbHelper.ExecuteQuery(query);
            dataGridViewTopProducts.DataSource = dt;
        }
    }
}
