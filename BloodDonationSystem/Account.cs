using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BloodDonationSystem
{
    public class Account
    {
        protected int id = -1;
        protected string userName = null;
        protected string password = null;
        protected bool isPerson = false;
        protected Signupoperation signUpOf;
        public bool runsignup()
        {
            return signUpOf.signup(this);
        }

        public virtual List<Tuple<string, string>> getdonationhistory()
        {
            if (userName == null || password == null)
                return null;
            Database.Connection.Open();
            SqlCommand cmd;
            SqlDataAdapter adapter;
            DataTable dt;
            List<Tuple<string, string>> list = new List<Tuple<string, string>>();
            if (isPerson == true)
            {  
                 cmd = new SqlCommand($"select org_name,city from Donation,Organization where pid={id} and orgid=O_id;",
                                                Database.Connection);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                string organizationName, cityOfOrganization;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                     organizationName = dt.Rows[i]["org_name"].ToString();
                     cityOfOrganization = dt.Rows[i]["city"].ToString();
                    list.Add(new Tuple<string, string>(organizationName, cityOfOrganization));
                }
                Database.Connection.Close();
                return list;
            }
            else
            {
                cmd = new SqlCommand($"select fname,lname from Donation,person where orgid={id} and p_id=pid;",
                                               Database.Connection);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                string firstName, lastName;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    firstName = dt.Rows[i]["org_name"].ToString();
                    lastName = dt.Rows[i]["city"].ToString();
                    list.Add(new Tuple<string, string>(firstName, lastName));
                }
                Database.Connection.Close();
                return list;
            }
        }
    }
}
