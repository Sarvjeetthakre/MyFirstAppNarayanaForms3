using MyFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyFirstApp.Repository
{
    public class DoctorProfileRepository
    {
        public List<DoctoreModel> GetDoctoreQualification()
        {
            List<DoctoreModel> doctoreQualificationList = new List<DoctoreModel>();
            //database connection
            string mydbcon = @"Data Source=.;Initial Catalog=DOCTORE; integrated security=true";
            using (SqlConnection connection = new SqlConnection(mydbcon))
            {
                try 
                { 
                    connection.Open();
                
                    using (SqlCommand cmd = new SqlCommand("Select DOCTOR_QUALIFICATION_ID, DOCTOR_QUALIFICATION_NAME from TBL_DOCTOR_QUALIFICATION", connection))
                    {

                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {

                            while (rd.Read())
                            {
                                doctoreQualificationList.Add(new DoctoreModel()
                                {
                                    Doctor_Id = Convert.ToInt32(rd["DOCTOR_QUALIFICATION_ID"]),
                                    DOCTOR_QUALIFICATION_Name = Convert.ToString(rd["Doctor_Qualification_Name"])
                                });
                            }
                        }
                    }


                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if(connection.State==System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }

                }


            }
            return doctoreQualificationList;

        }

    }
}

               