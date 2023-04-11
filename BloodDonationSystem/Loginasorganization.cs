using System.Data;
using System.Data.SqlClient;

namespace BloodDonationSystem
{
    internal static class Loginasorganization
    {
        public static Organization accountbuilder(Account user)
        {

            Database.Connection.Open();
            SqlDataAdapter rowInfo = new SqlDataAdapter($"select * from Organization where O_id='{user.ID}';", Database.Connection);
            DataTable personInfo = new DataTable();
            rowInfo.Fill(personInfo);
            Database.Connection.Close();
            return new Organization(user, personInfo.Rows[0]["org_name"].ToString(),
                         personInfo.Rows[0]["contactnum"].ToString(), personInfo.Rows[0]["city"].ToString());
        }
    }
}
