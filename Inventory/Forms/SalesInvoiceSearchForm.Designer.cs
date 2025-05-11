namespace Inventory.Forms
{
    partial class SalesInvoiceSearchForm
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
            dataGridViewInvoices = new DataGridView();
            btnSearch = new Button();
            label5 = new Label();
            txtInvoiceID = new TextBox();
            checkBoxDate = new CheckBox();
            dataGridViewDetails = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dateTimePickerInvoiceDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetails).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewInvoices
            // 
            dataGridViewInvoices.AllowUserToAddRows = false;
            dataGridViewInvoices.AllowUserToDeleteRows = false;
            dataGridViewInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInvoices.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInvoices.Location = new Point(17, 84);
            dataGridViewInvoices.Name = "dataGridViewInvoices";
            dataGridViewInvoices.Size = new Size(751, 81);
            dataGridViewInvoices.TabIndex = 40;
            dataGridViewInvoices.CellClick += dataGridViewInvoices_CellClick;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(39, 23);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(103, 23);
            btnSearch.TabIndex = 43;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(720, 18);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 53;
            label5.Text = "رقم الفاتوره";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtInvoiceID
            // 
            txtInvoiceID.Location = new Point(524, 12);
            txtInvoiceID.Name = "txtInvoiceID";
            txtInvoiceID.Size = new Size(181, 23);
            txtInvoiceID.TabIndex = 52;
            txtInvoiceID.TextAlign = HorizontalAlignment.Center;
            // 
            // checkBoxDate
            // 
            checkBoxDate.AutoSize = true;
            checkBoxDate.Location = new Point(220, 23);
            checkBoxDate.Name = "checkBoxDate";
            checkBoxDate.Size = new Size(61, 19);
            checkBoxDate.TabIndex = 54;
            checkBoxDate.Text = "بالتاريخ";
            checkBoxDate.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDetails
            // 
            dataGridViewDetails.AllowUserToAddRows = false;
            dataGridViewDetails.AllowUserToDeleteRows = false;
            dataGridViewDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetails.Location = new Point(17, 208);
            dataGridViewDetails.Name = "dataGridViewDetails";
            dataGridViewDetails.Size = new Size(751, 209);
            dataGridViewDetails.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(373, 66);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 56;
            label1.Text = "الفواتير";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(344, 180);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 57;
            label2.Text = "تفاصيل الفوايتر";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerInvoiceDate
            // 
            dateTimePickerInvoiceDate.Location = new Point(309, 18);
            dateTimePickerInvoiceDate.Name = "dateTimePickerInvoiceDate";
            dateTimePickerInvoiceDate.Size = new Size(200, 23);
            dateTimePickerInvoiceDate.TabIndex = 58;
            // 
            // SalesInvoiceSearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 446);
            Controls.Add(dateTimePickerInvoiceDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewDetails);
            Controls.Add(checkBoxDate);
            Controls.Add(label5);
            Controls.Add(txtInvoiceID);
            Controls.Add(btnSearch);
            Controls.Add(dataGridViewInvoices);
            Name = "SalesInvoiceSearchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalesInvoiceSearchForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoices).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewInvoices;
        private Button btnSearch;
        private Label label5;
        private TextBox txtInvoiceID;
        private CheckBox checkBoxDate;
        private DataGridView dataGridViewDetails;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePickerInvoiceDate;
    }
}