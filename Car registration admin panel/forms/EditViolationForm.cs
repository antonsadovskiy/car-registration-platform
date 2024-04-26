using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_registration_admin_panel.forms
{
    public partial class EditViolationForm : Form
    {
        int carViolationId;

        CarInfoForm carInfoForm;

        public EditViolationForm(int carViolationId, CarInfoForm carInfoForm)
        {
            this.carViolationId = carViolationId;
            this.carInfoForm = carInfoForm;

            InitializeComponent();
        }

        private void editViolationButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Resources.CONNECTION_STRING);

            SqlCommand cmd = new SqlCommand("UpdateCarViolation", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@carViolationId", carViolationId);
            cmd.Parameters.AddWithValue("@violationId", violationTypeComboBox.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@timeOfViolation", timeOfViolationDateTimePicker.Value.ToString("yyyy-MM-dd"));

            try
            {
                con.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Нарушение успешно изменено!");

                this.Close();

                carInfoForm.LoadForm();
            }
            catch
            {
                MessageBox.Show("Не удалось редактировать нарушение");
            }
            finally
            {
                con.Close();
            }
        }

        private void EditViolationForm_Load(object sender, EventArgs e)
        {
            this.violationsTableAdapter.Fill(this.state_vehicle_inspection_dbDataSet.violations);
        }
    }
}