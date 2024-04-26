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
    public partial class EditUserInfoForm : Form
    {
        MainForm mainForm;
        User editableUser;

        public EditUserInfoForm(User user)
        {
            InitializeComponent();

            editableUser = user;

            emailTextBox.Text = user.email;
            phoneTextBox.Text = user.phone;
        }

        private void updateUserInfoButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Resources.CONNECTION_STRING);

            SqlCommand cmd = new SqlCommand("UpdateUserContactInfo", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@userId", editableUser.userId);
            cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
            cmd.Parameters.AddWithValue("@phone", phoneTextBox.Text);

            SqlParameter updatedEmail = new SqlParameter("@updatedEmail", SqlDbType.NVarChar, 50);
            updatedEmail.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(updatedEmail); 

            SqlParameter updatedPhone = new SqlParameter("@updatedPhone", SqlDbType.NVarChar, 50);
            updatedPhone.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(updatedPhone);

            con.Open();

            string newEmail;
            string newPhone;

            try
            {
                cmd.ExecuteNonQuery();

                if (mainForm == null || mainForm.IsDisposed)
                {

                    newEmail = (string)cmd.Parameters["@updatedEmail"].Value;
                    newPhone = (string)cmd.Parameters["@updatedPhone"].Value;

                    editableUser.updateUser(newEmail, newPhone);

                    MessageBox.Show("Обновлено");

                    if (mainForm == null || mainForm.IsDisposed)
                    {
                        mainForm = new MainForm(editableUser);
                        mainForm.Show();

                        this.Hide();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
            finally
            {
                con.Close();
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (mainForm == null || mainForm.IsDisposed)
            {
                mainForm = new MainForm(editableUser);
                mainForm.Show();

                this.Hide();
            }
        }
    }
}