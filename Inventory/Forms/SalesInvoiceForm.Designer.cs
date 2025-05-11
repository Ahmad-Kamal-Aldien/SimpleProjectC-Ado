namespace Inventory.Forms
{
    partial class SalesInvoiceForm
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
            dataGridViewDetails = new DataGridView();
            comboBoxProducts = new ComboBox();
            label1 = new Label();
            AddDetail = new Button();
            label4 = new Label();
            txtSellingPrice = new TextBox();
            label3 = new Label();
            txtQuantity = new TextBox();
            txtTotalAmount = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label5 = new Label();
            txtCustomerName = new TextBox();
            dateTimePickerInvoiceDate = new DateTimePicker();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetails).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDetails
            // 
            dataGridViewDetails.AllowUserToAddRows = false;
            dataGridViewDetails.AllowUserToDeleteRows = false;
            dataGridViewDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetails.Location = new Point(3, 239);
            dataGridViewDetails.Name = "dataGridViewDetails";
            dataGridViewDetails.Size = new Size(785, 169);
            dataGridViewDetails.TabIndex = 2;
            // 
            // comboBoxProducts
            // 
            comboBoxProducts.FormattingEnabled = true;
            comboBoxProducts.Location = new Point(418, 138);
            comboBoxProducts.Name = "comboBoxProducts";
            comboBoxProducts.Size = new Size(281, 23);
            comboBoxProducts.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(714, 141);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 21;
            label1.Text = "اسم المنتج";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddDetail
            // 
            AddDetail.Location = new Point(352, 199);
            AddDetail.Name = "AddDetail";
            AddDetail.Size = new Size(103, 23);
            AddDetail.TabIndex = 22;
            AddDetail.Text = "اضافه";
            AddDetail.UseVisualStyleBackColor = true;
            AddDetail.Click += AddDetail_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(336, 90);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 32;
            label4.Text = "سعر البيع";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.Location = new Point(32, 90);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.Size = new Size(281, 23);
            txtSellingPrice.TabIndex = 31;
            txtSellingPrice.TextAlign = HorizontalAlignment.Center;
            txtSellingPrice.KeyPress += txtSellingPrice_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(352, 141);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 30;
            label3.Text = "الكميه";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(32, 138);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(281, 23);
            txtQuantity.TabIndex = 29;
            txtQuantity.TextAlign = HorizontalAlignment.Center;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.ForeColor = Color.Red;
            txtTotalAmount.Location = new Point(18, 428);
            txtTotalAmount.Multiline = true;
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(168, 40);
            txtTotalAmount.TabIndex = 33;
            txtTotalAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(192, 439);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 34;
            label2.Text = "الاجمالي";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(632, 428);
            button1.Name = "button1";
            button1.Size = new Size(113, 40);
            button1.TabIndex = 35;
            button1.Text = "حفظ الفاتوره";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(714, 93);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 37;
            label5.Text = "اسم العميل";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(418, 87);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(281, 23);
            txtCustomerName.TabIndex = 36;
            txtCustomerName.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTimePickerInvoiceDate
            // 
            dateTimePickerInvoiceDate.Location = new Point(18, 180);
            dateTimePickerInvoiceDate.Name = "dateTimePickerInvoiceDate";
            dateTimePickerInvoiceDate.Size = new Size(225, 23);
            dateTimePickerInvoiceDate.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(318, 24);
            label6.Name = "label6";
            label6.Size = new Size(165, 32);
            label6.TabIndex = 39;
            label6.Text = "شاشه المبيعات";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SalesInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 480);
            Controls.Add(label6);
            Controls.Add(dateTimePickerInvoiceDate);
            Controls.Add(label5);
            Controls.Add(txtCustomerName);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtTotalAmount);
            Controls.Add(label4);
            Controls.Add(txtSellingPrice);
            Controls.Add(label3);
            Controls.Add(txtQuantity);
            Controls.Add(AddDetail);
            Controls.Add(label1);
            Controls.Add(comboBoxProducts);
            Controls.Add(dataGridViewDetails);
            Name = "SalesInvoiceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "المبيعات";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewDetails;
        private ComboBox comboBoxProducts;
        private Label label1;
        private Button AddDetail;
        private Label label4;
        private TextBox txtSellingPrice;
        private Label label3;
        private TextBox txtQuantity;
        private TextBox txtTotalAmount;
        private Label label2;
        private Button button1;
        private Label label5;
        private TextBox txtCustomerName;
        private DateTimePicker dateTimePickerInvoiceDate;
        private Label label6;
    }
}