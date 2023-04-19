using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonationSystem
{
    public static class Donation
    {
        public static Dictionary<string,int> Organizationlist()
        {
            SqlCommand cmd = new SqlCommand($"select O_id,org_name from Organization",
                                               Database.Connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Dictionary<string,int>bloodBank = new Dictionary<string, int>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bloodBank.Add(dt.Rows[i]["org_name"].ToString(),int.Parse(dt.Rows[i]["O_id"].ToString()));
            }
            if(bloodBank.Count > 0)
            {
                return bloodBank;
            }
            else
            {
                return null;
            }
        }

        public static string recordprocess(int personId,int organizationId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand($"insert into Donation (pid,orgid)values(@personId,@organizationId);",Database.Connection);
                cmd.Parameters.AddWithValue("@personId",personId);
                cmd.Parameters.AddWithValue("@organizationId",organizationId);
                Database.Connection.Open();
                cmd.ExecuteNonQuery();
                Database.Connection.Close();
                return "Thanks for Donation";
            }
            catch
            {
                Database.Connection.Close();
                return "sorry..,You can't donate more than one in same day";
            }
        }
    }
}
