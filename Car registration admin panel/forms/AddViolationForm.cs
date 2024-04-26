using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_registration_admin_panel.forms
{
    public partial class AddViolationForm : Form
    {
        int carId;
        CarInfoForm carInfoForm;

        public AddViolationForm(int carId, CarInfoForm carInfoForm)
        {
            this.carId = carId;
            this.carInfoForm = carInfoForm;

            InitializeComponent();
        }

        private void AddViolationForm_Load(object sender, EventArgs e)
        {
            this.violationsTableAdapter.Fill(this.state_vehicle_inspection_dbDataSet.violations);
        }

        private void addViolationButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Resources.CONNECTION_STRING);

            SqlCommand cmd = new SqlCommand("AddCarViolation", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@carId", carId);
            cmd.Parameters.AddWithValue("@violationId", violationTypeComboBox.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@timeOfViolation", timeOfViolationDateTimePicker.Value.ToString("yyyy-MM-dd"));

            try
            {
                con.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Нарушение успешно добавлено!");

                this.Close();

                carInfoForm.LoadForm();
            }
            catch
            {
                MessageBox.Show("Не удалось добавить нарушение");
            }
            finally
            {
                con.Close();
            }

        }
    }
}