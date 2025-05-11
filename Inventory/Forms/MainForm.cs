using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnUserManagement_Click_Click(object sender, EventArgs e)
        {
            UserManagementForm form = new UserManagementForm();
            form.ShowDialog();
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            ProductManagementForm form = new ProductManagementForm();
            form.ShowDialog();
        }

        private void btnPurchaseInvoice_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceForm form = new PurchaseInvoiceForm();
            form.ShowDialog();
        }

        private void btnSalesInvoiceSearch_Click(object sender, EventArgs e)
        {
            SalesInvoiceSearchForm form = new SalesInvoiceSearchForm();
            form.ShowDialog();
        }

        private void btnPurchaseInvoiceSearch_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceSearchForm form = new PurchaseInvoiceSearchForm();
            form.ShowDialog();
        }

        private void btnTopSellingProducts_Click(object sender, EventArgs e)
        {
            TopSellingProductsForm form = new TopSellingProductsForm();
            form.ShowDialog();
        }

        private void btnSalesInvoice_Click(object sender, EventArgs e)
        {
            SalesInvoiceForm form = new SalesInvoiceForm();
            form.ShowDialog();
        }
    }
}
