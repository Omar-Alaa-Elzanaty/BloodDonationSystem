using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonationSystem
{
    internal class Organizationsignup : Signupoperation
    {
        public bool signup(Account account)
        {
            if (account is Organization Bloodbank)
            {
                SqlCommand conn = new SqlCommand("insert into Account values(@user,@pass,'t');declare @x int= @@IDENTITY;insert into Person values(@x,@name,@contact,@city,);", Database.Connection);
                conn.Parameters.AddWithValue("@user", Bloodbank.ID);
                conn.Parameters.AddWithValue("@pass", Bloodbank.Password);
                conn.Parameters.AddWithValue("@name", Bloodbank.Name);
                conn.Parameters.AddWithValue("@contact", Bloodbank.ContactNum);
                conn.Parameters.AddWithValue("@city", Bloodbank.City);
                Database.Connection.Open();
                try
                {
                    conn.ExecuteNonQuery();
                }
                catch
                {
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
