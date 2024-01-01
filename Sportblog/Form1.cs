using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1 : Form
    {

        public string conString = @"Data Source=DESKTOP-OTPO2DA\SQLEXPRESS;Initial Catalog=Sportblog;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();

        }

        private void selectButton_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                string selectStr = "select * from users";
                SqlCommand cmd = new SqlCommand(selectStr, con);
                cmd.ExecuteNonQuery();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }

        }


        //aq maqvs transaction ↓
        private void updateButton_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand("UpdateUsers", con, transaction)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    SqlParameter id = new SqlParameter()
                    {
                        ParameterName = "@id",
                        DbType = DbType.Int32,
                        Value = idTextBox.Text,
                        Direction = ParameterDirection.Input,
                    };

                    SqlParameter username = new SqlParameter()
                    {
                        ParameterName = "username",
                        DbType = DbType.String,
                        Value = usernameTextBox.Text,
                        Direction = ParameterDirection.Input,
                    };

                    SqlParameter email = new SqlParameter()
                    {
                        ParameterName = "@email",
                        DbType = DbType.String,
                        Value = emailTextBox.Text,
                        Direction = ParameterDirection.Input,
                    };

                    SqlParameter pass = new SqlParameter()
                    {
                        ParameterName = "@pass",
                        DbType = DbType.String,
                        Value = passTextBox.Text,
                        Direction = ParameterDirection.Input,
                    };

                    SqlParameter r_id = new SqlParameter()
                    {
                        ParameterName = "@r_id",
                        DbType = DbType.Int32,
                        Value = r_idTextBox.Text,
                        Direction = ParameterDirection.Input,
                    };

                    cmd.Parameters.Add(id);
                    cmd.Parameters.Add(username);
                    cmd.Parameters.Add(email);
                    cmd.Parameters.Add(pass);
                    cmd.Parameters.Add(r_id);

                    cmd.ExecuteNonQuery();

                    string selectStr = "select * from users";
                    SqlCommand cmd1 = new SqlCommand(selectStr, con, transaction);
                    cmd1.ExecuteNonQuery();
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd1);

                    adapter.Fill(table);
                    dataGridView1.DataSource = table;

                    transaction.Commit();
                }
                catch (Exception ex)
                {

                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message, "Error Message", MessageBoxButtons.OK);

                }


            }

        }

        private void insertButton_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(conString))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("InsertUsers", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter r_id = new SqlParameter
                {
                    ParameterName = "@role_id",
                    DbType = DbType.Int32,
                    Value = r_idTextBox.Text,
                    Direction = ParameterDirection.Input,
                };

                SqlParameter username = new SqlParameter
                {
                    ParameterName = "username",
                    DbType = DbType.String,
                    Value = usernameTextBox.Text,
                    Direction = ParameterDirection.Input,
                };

                SqlParameter email = new SqlParameter
                {
                    ParameterName = "@email",
                    DbType = DbType.String,
                    Value = emailTextBox.Text,
                    Direction = ParameterDirection.Input,
                };

                SqlParameter pass = new SqlParameter
                {
                    ParameterName = "@pass",
                    DbType = DbType.String,
                    Value = passTextBox.Text,
                    Direction = ParameterDirection.Input,
                };

                cmd.Parameters.Add(username);
                cmd.Parameters.Add(email);
                cmd.Parameters.Add(pass);
                cmd.Parameters.Add(r_id);

                cmd.ExecuteNonQuery();

                string selectStr = "select * from users";
                SqlCommand cmd1 = new SqlCommand(selectStr, con);
                cmd1.ExecuteNonQuery();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd1);

                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(conString))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("DeleteUser", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter id = new SqlParameter
                {
                    ParameterName = "@id",
                    DbType = DbType.Int32,
                    Value = deleteTextBox.Text,
                    Direction = ParameterDirection.Input,
                };
                cmd.Parameters.Add(id);

                cmd.ExecuteNonQuery();
            }

        }

        async private void asyncButton_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(conString))
            {

                await con.OpenAsync();

                string countStr = "waitfor delay '00:00:05'; select count(user_id) from users";
                SqlCommand cmd = new SqlCommand(countStr, con);

                int count = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                countUsers.Text = Convert.ToString(count);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Hide();

            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["user_id"].Value);

            UserInfoForm userInfo = new UserInfoForm(id);
            userInfo.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}