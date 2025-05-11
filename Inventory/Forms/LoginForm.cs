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
    public partial class LoginForm : Form
    {
        private DatabaseHelper dbHelper;
        public LoginForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string queryCheckUser = $"SELECT * FROM Users ";
            DataTable dtCheckUser = dbHelper.ExecuteQuery(queryCheckUser);
            if (dtCheckUser.Rows.Count <= 0) {

                string queryCheckUserAdd = $"INSERT INTO Users (EmployeeName, Username, Password) VALUES (N'admin', N'admin', N'admin')";
                dbHelper.ExecuteNonQuery(queryCheckUserAdd);
            }


            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string query = $"SELECT * FROM Users WHERE Username = N'{username}' AND Password = N'{password}'";
            DataTable dt = dbHelper.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة");
            }
        }
    }
}
