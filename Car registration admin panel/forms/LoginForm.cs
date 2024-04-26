using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_registration_admin_panel
{
    public partial class LoginForm : Form
    {
        RegisterForm registerForm;
        MainForm mainForm;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void dontHaveAccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (registerForm == null || registerForm.IsDisposed)
            {
                registerForm = new RegisterForm();
                registerForm.Show();

                this.Hide();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            AuthUser(false);
        }

        private void loginAsAdminButton_Click(object sender, EventArgs e)
        {
            AuthUser(true);
        }

        private void AuthUser(bool isAdmin)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                SqlConnection con = new SqlConnection(Properties.Resources.CONNECTION_STRING);

                SqlCommand cmd = new SqlCommand(isAdmin ? "CheckLoginForAdmin" : "CheckLogin", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", password);

                SqlParameter userIdParam = new SqlParameter("@userId", SqlDbType.Int);
                userIdParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(userIdParam);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();

                    int userId = (int)userIdParam.Value;

                    if (mainForm == null || mainForm.IsDisposed)
                    {
                        User user = new User(userId, isAdmin);

                        mainForm = new MainForm(user);
                        mainForm.Show();

                        this.Hide();
                    }
                }
                catch
                {
                    MessageBox.Show("Неверный логин или пароль!");
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Заполните поля");
            }
        }
    }
}