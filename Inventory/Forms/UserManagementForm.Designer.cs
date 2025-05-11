namespace Inventory.Forms
{
    partial class UserManagementForm
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
            dataGridViewUsers = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            txtUserID = new TextBox();
            lblid = new Label();
            label1 = new Label();
            txtEmployeeName = new TextBox();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            txtSearch = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(12, 104);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(440, 150);
            dataGridViewUsers.TabIndex = 0;
            dataGridViewUsers.CellClick += dataGridViewUsers_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11.25F);
            btnAdd.Location = new Point(566, 281);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 41);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "اضافه";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11.25F);
            btnUpdate.Location = new Point(429, 281);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(103, 41);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "تعديل";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11.25F);
            btnDelete.Location = new Point(278, 281);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 41);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(12, 66);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(103, 32);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(458, 92);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(281, 23);
            txtUserID.TabIndex = 9;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Segoe UI", 11.25F);
            lblid.Location = new Point(760, 92);
            lblid.Name = "lblid";
            lblid.Size = new Size(97, 20);
            lblid.TabIndex = 10;
            lblid.Text = "رقم المستخدم";
            lblid.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(801, 136);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 12;
            label1.Text = "الاسم";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(458, 133);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(281, 23);
            txtEmployeeName.TabIndex = 11;
            txtEmployeeName.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(757, 178);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 14;
            label2.Text = "اسم المستخدم";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(458, 178);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(281, 23);
            txtUsername.TabIndex = 13;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(773, 234);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 16;
            label3.Text = "كلمه المرور";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(458, 231);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(281, 23);
            txtPassword.TabIndex = 15;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(121, 75);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(331, 23);
            txtSearch.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(332, 9);
            label5.Name = "label5";
            label5.Size = new Size(226, 32);
            label5.TabIndex = 32;
            label5.Text = "شاشه اداره الموظفين";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 351);
            Controls.Add(label5);
            Controls.Add(txtSearch);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(txtEmployeeName);
            Controls.Add(lblid);
            Controls.Add(txtUserID);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewUsers);
            Name = "UserManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اداره الموظفين";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox txtUserID;
        private Label lblid;
        private Label label1;
        private TextBox txtEmployeeName;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtPassword;
        private TextBox txtSearch;
        private Label label5;
    }
}