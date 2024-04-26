using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_registration_admin_panel
{
    public class User
    {
        string connectionString = "Data Source=LAPTOPSADIK;Initial Catalog=state_vehicle_inspection_db;Integrated Security=True";

        public int userId;
        public string login;
        public string password;
        public string surname;
        public string firstname;
        public string middlename;
        public string birthDate;
        public string email;
        public string phone;

        public bool isAdmin = false;

        public User(int userId, bool isAdmin)
        {
            this.userId = userId;
            this.isAdmin = isAdmin;

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("GetUserInfo", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@userId", userId);

            SqlParameter surnameParam = new SqlParameter("@surname", SqlDbType.NVarChar, 50);
            surnameParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(surnameParam);

            SqlParameter firstnameParam = new SqlParameter("@firstname", SqlDbType.NVarChar, 50);
            firstnameParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(firstnameParam);    

            SqlParameter middlenameParam = new SqlParameter("@middlename", SqlDbType.NVarChar, 50);
            middlenameParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(middlenameParam);

            SqlParameter birthDateParam = new SqlParameter("@birthDate", SqlDbType.Date);
            birthDateParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(birthDateParam);       

            SqlParameter emailParam = new SqlParameter("@email", SqlDbType.NVarChar, 50);
            emailParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(emailParam);   

            SqlParameter phoneParam = new SqlParameter("@phone", SqlDbType.NVarChar, 50);
            phoneParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(phoneParam);

            try
            {
                con.Open();

                cmd.ExecuteNonQuery();

                this.surname = (string)surnameParam.Value;
                this.firstname = (string)firstnameParam.Value;
                this.middlename = (string)middlenameParam.Value;
                this.birthDate = ((DateTime)birthDateParam.Value).ToString("dd-MM-yyyy");
                this.email = (string)emailParam.Value;
                this.phone = (string)phoneParam.Value;
            }
            finally
            {
                con.Close();
            }
        }

        public void updateUser(string email, string phone)
        {
            this.phone = phone;
            this.email = email;
        }
    }
}
