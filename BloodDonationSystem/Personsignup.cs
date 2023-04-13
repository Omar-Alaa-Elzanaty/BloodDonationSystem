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
            if (Login.createuser(account.UserName, account.Password) != null)
            {
                return false;
            }
            if(account is Person man)
            {
                try
                {
                    SqlCommand conn = new SqlCommand("insert into Account values(@user,@pass,'t');declare @id int;select @id=acc_id from Account where username=@user;select @id;insert into Person values(@id,@fn,@ln,@email,@blood);", Database.Connection);
                    conn.Parameters.AddWithValue("@user", man.UserName);
                    conn.Parameters.AddWithValue("@pass", man.Password);
                    conn.Parameters.AddWithValue("@fn", man.FirstName);
                    conn.Parameters.AddWithValue("@ln", man.LastName);
                    conn.Parameters.AddWithValue("@email", man.Email);
                    conn.Parameters.AddWithValue("@blood", man.BloodType);
                    Database.Connection.Open();
                    conn.ExecuteNonQuery();
                }
                catch
                {
                    Database.Connection.Close();
                    return false;
                }
                Database.Connection.Close();
                return true;
            }
            return false;
        }
    }
}
