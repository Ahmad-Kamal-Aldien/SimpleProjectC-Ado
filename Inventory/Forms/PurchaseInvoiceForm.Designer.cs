namespace Inventory.Forms
{
    partial class PurchaseInvoiceForm
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
            dateTimePickerInvoiceDate = new DateTimePicker();
            label5 = new Label();
            txtSupplierName = new TextBox();
            button1 = new Button();
            label2 = new Label();
            txtTotalAmount = new TextBox();
            label4 = new Label();
            txtPurchasePrice = new TextBox();
            label3 = new Label();
            txtQuantity = new TextBox();
            AddDetail = new Button();
            label1 = new Label();
            comboBoxProducts = new ComboBox();
            dataGridViewDetails = new DataGridView();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetails).BeginInit();
            SuspendLayout();
            // 
            // dateTimePickerInvoiceDate
            // 
            dateTimePickerInvoiceDate.Location = new Point(39, 172);
            dateTimePickerInvoiceDate.Name = "dateTimePickerInvoiceDate";
            dateTimePickerInvoiceDate.Size = new Size(225, 23);
            dateTimePickerInvoiceDate.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(720, 81);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 51;
            label5.Text = "اسم المورد";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(424, 75);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(281, 23);
            txtSupplierName.TabIndex = 50;
            txtSupplierName.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(672, 415);
            button1.Name = "button1";
            button1.Size = new Size(118, 38);
            button1.TabIndex = 49;
            button1.Text = "حفظ الفاتوره";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(212, 428);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 48;
            label2.Text = "الاجمالي";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalAmount.ForeColor = Color.Red;
            txtTotalAmount.Location = new Point(38, 411);
            txtTotalAmount.Multiline = true;
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(168, 42);
            txtTotalAmount.TabIndex = 47;
            txtTotalAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(342, 78);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 46;
            label4.Text = "سعر الشراء";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(38, 78);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(281, 23);
            txtPurchasePrice.TabIndex = 45;
            txtPurchasePrice.TextAlign = HorizontalAlignment.Center;
            txtPurchasePrice.KeyPress += txtPurchasePrice_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(358, 129);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 44;
            label3.Text = "الكميه";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(38, 126);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(281, 23);
            txtQuantity.TabIndex = 43;
            txtQuantity.TextAlign = HorizontalAlignment.Center;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            // 
            // AddDetail
            // 
            AddDetail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddDetail.Location = new Point(374, 172);
            AddDetail.Name = "AddDetail";
            AddDetail.Size = new Size(103, 45);
            AddDetail.TabIndex = 42;
            AddDetail.Text = "اضافه";
            AddDetail.UseVisualStyleBackColor = true;
            AddDetail.Click += AddDetail_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(720, 129);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 41;
            label1.Text = "اسم المنتج";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxProducts
            // 
            comboBoxProducts.FormattingEnabled = true;
            comboBoxProducts.Location = new Point(424, 126);
            comboBoxProducts.Name = "comboBoxProducts";
            comboBoxProducts.Size = new Size(281, 23);
            comboBoxProducts.TabIndex = 40;
            // 
            // dataGridViewDetails
            // 
            dataGridViewDetails.AllowUserToAddRows = false;
            dataGridViewDetails.AllowUserToDeleteRows = false;
            dataGridViewDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetails.Location = new Point(5, 223);
            dataGridViewDetails.Name = "dataGridViewDetails";
            dataGridViewDetails.Size = new Size(775, 169);
            dataGridViewDetails.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(317, 9);
            label6.Name = "label6";
            label6.Size = new Size(234, 32);
            label6.TabIndex = 53;
            label6.Text = "شاشه اداره المشتريات";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PurchaseInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 469);
            Controls.Add(label6);
            Controls.Add(dateTimePickerInvoiceDate);
            Controls.Add(label5);
            Controls.Add(txtSupplierName);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtTotalAmount);
            Controls.Add(label4);
            Controls.Add(txtPurchasePrice);
            Controls.Add(label3);
            Controls.Add(txtQuantity);
            Controls.Add(AddDetail);
            Controls.Add(label1);
            Controls.Add(comboBoxProducts);
            Controls.Add(dataGridViewDetails);
            Name = "PurchaseInvoiceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اداراه المشتريات";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerInvoiceDate;
        private Label label5;
        private TextBox txtSupplierName;
        private Button button1;
        private Label label2;
        private TextBox txtTotalAmount;
        private Label label4;
        private TextBox txtPurchasePrice;
        private Label label3;
        private TextBox txtQuantity;
        private Button AddDetail;
        private Label label1;
        private ComboBox comboBoxProducts;
        private DataGridView dataGridViewDetails;
        private Label label6;
    }
}