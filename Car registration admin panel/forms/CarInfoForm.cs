using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_registration_admin_panel
{
    public partial class CarInfoForm : Form
    {
        MainForm mainForm;
        forms.AddViolationForm addViolationForm;
        forms.EditViolationForm editViolationForm;

        Car carInfo;
        User carInfoUser;

        int selectedCarViolationId;

        private SqlDataAdapter adapter;
        private DataSet ds;
        private SqlConnection con;

        DataView carViolationsView;

        public void LoadForm()
        {
            carModelLabel.Text = carInfo.carModel;
            carYearLabel.Text = carInfo.carYear;
            carNumberLabel.Text = carInfo.carNumber + " " + carInfo.carSeries.Trim() + "-" + carInfo.carRegisterRegionCode;
            carColorLabel.Text = carInfo.carColor;

            deleteViolationButton.Visible = false;
            editViolationButton.Visible = carInfoUser.isAdmin;
            addViolationButton.Visible = carInfoUser.isAdmin;

            con = new SqlConnection(Properties.Resources.CONNECTION_STRING);
            SqlCommand command = new SqlCommand("GetCarViolations", con);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@carId", carInfo.carId);

            try
            {
                con.Open();

                adapter = new SqlDataAdapter(command);

                ds = new DataSet();

                adapter.Fill(ds, "carViolations");

                carViolationsView = new DataView(ds.Tables["carViolations"]);

                carViolationsDataGridView.DataSource = carViolationsView;

                if ((carViolationsDataGridView.RowCount - 1) == 0)
                {
                    carViolationsDataGridView.Visible = false;
                    editViolationButton.Visible = false;
                    deleteViolationButton.Visible = false;
                }
                else
                {
                    carViolationsDataGridView.Visible = true;
                    noDataLabel.Visible = false;
                }
            }
            finally
            {
                con.Close();
            }

            carViolationsDataGridView.Columns[0].Visible = false;
            carViolationsDataGridView.Columns[1].HeaderText = "Нарушение";
            carViolationsDataGridView.Columns[2].HeaderText = "Время нарушения";
        }

        public CarInfoForm(Car car, User user)
        {
            carInfo = car;
            carInfoUser = user;

            InitializeComponent();

            LoadForm();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (mainForm == null || mainForm.IsDisposed)
            {
                mainForm = new MainForm(carInfoUser);
                mainForm.Show();

                this.Hide();
            }
        }


        private void selectRowHandler(object sender, EventArgs e)
        {
            if (carViolationsDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = carViolationsDataGridView.SelectedRows[0];

                string carViolationId = selectedRow.Cells["carViolationId"].Value.ToString();

                if (!string.IsNullOrEmpty(carViolationId))
                {
                    editViolationButton.Enabled = true;
                    deleteViolationButton.Visible = carInfoUser.isAdmin;

                    selectedCarViolationId = Convert.ToInt32(carViolationId);
                }
            }
            else
            {
                editViolationButton.Enabled = false;
                deleteViolationButton.Visible = false;
            }
        }

        private void deleteViolationButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con = new SqlConnection(Properties.Resources.CONNECTION_STRING);
                SqlCommand command = new SqlCommand("DeleteCarViolation", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@carViolationId", selectedCarViolationId);

                try
                {
                    con.Open();
                    command.ExecuteNonQuery();

                    foreach (DataGridViewRow row in carViolationsDataGridView.Rows)
                    {
                        if (row.Cells["carViolationId"].Value.ToString() == selectedCarViolationId.ToString())
                        {
                            carViolationsDataGridView.Rows.Remove(row);
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

        private void addViolationButton_Click(object sender, EventArgs e)
        {
            if (addViolationForm == null || addViolationForm.IsDisposed)
            {
                addViolationForm = new forms.AddViolationForm(carInfo.carId, this);
                addViolationForm.Show();
            }
        }

        private void editViolationButton_Click(object sender, EventArgs e)
        {
            if (editViolationForm == null || editViolationForm.IsDisposed)
            {
                editViolationForm = new forms.EditViolationForm(selectedCarViolationId, this);
                editViolationForm.Show();
            }
        }
    }
}