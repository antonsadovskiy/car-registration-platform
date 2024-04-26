using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Car_registration_admin_panel
{
    public partial class RegisterForm : Form
    {
        LoginForm loginForm;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void alreadyHaveAccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (loginForm == null || loginForm.IsDisposed)
            {
                loginForm = new LoginForm();
                loginForm.Show();

                this.Hide();
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Resources.CONNECTION_STRING);

            SqlCommand cmd = new SqlCommand("AddUser", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@surname", surnameTextBox.Text);
            cmd.Parameters.AddWithValue("@firstname", firstnameTextBox.Text);
            cmd.Parameters.AddWithValue("@middlename", middlenameTextBox.Text);
            cmd.Parameters.AddWithValue("@birthDate", birthDateTimePicker.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
            cmd.Parameters.AddWithValue("@phone", phoneTextBox.Text);

            cmd.Parameters.Add(new SqlParameter("@userId", SqlDbType.Int, 4));
            cmd.Parameters["@userId"].Direction = ParameterDirection.Output;

            int newUserId = 0;

            try
            {
                con.Open();

                cmd.ExecuteNonQuery();

                newUserId = (int)cmd.Parameters["@userId"].Value;
            }
            catch
            {
                MessageBox.Show("Не удалось создать пользователя");
            }
            finally
            {
                con.Close();
            }

            if (newUserId != 0)
            {
                con = new SqlConnection(Properties.Resources.CONNECTION_STRING);

                cmd = new SqlCommand("AddAccount", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@login", loginTextBox.Text);
                cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
                cmd.Parameters.AddWithValue("@userId", newUserId);

                SqlParameter messageParam = new SqlParameter("@message", SqlDbType.NVarChar, 50);
                messageParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(messageParam);

                try
                {
                    con.Open();

                    cmd.ExecuteNonQuery();

                    if (messageParam.Value.Equals("SUCCESS"))
                    {
                        MessageBox.Show("Новый пользователь успешно создан");

                        if (loginForm == null || loginForm.IsDisposed)
                        {
                            loginForm = new LoginForm();
                            loginForm.Show();

                            this.Hide();
                        }
                    }
                    else
                    {

                        MessageBox.Show("Вероятно пользователь с таким login уже есть");
                    }

                }
                catch
                {
                    MessageBox.Show("Не удалось создать пользователя");
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}