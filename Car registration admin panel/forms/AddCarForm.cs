using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_registration_admin_panel.forms
{
    public partial class AddCarForm : Form
    {
        User addCarFormUser;
        MainForm mainForm;
        public AddCarForm(User user)
        {
            addCarFormUser = user;

            InitializeComponent();

            if (addCarFormUser.isAdmin)
            {
                ownerFIOLabel.Visible = false;
                leaveRequestButton.Visible = false;
            }
            else
            {
                ownerComboBox.Visible = false;
                registerCarButton.Visible = false;
                ownerFIOLabel.Text = addCarFormUser.surname + " " + addCarFormUser.firstname + " " + addCarFormUser.middlename;
            }
        }

        private void AddCarForm_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.state_vehicle_inspection_dbDataSet.users);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (mainForm == null || mainForm.IsDisposed)
            {
                mainForm = new MainForm(addCarFormUser);
                mainForm.Show();

                this.Close();
            }
        }

        private void registerCarButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Resources.CONNECTION_STRING);

            bool isExists = isCarWithSameNumberAlreadyExists();

            if (isExists)
            {
                MessageBox.Show("Автомобиль с таким регистрационным знаком уже существует");
            }

            if (!isExists)
            {
                SqlCommand cmd = new SqlCommand("AddCar", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@carModel", carModelTextBox.Text);
                cmd.Parameters.AddWithValue("@carYear", carYearTextBox.Text);
                cmd.Parameters.AddWithValue("@carMileage", carMileageTextBox.Text);
                cmd.Parameters.AddWithValue("@carColor", carColorTextBox.Text);
                cmd.Parameters.AddWithValue("@carNumber", carNumberTextBox.Text);
                cmd.Parameters.AddWithValue("@carSeries", carSeriesTextBox.Text);
                cmd.Parameters.AddWithValue("@carRegisterRegionCode", carRegionCodeCombobox.Text.ToString());
                cmd.Parameters.AddWithValue("@userId", ownerComboBox.SelectedValue.ToString());

                try
                {
                    con.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Автомобиль успешно зарегистрирован!");

                    mainForm = new MainForm(addCarFormUser);
                    mainForm.Show();

                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Не удалось зарегистрировать автомобиль");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void leaveRequestButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Resources.CONNECTION_STRING);

            bool isExists = isCarWithSameNumberAlreadyExists();

            if (isExists)
            {
                MessageBox.Show("Автомобиль с таким регистрационным знаком уже существует");
            }

            if (!isExists)
            {
                SqlCommand cmd = new SqlCommand("AddRegistrationCarRequest", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@carModel", carModelTextBox.Text);
                cmd.Parameters.AddWithValue("@carYear", carYearTextBox.Text);
                cmd.Parameters.AddWithValue("@carMileage", carMileageTextBox.Text);
                cmd.Parameters.AddWithValue("@carColor", carColorTextBox.Text);
                cmd.Parameters.AddWithValue("@carNumber", carNumberTextBox.Text);
                cmd.Parameters.AddWithValue("@carSeries", carSeriesTextBox.Text);
                cmd.Parameters.AddWithValue("@carRegisterRegionCode", carRegionCodeCombobox.Text.ToString());
                cmd.Parameters.AddWithValue("@userId", addCarFormUser.userId);

                try
                {
                    con.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Заявка на регистрацию успешно оставлена!");

                    mainForm = new MainForm(addCarFormUser);
                    mainForm.Show();

                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Не удалось оставить заявку");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private bool isCarWithSameNumberAlreadyExists()
        {
            SqlConnection con = new SqlConnection(Properties.Resources.CONNECTION_STRING);

            SqlCommand cmd = new SqlCommand("CheckCarExists", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@carNumber", carNumberTextBox.Text);
            cmd.Parameters.AddWithValue("@carSeries", carSeriesTextBox.Text);
            cmd.Parameters.AddWithValue("@carRegisterRegionCode", carRegionCodeCombobox.Text.ToString());

            SqlParameter isExistsParam = new SqlParameter("@isExists", SqlDbType.Bit);
            isExistsParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(isExistsParam);

            bool isExists = true;

            try
            {
                con.Open();

                cmd.ExecuteNonQuery();

                isExists = (bool)isExistsParam.Value;
            }
            catch
            {
                MessageBox.Show("При проверке на уже существующую машину с таким номером возникла ошибка");
            }
            finally
            {
                con.Close();
            }

            return isExists;
        }
    }
}