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
            if (Login.createuser(account.UserName, account.Password) != null)
            {
                return false;
            }
            if (account is Organization Bloodbank)
            {
                SqlCommand conn = new SqlCommand("insert into Account values(@user,@pass,'f');declare @id int;select @id=acc_id from Account where username=@user;select @id;insert into Person values(@id,@name,@contact,@city,);", Database.Connection);
                conn.Parameters.AddWithValue("@user", Bloodbank.UserName);
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
