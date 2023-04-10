using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonationSystem
{
    internal class Personsignup : Signupoperation
    {
        public bool signup(Account account)
        {
            account = Login.createuser(account.UserName, account.Password);
            if(account is Person man)
            {
                SqlCommand conn = new SqlCommand("insert into Account values(@user,@pass,'t');declare @x int= @@IDENTITY;insert into Person values(@x,@fn,@ln,@email,@blood);", Database.Connection);
                conn.Parameters.AddWithValue("@user", man.UserName);
                conn.Parameters.AddWithValue("@pass", man.Password);
                conn.Parameters.AddWithValue("@fn", man.FirstName);
                conn.Parameters.AddWithValue("@ln", man.Email);
                conn.Parameters.AddWithValue("@email", man.Email);
                conn.Parameters.AddWithValue("@blood", man.BloodType);
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
