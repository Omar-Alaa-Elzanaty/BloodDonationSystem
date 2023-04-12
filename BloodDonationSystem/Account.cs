using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BloodDonationSystem
{
    public class Account
    {
        protected int id = -1;
        protected string userName;
        protected string password;
        protected bool isPerson = false;
        protected Signupoperation signUpOf;
        public int ID => id;
        public string UserName => userName;
        public string Password => password;
        public bool IsPerson => isPerson;
        public Account()
        {
            
        }
        public Account(int id, string userName, string password, string isPerson)
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
            if (isPerson == "T" || isPerson == "t")
            {
                this.isPerson = true;
            }
            else
            {
                this.isPerson = false;
            }
        }
        public Account(Account user)
        {
            this.id= user.id;
            this.userName = user.userName;
            this.password = user.password;
            this.isPerson = user.isPerson;
            this.isPerson= user.isPerson;
        }
        public bool runsignup()
        {
            return signUpOf.signup(this);
        }
        /// <summary>
        /// in default way it give full data of organization or person according type of account
        /// </summary>
        /// <returns></returns>
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
                 cmd = new SqlCommand($"select distinct org_name,city from Donation,Organization where pid={id} and orgid=O_id;",
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
                cmd = new SqlCommand($"select distinct fname,lname from Donation,person where orgid={id} and p_id=pid;",
                                               Database.Connection);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                string firstName, lastName;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    firstName = dt.Rows[i]["fname"].ToString();
                    lastName = dt.Rows[i]["lname"].ToString();
                    list.Add(new Tuple<string, string>(firstName, lastName));
                }
                Database.Connection.Close();
                return list;
            }
        }
    }
}
