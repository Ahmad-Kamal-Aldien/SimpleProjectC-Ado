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
    public partial class UserManagementForm : Form
    {
        private DatabaseHelper dbHelper;

        public UserManagementForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            LoadUsers();
        }
        private void LoadUsers()
        {
            DataTable dt = dbHelper.ExecuteQuery("SELECT * FROM Users");
            //DataTable dt = dbHelper.ExecuteQuery("SELECT UserID as 'رقم الموظف',EmployeeName as 'اسم الموظف',Username as 'اسم المستخدم',Password as 'الباسورد' FROM Users");
            dataGridViewUsers.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("من فضلك اكتب اسم المستخدم");
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("من فضلك اكتب  الياسورد");
                return;
            }
            if (txtEmployeeName.Text.Trim() == "")
            {
                MessageBox.Show("من فضلك اكتب  اسم الموظف");
                return;
            }
            string query = $"INSERT INTO Users (EmployeeName, Username, Password) VALUES (N'{txtEmployeeName.Text}', N'{txtUsername.Text}', N'{txtPassword.Text}')";
            dbHelper.ExecuteNonQuery(query);
            LoadUsers();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("من فضلك اكتب اسم المستخدم");
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("من فضلك اكتب  الياسورد");
                return;
            }
            if (txtEmployeeName.Text.Trim() == "")
            {
                MessageBox.Show("من فضلك اكتب  اسم الموظف");
                return;
            }
            string query = $"UPDATE Users SET EmployeeName = N'{txtEmployeeName.Text}', Username = N'{txtUsername.Text}', Password = N'{txtPassword.Text}' WHERE UserID = {txtUserID.Text}";
            dbHelper.ExecuteNonQuery(query);
            LoadUsers();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "")
            {
                MessageBox.Show("من فضلك اختر موظف");
                return;
            }
            string query = $"DELETE FROM Users WHERE UserID = {txtUserID.Text}";
            dbHelper.ExecuteNonQuery(query);
            LoadUsers();
            ClearFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Users WHERE EmployeeName LIKE '%{txtSearch.Text}%' OR Username LIKE '%{txtSearch.Text}%'";
            DataTable dt = dbHelper.ExecuteQuery(query);
            dataGridViewUsers.DataSource = dt;
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUsers.Rows[e.RowIndex];
                txtUserID.Text = row.Cells["UserID"].Value.ToString();
                txtEmployeeName.Text = row.Cells["EmployeeName"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
            }

        }
        private void ClearFields()
        {
            txtUserID.Text = "";
            txtEmployeeName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtSearch.Text = "";
        }

    }
}
