using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class LoginForm : Form
    {
        public string conString = @"Data Source=DESKTOP-OTPO2DA\SQLEXPRESS;Initial Catalog=Sportblog;Integrated Security=True";
        public LoginForm()
        {
            InitializeComponent();
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
        #endregion

        private void loginButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {

                con.Open();
                string query = "select * from users where username=@username and password=@password";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.Add("@username", SqlDbType.VarChar);
                cmd.Parameters.Add("@password", SqlDbType.VarChar);
                cmd.Parameters["@username"].Value = usernameTextBox.Text;
                cmd.Parameters["@password"].Value = passwordTextBox.Text;

                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                #region validation
                if (string.IsNullOrEmpty(usernameTextBox.Text))
                {
                    MessageBox.Show("Username field is empty.", "Error message", MessageBoxButtons.OK);
                }
                else if (string.IsNullOrEmpty(passwordTextBox.Text))
                {
                    MessageBox.Show("Password field is empty.", "Error message", MessageBoxButtons.OK);
                }
                else if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("This user doesn't exist.", "Error message", MessageBoxButtons.OK);
                }
                else
                {
                    if (Convert.ToInt32(dt.Rows[0]["role_id"]) == 1)
                    {
                        Hide();
                        Form1 form1 = new Form1();
                        form1.Show();
                    }
                    else
                    {
                        MessageBox.Show("You are logged in.", "User", MessageBoxButtons.OK);
                    }
                }
                #endregion

            }
        }

        #region create hover
        private void createLabel_MouseEnter(object sender, EventArgs e)
        {
            createLabel.ForeColor = Color.FromArgb(46, 122, 191);
        }
        private void createLabel_MouseLeave(object sender, EventArgs e)
        {
            createLabel.ForeColor = Color.Black;
        }
        #endregion

        //createze gadasvla
        private void createLabel_Click(object sender, EventArgs e)
        {
            Hide();
            CreateForm createForm = new CreateForm();
            createForm.Show();
        }

        //gamosvla
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
