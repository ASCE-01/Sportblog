using Sportblog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            using (DBClassDataContext dbContext = new DBClassDataContext())
            {
                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;
                string email = emailTextBox.Text;
                int role_id = 3;
                user user = new user
                {
                    username = username,
                    password = password,
                    email = email,
                    role_id = role_id,
                };
                dbContext.users.InsertOnSubmit(user);
                dbContext.SubmitChanges();
            }
        }

        # region hide and unhide password
        private void passwordPictureBox_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.PasswordChar == '*')
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }
        private void repasswordPictureBox_Click(object sender, EventArgs e)
        {
            if (repasswordTextBox.PasswordChar == '*')
            {
                repasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                repasswordTextBox.PasswordChar = '*';
            }
        }
        #endregion

        #region create hover
        private void loginLabel_MouseEnter(object sender, EventArgs e)
        {
            loginLabel.ForeColor = Color.FromArgb(46, 122, 191);
        }
        private void loginLabel_MouseLeave(object sender, EventArgs e)
        {
            loginLabel.ForeColor = Color.Black;
        }
        #endregion

        //createze gadasvla
        private void loginLabel_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        //gamosvla
        private void CreateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
