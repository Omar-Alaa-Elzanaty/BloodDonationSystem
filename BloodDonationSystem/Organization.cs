using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonationSystem
{
    public class Organization: Account
    {
        string name;
        string contactNum;
        string city;

        public string Name => name;
        public string ContactNum  => contactNum;
        public string City  => city; 

        public Organization(int id,string user,string pass, string name, string contactNum, string city)
        {
            this.id = id;
            this.userName = user;
            this.password = pass;
            this.isPerson = false;
            this.name = name;
            this.contactNum = contactNum;
            this.city = city;
            signUpOf = new Organizationsignup();
        }
        public Organization(Account user,string name, string contactNum, string city):base(user)
        {
            this.name = name;
            this.contactNum = contactNum;
            this.city = city;
            signUpOf = new Organizationsignup();
        }

        public Organization()
        {
            name = "No name";
            contactNum = "No number";
            city = "NO location";
            signUpOf=new Organizationsignup();
            //implement startgy pattern
        }
        public override List<Tuple<string, string>> getdonationhistory()
        {
            try
            {
                SqlCommand cmd = new SqlCommand($"select Fname+' '+Lname as fullname,bloodtype from Person,Donation where orgid={this.id} and pid=p_id;",
                                               Database.Connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                List<Tuple<string, string>> donationOfPeople = new List<Tuple<string, string>>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    donationOfPeople.Add(new Tuple<string, string>(dt.Rows[i]["fullname"].ToString(), dt.Rows[i]["bloodtype"].ToString()));
                }
                if(donationOfPeople.Count > 0)
                {
                    return donationOfPeople;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public Dictionary<string,int> bloodamountreport()
        {
            try
            {
                SqlCommand cmd = new SqlCommand($"select bloodtype,count(bloodtype) as amount from Person,Donation where orgid={this.id} and pid=p_id group by bloodtype;",
                                              Database.Connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Dictionary<string, int> bloodReport = new Dictionary<string, int>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    bloodReport.Add(dt.Rows[i]["bloodtype"].ToString(), int.Parse(dt.Rows[i]["amount"].ToString()));
                }
                if (bloodReport.Count > 0)
                {
                    return bloodReport;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
            
        }
    }
}
