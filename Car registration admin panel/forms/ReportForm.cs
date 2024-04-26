using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Car_registration_admin_panel.forms
{
    public partial class ReportForm : Form
    {
        int userId;
        string surname;
        string firstname;
        string middlename;

        public ReportForm(string surname, string firstname, string middlename, int userId)
        {
            this.userId = userId;
            this.surname = surname;
            this.firstname = firstname;
            this.middlename = middlename;

            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            string fio = $"{surname} {firstname} {middlename}";

            ReportParameter reportParam = new ReportParameter("FIO", fio);
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { reportParam });

            this.carsTableAdapter.Fill(this.state_vehicle_inspection_dbDataSet.cars);

            DataView dataView = new DataView(state_vehicle_inspection_dbDataSet.cars);

            dataView.RowFilter = $"userId = {userId}";
            carsBindingSource.DataSource = dataView;
       
            this.reportViewer1.RefreshReport();
        }
    }
}
