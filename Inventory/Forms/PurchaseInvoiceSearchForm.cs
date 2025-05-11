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
    public partial class PurchaseInvoiceSearchForm : Form
    {
        private DatabaseHelper dbHelper;
        public PurchaseInvoiceSearchForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            LoadInvoices();
        }
        private void LoadInvoices()
        {
            DataTable dt = dbHelper.ExecuteQuery("SELECT * FROM PurchaseInvoices");
            dataGridViewInvoices.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM PurchaseInvoices WHERE 1=1";
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
                DataTable dt = dbHelper.ExecuteQuery($"SELECT * FROM PurchaseInvoiceDetails WHERE InvoiceID = {invoiceID}");
                dataGridViewDetails.DataSource = dt;
            }
        }
    }
    }

