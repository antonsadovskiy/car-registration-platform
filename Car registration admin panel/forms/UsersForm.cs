using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;

namespace Car_registration_admin_panel.forms
{
    public partial class UsersForm : Form
    {
        MainForm mainForm;
        User usersFormUser;

        private SqlDataAdapter adapter;
        private DataSet ds;
        private SqlConnection con;

        int selectedUserId;

        DataView allUsersView;

        public UsersForm(User user)
        {
            usersFormUser = user;

            InitializeComponent();

            con = new SqlConnection(Properties.Resources.CONNECTION_STRING);

            try
            {
                con.Open();

                adapter = new SqlDataAdapter("select * from AllUsers", con);

                ds = new DataSet();

                adapter.Fill(ds, "users");

                allUsersView = new DataView(ds.Tables["users"]);

                allUsersView.RowFilter = "userId <> " + usersFormUser.userId;

                usersDataGridView.DataSource = allUsersView;
            }
            finally
            {
                con.Close();
            }

            usersDataGridView.Columns[0].Visible = false;
            usersDataGridView.Columns[1].HeaderText = "Фамилия";
            usersDataGridView.Columns[2].HeaderText = "Имя";
            usersDataGridView.Columns[3].HeaderText = "Отчество";
            usersDataGridView.Columns[4].HeaderText = "Дата рождения";
            usersDataGridView.Columns[5].HeaderText = "Почта";
            usersDataGridView.Columns[6].HeaderText = "Моб.тел.";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (mainForm == null || mainForm.IsDisposed)
            {
                mainForm = new MainForm(usersFormUser);
                mainForm.Show();

                this.Hide();
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите пользователя?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con = new SqlConnection(Properties.Resources.CONNECTION_STRING);
                SqlCommand command = new SqlCommand("DeleteUser", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@userId", selectedUserId);

                try
                {
                    con.Open();
                    command.ExecuteNonQuery();

                    foreach (DataGridViewRow row in usersDataGridView.Rows)
                    {
                        if (row.Cells["userId"].Value.ToString() == selectedUserId.ToString())
                        {
                            usersDataGridView.Rows.Remove(row);
                            break;
                        }
                    }
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void selectRowHandler(object sender, EventArgs e)
        {
            if (usersDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = usersDataGridView.SelectedRows[0];

                string userId = selectedRow.Cells["userId"].Value.ToString();

                if (!string.IsNullOrEmpty(userId))
                {
                    deleteUserButton.Visible = true;

                    selectedUserId = Convert.ToInt32(userId);
                }
            }
            else
            {
                deleteUserButton.Visible = false;
            }
        }
    }
}
