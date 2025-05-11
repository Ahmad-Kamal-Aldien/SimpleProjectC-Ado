namespace Inventory.Forms
{
    partial class ProductManagementForm
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
            dataGridViewProducts = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            label3 = new Label();
            txtQuantity = new TextBox();
            label1 = new Label();
            txtProductName = new TextBox();
            lblid = new Label();
            txtProductID = new TextBox();
            label2 = new Label();
            txtPurchasePrice = new TextBox();
            label4 = new Label();
            txtSellingPrice = new TextBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(12, 97);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(426, 240);
            dataGridViewProducts.TabIndex = 1;
            dataGridViewProducts.CellClick += dataGridViewProducts_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11.25F);
            btnAdd.Location = new Point(725, 314);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 44);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "اضافه";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11.25F);
            btnDelete.Location = new Point(444, 314);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 44);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11.25F);
            btnUpdate.Location = new Point(595, 314);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(103, 44);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "تعديل";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(755, 166);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 24;
            label3.Text = "الكميه";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(457, 163);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(281, 23);
            txtQuantity.TabIndex = 23;
            txtQuantity.TextAlign = HorizontalAlignment.Center;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(752, 123);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 20;
            label1.Text = "اسم المنتج";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(457, 120);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(281, 23);
            txtProductName.TabIndex = 19;
            txtProductName.TextAlign = HorizontalAlignment.Center;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Segoe UI", 11.25F);
            lblid.Location = new Point(755, 79);
            lblid.Name = "lblid";
            lblid.Size = new Size(72, 20);
            lblid.TabIndex = 18;
            lblid.Text = "رقم المنتج";
            lblid.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(457, 79);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(281, 23);
            txtProductID.TabIndex = 17;
            txtProductID.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(752, 206);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 26;
            label2.Text = "سعر الشراء";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(457, 206);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(281, 23);
            txtPurchasePrice.TabIndex = 25;
            txtPurchasePrice.TextAlign = HorizontalAlignment.Center;
            txtPurchasePrice.KeyPress += txtPurchasePrice_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(752, 262);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 28;
            label4.Text = "سعر البيع";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.Location = new Point(457, 262);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.Size = new Size(281, 23);
            txtSellingPrice.TabIndex = 27;
            txtSellingPrice.TextAlign = HorizontalAlignment.Center;
            txtSellingPrice.KeyPress += txtSellingPrice_KeyPress;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(12, 59);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(103, 32);
            btnSearch.TabIndex = 29;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(121, 60);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(317, 23);
            txtSearch.TabIndex = 30;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(325, 9);
            label5.Name = "label5";
            label5.Size = new Size(174, 32);
            label5.TabIndex = 31;
            label5.Text = "شاشه اداره منتج";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProductManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(847, 370);
            Controls.Add(label5);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(label4);
            Controls.Add(txtSellingPrice);
            Controls.Add(label2);
            Controls.Add(txtPurchasePrice);
            Controls.Add(label3);
            Controls.Add(txtQuantity);
            Controls.Add(label1);
            Controls.Add(txtProductName);
            Controls.Add(lblid);
            Controls.Add(txtProductID);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewProducts);
            Name = "ProductManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اداره المنتجات";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProducts;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Label label3;
        private TextBox txtQuantity;
        private Label label1;
        private TextBox txtProductName;
        private Label lblid;
        private TextBox txtProductID;
        private Label label2;
        private TextBox txtPurchasePrice;
        private Label label4;
        private TextBox txtSellingPrice;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label5;
    }
}