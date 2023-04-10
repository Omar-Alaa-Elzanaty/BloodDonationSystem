using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonationSystem
{
    public static class Login
    {
        public static Account createuser(string userName,string password)
        {
            Database.Connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"select * from Account where userName='{userName}' and pass='{password}';", Database.Connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            { 
                Database.Connection.Close();

                Account user=new Account(int.Parse(dt.Rows[0]["acc_id"].ToString()), userName, password,
                                        dt.Rows[0]["isPerson"].ToString());

                if (user.IsPerson == true)
                {
                    return Loginasperson.createpersonaluseraccount(user);
                }
                else
                {
                    return Loginasorganization.createorganizationaccount(user);
                }
            }
            Database.Connection.Close();
            return null;
        }
    }
}
