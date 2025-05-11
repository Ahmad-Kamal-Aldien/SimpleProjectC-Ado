namespace Inventory.Forms
{
    partial class PurchaseInvoiceSearchForm
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
            label2 = new Label();
            label1 = new Label();
            dataGridViewDetails = new DataGridView();
            checkBoxDate = new CheckBox();
            label5 = new Label();
            txtInvoiceID = new TextBox();
            btnSearch = new Button();
            dataGridViewInvoices = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoices).BeginInit();
            SuspendLayout();
            // 
            // dateTimePickerInvoiceDate
            // 
            dateTimePickerInvoiceDate.Location = new Point(294, 77);
            dateTimePickerInvoiceDate.Name = "dateTimePickerInvoiceDate";
            dateTimePickerInvoiceDate.Size = new Size(200, 23);
            dateTimePickerInvoiceDate.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(356, 230);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 66;
            label2.Text = "تفاصيل الفوايتر";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(371, 113);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 65;
            label1.Text = "الفواتير";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewDetails
            // 
            dataGridViewDetails.AllowUserToAddRows = false;
            dataGridViewDetails.AllowUserToDeleteRows = false;
            dataGridViewDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetails.Location = new Point(21, 259);
            dataGridViewDetails.Name = "dataGridViewDetails";
            dataGridViewDetails.Size = new Size(751, 169);
            dataGridViewDetails.TabIndex = 64;
            // 
            // checkBoxDate
            // 
            checkBoxDate.AutoSize = true;
            checkBoxDate.Location = new Point(227, 79);
            checkBoxDate.Name = "checkBoxDate";
            checkBoxDate.Size = new Size(61, 19);
            checkBoxDate.TabIndex = 63;
            checkBoxDate.Text = "بالتاريخ";
            checkBoxDate.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(669, 80);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 62;
            label5.Text = "رقم الفاتوره";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtInvoiceID
            // 
            txtInvoiceID.Location = new Point(500, 77);
            txtInvoiceID.Name = "txtInvoiceID";
            txtInvoiceID.Size = new Size(162, 23);
            txtInvoiceID.TabIndex = 61;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(92, 76);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(84, 32);
            btnSearch.TabIndex = 60;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridViewInvoices
            // 
            dataGridViewInvoices.AllowUserToAddRows = false;
            dataGridViewInvoices.AllowUserToDeleteRows = false;
            dataGridViewInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInvoices.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInvoices.Location = new Point(21, 142);
            dataGridViewInvoices.Name = "dataGridViewInvoices";
            dataGridViewInvoices.Size = new Size(751, 73);
            dataGridViewInvoices.TabIndex = 59;
            dataGridViewInvoices.CellClick += dataGridViewInvoices_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(301, 20);
            label3.Name = "label3";
            label3.Size = new Size(241, 32);
            label3.TabIndex = 68;
            label3.Text = "شاشه اداره  المشتريات";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PurchaseInvoiceSearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 446);
            Controls.Add(label3);
            Controls.Add(dateTimePickerInvoiceDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewDetails);
            Controls.Add(checkBoxDate);
            Controls.Add(label5);
            Controls.Add(txtInvoiceID);
            Controls.Add(btnSearch);
            Controls.Add(dataGridViewInvoices);
            Name = "PurchaseInvoiceSearchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اداره المشتريات";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerInvoiceDate;
        private Label label2;
        private Label label1;
        private DataGridView dataGridViewDetails;
        private CheckBox checkBoxDate;
        private Label label5;
        private TextBox txtInvoiceID;
        private Button btnSearch;
        private DataGridView dataGridViewInvoices;
        private Label label3;
    }
}