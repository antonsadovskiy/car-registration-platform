using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_registration_admin_panel
{
    public partial class MainForm : Form
    {
        EditUserInfoForm editUserInfoForm;
        LoginForm loginForm;
        CarInfoForm carInfoForm;
        forms.AddCarForm addCarForm;
        forms.RegistrationRequestsForm registrationRequestsForm;
        forms.UsersForm usersForm;

        User mainUser;

        private SqlDataAdapter adapter;
        private DataSet ds;
        private SqlConnection con;

        DataView carsView;

        string searchByNumberValue = "", searchBySeriesValue = "", searchByRegionCodeValue = "";

        int selectedCarId;

        public MainForm(User user)
        {
            InitializeComponent();

            mainUser = user;

            setUserInfo(user);

            con = new SqlConnection(Properties.Resources.CONNECTION_STRING);

            SqlCommand command = new SqlCommand(mainUser.isAdmin ? "GetAllCars" : "GetUserCars", con);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@userId", mainUser.userId);

            try
            {
                con.Open();

                adapter = new SqlDataAdapter(command);

                ds = new DataSet();

                adapter.Fill(ds, "cars");

                carsView = new DataView(ds.Tables["cars"]);

                carsDataGridView.DataSource = carsView;
            }
            finally
            {
                con.Close();
            }

            deleteCarButton.Visible = false;
            registrationRequestsButton.Visible = user.isAdmin;
            allUsersButton.Visible = user.isAdmin;

            carsDataGridView.Columns[0].Visible = false;
            carsDataGridView.Columns[1].HeaderText = "Модель";
            carsDataGridView.Columns[2].HeaderText = "Год выпуска";
            carsDataGridView.Columns[3].HeaderText = "Номер";
            carsDataGridView.Columns[4].HeaderText = "Серия";
            carsDataGridView.Columns[5].HeaderText = "Код региона";
            carsDataGridView.Columns[6].HeaderText = "Цвет";

            addCarButton.Text = user.isAdmin ? "Зарегистрировать автомобиль" : "Оставить заявку на регистрацию";

            setAvatarImage();
        }

        private void editUserButton_Click(object sender, System.EventArgs e)
        {
            if (editUserInfoForm == null || editUserInfoForm.IsDisposed)
            {
                editUserInfoForm = new EditUserInfoForm(mainUser);
                editUserInfoForm.Show();

                this.Hide();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (loginForm == null || loginForm.IsDisposed)
            {
                loginForm = new LoginForm();
                loginForm.Show();

                this.Hide();
            }
        }

        private void setUserInfo(User user)
        {
            fullnameLabel.Text = user.surname + " " + user.firstname + " " + user.middlename;
            birthDateLabel.Text = user.birthDate;
            emailLabel.Text = user.email;
            phoneLabel.Text = "+375" + user.phone;
            isAdminLabel.Visible = user.isAdmin;
            statusLabel.Visible = user.isAdmin;
        }

        private void selectRowHandler(object sender, EventArgs e)
        {
            if (carsDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = carsDataGridView.SelectedRows[0];

                string carId = selectedRow.Cells["carId"].Value.ToString();

                if (!string.IsNullOrEmpty(carId))
                {
                    deleteCarButton.Visible = mainUser.isAdmin;
                    openCarFormButton.Enabled = true;

                    selectedCarId = Convert.ToInt32(carId);
                }
            }
            else
            {
                openCarFormButton.Enabled = false;
                deleteCarButton.Visible = false;
            }

        }

        private void changeNumberValueHandler(object sender, EventArgs e)
        {
            string searchValue = searchByNumberTextBox.Text;

            if (!string.IsNullOrEmpty(searchValue))
            {
                searchByNumberValue = searchValue;
            }
            else
            {
                searchByNumberValue = "";
            }

            setFilterToTable();
        }

        private void changeSeriesValueHandler(object sender, EventArgs e)
        {
            string searchValue = searchBySeriesTextBox.Text;

            if (!string.IsNullOrEmpty(searchValue))
            {
                searchBySeriesValue = searchValue;
            }
            else
            {
                searchBySeriesValue = "";
            }

            setFilterToTable();
        }

        private void clearFiltersButton_Click(object sender, EventArgs e)
        {
            searchByNumberTextBox.Text = "";
            searchBySeriesTextBox.Text = "";
            searchByRegionCodeCombobox.Text = "";

            setFilterToTable();
        }

        private void openCarFormButton_Click(object sender, EventArgs e)
        {
            if (carInfoForm == null || carInfoForm.IsDisposed)
            {
                Car car = new Car(selectedCarId);

                carInfoForm = new CarInfoForm(car, mainUser);
                carInfoForm.Show();

                this.Hide();
            }
        }

        private void changeRegionCodeValueHandler(object sender, EventArgs e)
        {
            string searchValue = searchByRegionCodeCombobox.Text.ToString();

            if (!string.IsNullOrEmpty(searchValue))
            {
                searchByRegionCodeValue = searchValue;
            }
            else
            {
                searchByRegionCodeValue = "";
            }

            setFilterToTable();
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            if (addCarForm == null || addCarForm.IsDisposed)
            {
                addCarForm = new forms.AddCarForm(mainUser);
                addCarForm.Show();

                this.Hide();
            }
        }

        private void registrationRequestsButton_Click(object sender, EventArgs e)
        {
            if (registrationRequestsForm == null || registrationRequestsForm.IsDisposed)
            {
                registrationRequestsForm = new forms.RegistrationRequestsForm(mainUser);
                registrationRequestsForm.Show();

                this.Hide();
            }
        }

        private void allUsersButton_Click(object sender, EventArgs e)
        {
            if (usersForm == null || usersForm.IsDisposed)
            {
                usersForm = new forms.UsersForm(mainUser);
                usersForm.Show();

                this.Hide();
            }
        }

        private void deleteCarButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить автомобиль?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con = new SqlConnection(Properties.Resources.CONNECTION_STRING);
                SqlCommand command = new SqlCommand("DeleteCar", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@carId", selectedCarId);

                try
                {
                    con.Open();
                    command.ExecuteNonQuery();

                    foreach (DataGridViewRow row in carsDataGridView.Rows)
                    {
                        if (row.Cells["carId"].Value.ToString() == selectedCarId.ToString())
                        {
                            carsDataGridView.Rows.Remove(row);
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

        private void setFilterToTable()
        {
            string filterExpression = "";

            if (!string.IsNullOrEmpty(searchByNumberValue))
            {
                filterExpression += $"carNumber LIKE '{searchByNumberValue}%' AND ";
            }

            if (!string.IsNullOrEmpty(searchBySeriesValue))
            {
                filterExpression += $"carSeries LIKE '{searchBySeriesValue}%' AND ";
            }

            if (!string.IsNullOrEmpty(searchByRegionCodeValue))
            {
                filterExpression += $"carRegisterRegionCode = {searchByRegionCodeValue} AND ";
            }

            if (!string.IsNullOrEmpty(filterExpression))
            {
                filterExpression = filterExpression.Remove(filterExpression.Length - 5);
            }

            carsView.RowFilter = filterExpression;
        }

        private void setAvatarImage()
        {
            string imagePath = @"E:\Study\3 курс\БД\sem2\admin-panel\Car registration admin panel\assets\" + (mainUser.isAdmin ? "admin_avatar.jpg" : "user_avatar.jpg");

            try
            {
                Image image = Image.FromFile(imagePath);

                avatar.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}