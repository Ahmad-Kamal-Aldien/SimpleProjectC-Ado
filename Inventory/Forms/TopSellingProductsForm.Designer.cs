namespace Inventory.Forms
{
    partial class TopSellingProductsForm
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
            dataGridViewTopProducts = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTopProducts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTopProducts
            // 
            dataGridViewTopProducts.AllowUserToAddRows = false;
            dataGridViewTopProducts.AllowUserToDeleteRows = false;
            dataGridViewTopProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTopProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTopProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTopProducts.Location = new Point(0, 56);
            dataGridViewTopProducts.Name = "dataGridViewTopProducts";
            dataGridViewTopProducts.Size = new Size(788, 328);
            dataGridViewTopProducts.TabIndex = 65;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(248, 9);
            label5.Name = "label5";
            label5.Size = new Size(261, 32);
            label5.TabIndex = 66;
            label5.Text = "شاشه اكثر الاصناف مبيعا";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TopSellingProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 397);
            Controls.Add(label5);
            Controls.Add(dataGridViewTopProducts);
            Name = "TopSellingProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اكثر الاصناف مبيعا";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTopProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewTopProducts;
        private Label label5;
    }
}