using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonationSystem
{
    internal static class Loginasperson
    { 
        public static Person accountbuilder(Account user)
        {
            Database.Connection.Open();
            SqlDataAdapter rowInfo = new SqlDataAdapter($"select * from person where p_id='{user.ID}';",Database.Connection); 
            DataTable personInfo = new DataTable();
            rowInfo.Fill(personInfo);
            Database.Connection.Close();
            return new Person(user, personInfo.Rows[0]["fname"].ToString(), personInfo.Rows[0]["lname"].ToString()
                             , personInfo.Rows[0]["email"].ToString(), personInfo.Rows[0]["bloodtype"].ToString());
        }
    }
}
