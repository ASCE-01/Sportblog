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
    public partial class UserInfoForm : Form
    {
        public string conString = @"Data Source=DESKTOP-OTPO2DA\SQLEXPRESS;Initial Catalog=Sportblog;Integrated Security=True";
        private int id;
        public UserInfoForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                int sexId = 1;
                string selectSexQuery = $"select name from dictionary where parent_id={sexId}";
                SqlCommand cmd = new SqlCommand(selectSexQuery, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    sexComboBox.Items.Add(row["name"]);
                }
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                SqlTransaction tran = con.BeginTransaction();
                try
                {
                    string insertQuery = "INSERT INTO user_infos([name], [lastname], [sex], [age], [about], [user_id]) VALUES (@name, @lastname, @sex, @age, @about, @user_id)";
                    SqlCommand cmd = new SqlCommand(insertQuery, con, tran);
                    cmd.Parameters.Add("@name", SqlDbType.VarChar);
                    cmd.Parameters.Add("@lastname", SqlDbType.VarChar);
                    cmd.Parameters.Add("@sex", SqlDbType.VarChar);
                    cmd.Parameters.Add("@age", SqlDbType.Int);
                    cmd.Parameters.Add("@about", SqlDbType.Text);
                    cmd.Parameters.Add("@user_id", SqlDbType.Int);

                    cmd.Parameters["@name"].Value = nameTextBox.Text;
                    cmd.Parameters["@lastname"].Value = lastnameTextBox.Text;
                    cmd.Parameters["@sex"].Value = sexComboBox.Text;
                    cmd.Parameters["@age"].Value = Convert.ToInt32(ageTextBox.Text);
                    cmd.Parameters["@about"].Value = aboutTextBox.Text;
                    cmd.Parameters["@user_id"].Value = id;

                    cmd.ExecuteNonQuery();

                    string updateQuery = $"update users set role_id=4 where user_id={id}";
                    SqlCommand cmd1 = new SqlCommand(updateQuery, con, tran);
                    //cmd1.Parameters.Add("@user_id", SqlDbType.Int);
                    //cmd1.Parameters["@user_id"].Value = Convert.ToInt32(userIdTextBox.Text);

                    cmd1.ExecuteNonQuery();

                    Hide();
                    Form1 form1 = new Form1();
                    form1.Show();

                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message, "Error Message", MessageBoxButtons.OK);
                }

            }
        }

        //exit from all windows and close application
        private void UserInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
