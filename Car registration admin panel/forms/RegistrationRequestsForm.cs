using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_registration_admin_panel.forms
{
    public partial class RegistrationRequestsForm : Form
    {
        MainForm mainForm;
        User registrationRequestsUser;

        string carModel;
        string carMileage;
        string carYear;
        string carColor;
        string carNumber;
        string carSeries;
        string carRegisterRegionCode;
        int userId;

        private SqlDataAdapter adapter;
        private DataSet ds;
        private SqlConnection con;

        int selectedRequestId;

        DataView registrationCarsRequestsView;

        public RegistrationRequestsForm(User user)
        {
            registrationRequestsUser = user;

            InitializeComponent();

            con = new SqlConnection(Properties.Resources.CONNECTION_STRING);

            try
            {
                con.Open();

                adapter = new SqlDataAdapter("select * from AllRegistrationCarsRequests", con);

                ds = new DataSet();

                adapter.Fill(ds, "registration_cars_requests");

                registrationCarsRequestsView = new DataView(ds.Tables["registration_cars_requests"]);

                registrationCarsRequestsDataGridView.DataSource = registrationCarsRequestsView;

                if ((registrationCarsRequestsDataGridView.RowCount - 1) == 0)
                {
                    registrationCarsRequestsDataGridView.Visible = false;
                    registerCarButton.Visible = false;
                }
                else
                {
                    noDataLabel.Visible = false;
                }
            }
            finally
            {
                con.Close();
            }

            registrationCarsRequestsDataGridView.Columns[0].Visible = false;
            registrationCarsRequestsDataGridView.Columns[1].HeaderText = "Модель";
            registrationCarsRequestsDataGridView.Columns[2].HeaderText = "Пробег";
            registrationCarsRequestsDataGridView.Columns[3].HeaderText = "Год выпуска";
            registrationCarsRequestsDataGridView.Columns[4].HeaderText = "Цвет";
            registrationCarsRequestsDataGridView.Columns[5].HeaderText = "Номер";
            registrationCarsRequestsDataGridView.Columns[6].HeaderText = "Серия";
            registrationCarsRequestsDataGridView.Columns[7].HeaderText = "Код региона";
            registrationCarsRequestsDataGridView.Columns[8].HeaderText = "Id пользователя";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (mainForm == null || mainForm.IsDisposed)
            {
                mainForm = new MainForm(registrationRequestsUser);
                mainForm.Show();

                this.Hide();
            }
        }

        private void registerCarButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Resources.CONNECTION_STRING);

            SqlCommand cmd = new SqlCommand("AddCar", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@carModel", carModel);
            cmd.Parameters.AddWithValue("@carYear", carYear);
            cmd.Parameters.AddWithValue("@carMileage", carMileage);
            cmd.Parameters.AddWithValue("@carColor", carColor);
            cmd.Parameters.AddWithValue("@carNumber", carNumber);
            cmd.Parameters.AddWithValue("@carSeries", carSeries);
            cmd.Parameters.AddWithValue("@carRegisterRegionCode", carRegisterRegionCode);
            cmd.Parameters.AddWithValue("@userId", userId);

            try
            {
                con.Open();

                cmd.ExecuteNonQuery();

                deleteRequestFromDB();

                MessageBox.Show("Автомобиль успешно зарегистрирован!");

                mainForm = new MainForm(registrationRequestsUser);
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

        private void selectRowHandler(object sender, EventArgs e)
        {
            if (registrationCarsRequestsDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = registrationCarsRequestsDataGridView.SelectedRows[0];

                string carId = selectedRow.Cells["registrationRequestId"].Value.ToString();

                if (!string.IsNullOrEmpty(carId))
                {
                    registerCarButton.Enabled = true;
                    deleteRequestButton.Visible = true;

                    selectedRequestId = Convert.ToInt32(carId);

                    carModel = selectedRow.Cells["carModel"].Value.ToString();
                    carMileage = selectedRow.Cells["carMileage"].Value.ToString();
                    carYear = selectedRow.Cells["carYear"].Value.ToString();
                    carColor = selectedRow.Cells["carColor"].Value.ToString();
                    carNumber = selectedRow.Cells["carNumber"].Value.ToString();
                    carSeries = selectedRow.Cells["carSeries"].Value.ToString();
                    carRegisterRegionCode = selectedRow.Cells["carRegisterRegionCode"].Value.ToString();
                    userId = Convert.ToInt32(selectedRow.Cells["userId"].Value);
                }
            }
            else
            {
                registerCarButton.Enabled = false;
                deleteRequestButton.Visible = false;
            }
        }

        private void deleteRequestButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите заявку?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                deleteRequestFromDB();
            }
        }

        private void deleteRequestFromDB()
        {
            con = new SqlConnection(Properties.Resources.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("DeleteRegistrationRequest", con);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@registrationRequestId", selectedRequestId);

            try
            {
                con.Open();
                command.ExecuteNonQuery();

                foreach (DataGridViewRow row in registrationCarsRequestsDataGridView.Rows)
                {
                    if (row.Cells["registrationRequestId"].Value.ToString() == selectedRequestId.ToString())
                    {
                        registrationCarsRequestsDataGridView.Rows.Remove(row);
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
}
