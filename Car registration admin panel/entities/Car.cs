using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_registration_admin_panel
{
    public class Car
    {
        string connectionString = "Data Source=LAPTOPSADIK;Initial Catalog=state_vehicle_inspection_db;Integrated Security=True";

        public int carId;
        public string carModel;
        public string carYear;
        public string carMileage;
        public string carColor;
        public string carNumber;
        public string carSeries;
        public string carRegisterRegionCode;

        public int userId;
        
        public Car(int carId)
        {
            this.carId = carId;

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("GetCarById", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@carId", carId);

            SqlParameter carModelParam = new SqlParameter("@carModel", SqlDbType.NVarChar, 50);
            carModelParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(carModelParam);

            SqlParameter carYearParam = new SqlParameter("@carYear", SqlDbType.NVarChar, 50);
            carYearParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(carYearParam);

            SqlParameter carNumberParam = new SqlParameter("@carNumber", SqlDbType.NVarChar, 50);
            carNumberParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(carNumberParam);

            SqlParameter carSeriesParam = new SqlParameter("@carSeries", SqlDbType.NVarChar, 50);
            carSeriesParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(carSeriesParam);

            SqlParameter carRegisterRegionCodeParam = new SqlParameter("@carRegisterRegionCode", SqlDbType.NVarChar, 50);
            carRegisterRegionCodeParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(carRegisterRegionCodeParam);

            SqlParameter carColorParam = new SqlParameter("@carColor", SqlDbType.NVarChar, 50);
            carColorParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(carColorParam);

            try
            {
                con.Open();

                cmd.ExecuteNonQuery();

                this.carModel = (string)carModelParam.Value;
                this.carYear = (string)carYearParam.Value;
                this.carNumber = (string)carNumberParam.Value;
                this.carSeries = (string)carSeriesParam.Value;
                this.carRegisterRegionCode = (string)carRegisterRegionCodeParam.Value;
                this.carColor = (string)carColorParam.Value;
            }
            finally
            {
                con.Close();
            }
        }

    }
}
