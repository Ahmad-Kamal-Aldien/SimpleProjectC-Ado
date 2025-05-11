using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Inventory.Helpers;

namespace Inventory.Forms
{
    public partial class SalesInvoiceSearchForm : Form
    {
        private DatabaseHelper dbHelper;
        public SalesInvoiceSearchForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            LoadInvoices();
        }
        private void LoadInvoices()
        {
            DataTable dt = dbHelper.ExecuteQuery("SELECT * FROM SalesInvoices");
            dataGridViewInvoices.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SalesInvoices WHERE 1=1";
            if (!string.IsNullOrEmpty(txtInvoiceID.Text))
                query += $" AND InvoiceID = {txtInvoiceID.Text}";
            if (checkBoxDate.Checked)
                query += $" AND InvoiceDate = '{dateTimePickerInvoiceDate.Value.ToString("yyyy-MM-dd")}'";
            DataTable dt = dbHelper.ExecuteQuery(query);
            dataGridViewInvoices.DataSource = dt;
        }

        private void dataGridViewInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int invoiceID = Convert.ToInt32(dataGridViewInvoices.Rows[e.RowIndex].Cells["InvoiceID"].Value);
                DataTable dt = dbHelper.ExecuteQuery($"SELECT * FROM SalesInvoiceDetails WHERE InvoiceID = {invoiceID}");
                dataGridViewDetails.DataSource = dt;
            }
        }
    }
}
    
