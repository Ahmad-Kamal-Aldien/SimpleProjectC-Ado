namespace Inventory.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUserManagement_Click = new Button();
            btnProductManagement = new Button();
            btnSalesInvoice = new Button();
            btnPurchaseInvoice = new Button();
            btnSalesInvoiceSearch = new Button();
            btnPurchaseInvoiceSearch = new Button();
            btnTopSellingProducts = new Button();
            SuspendLayout();
            // 
            // btnUserManagement_Click
            // 
            btnUserManagement_Click.Location = new Point(531, 81);
            btnUserManagement_Click.Name = "btnUserManagement_Click";
            btnUserManagement_Click.Size = new Size(150, 52);
            btnUserManagement_Click.TabIndex = 0;
            btnUserManagement_Click.Text = "اداره المستخدمين";
            btnUserManagement_Click.UseVisualStyleBackColor = true;
            btnUserManagement_Click.Click += btnUserManagement_Click_Click;
            // 
            // btnProductManagement
            // 
            btnProductManagement.Location = new Point(531, 185);
            btnProductManagement.Name = "btnProductManagement";
            btnProductManagement.Size = new Size(150, 52);
            btnProductManagement.TabIndex = 1;
            btnProductManagement.Text = "اداره المنتجات";
            btnProductManagement.UseVisualStyleBackColor = true;
            btnProductManagement.Click += btnProductManagement_Click;
            // 
            // btnSalesInvoice
            // 
            btnSalesInvoice.Location = new Point(531, 286);
            btnSalesInvoice.Name = "btnSalesInvoice";
            btnSalesInvoice.Size = new Size(150, 52);
            btnSalesInvoice.TabIndex = 2;
            btnSalesInvoice.Text = "فاتوره مبيعات";
            btnSalesInvoice.UseVisualStyleBackColor = true;
            btnSalesInvoice.Click += btnSalesInvoice_Click;
            // 
            // btnPurchaseInvoice
            // 
            btnPurchaseInvoice.Location = new Point(313, 81);
            btnPurchaseInvoice.Name = "btnPurchaseInvoice";
            btnPurchaseInvoice.Size = new Size(150, 52);
            btnPurchaseInvoice.TabIndex = 3;
            btnPurchaseInvoice.Text = "فاتوره مشرتريات";
            btnPurchaseInvoice.UseVisualStyleBackColor = true;
            btnPurchaseInvoice.Click += btnPurchaseInvoice_Click;
            // 
            // btnSalesInvoiceSearch
            // 
            btnSalesInvoiceSearch.Location = new Point(313, 185);
            btnSalesInvoiceSearch.Name = "btnSalesInvoiceSearch";
            btnSalesInvoiceSearch.Size = new Size(150, 52);
            btnSalesInvoiceSearch.TabIndex = 4;
            btnSalesInvoiceSearch.Text = "بحث فواتبر مبيعات";
            btnSalesInvoiceSearch.UseVisualStyleBackColor = true;
            btnSalesInvoiceSearch.Click += btnSalesInvoiceSearch_Click;
            // 
            // btnPurchaseInvoiceSearch
            // 
            btnPurchaseInvoiceSearch.Location = new Point(313, 286);
            btnPurchaseInvoiceSearch.Name = "btnPurchaseInvoiceSearch";
            btnPurchaseInvoiceSearch.Size = new Size(150, 52);
            btnPurchaseInvoiceSearch.TabIndex = 5;
            btnPurchaseInvoiceSearch.Text = "بحث فواتبر مشتريات";
            btnPurchaseInvoiceSearch.UseVisualStyleBackColor = true;
            btnPurchaseInvoiceSearch.Click += btnPurchaseInvoiceSearch_Click;
            // 
            // btnTopSellingProducts
            // 
            btnTopSellingProducts.Location = new Point(105, 81);
            btnTopSellingProducts.Name = "btnTopSellingProducts";
            btnTopSellingProducts.Size = new Size(150, 52);
            btnTopSellingProducts.TabIndex = 6;
            btnTopSellingProducts.Text = "اعلي الاصناف مبيعا";
            btnTopSellingProducts.UseVisualStyleBackColor = true;
            btnTopSellingProducts.Click += btnTopSellingProducts_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTopSellingProducts);
            Controls.Add(btnPurchaseInvoiceSearch);
            Controls.Add(btnSalesInvoiceSearch);
            Controls.Add(btnPurchaseInvoice);
            Controls.Add(btnSalesInvoice);
            Controls.Add(btnProductManagement);
            Controls.Add(btnUserManagement_Click);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUserManagement_Click;
        private Button btnProductManagement;
        private Button btnSalesInvoice;
        private Button btnPurchaseInvoice;
        private Button btnSalesInvoiceSearch;
        private Button btnPurchaseInvoiceSearch;
        private Button btnTopSellingProducts;
    }
}