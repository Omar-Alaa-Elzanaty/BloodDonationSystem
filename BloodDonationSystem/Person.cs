using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonationSystem
{
    public class Person:Account
    {
        string firstName;
        string lastName;
        string email;
        string bloodType;

        public string FirstName => firstName;
        public string LastName => lastName;
        public string Email => email;
        public string BloodType => bloodType;

        public Person(string user,string pass, string firstName, string lastName, string email, string bloodType)
        {
            this.userName = user;
            this.password = pass;
            this.isPerson = true;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.bloodType = bloodType;
            signUpOf = new Personsignup();
        }
        public Person(Account user,string firstName, string lastName, string email, string bloodType):base(user)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.bloodType = bloodType;
            signUpOf = new Personsignup();
        }
        public Person()
        {
            signUpOf = new Personsignup();
            //implement startgy pattern
        }
        public void donate(int organizationid)
        {
            Donation.recordprocess(this.id,organizationid);
        }
        /// <summary>
        /// return list of organizations names and dates of donation
        /// </summary>
        /// <returns></returns>
        public override List<Tuple<string, string>> getdonationhistory()
        {
            try
            {
                SqlCommand cmd = new SqlCommand($"select org_name, dateofdonation from Organization, Donation where pid = {this.id} and orgid = O_id;",
                                               Database.Connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                List<Tuple<string, string>> PersonHistory=new List<Tuple<string, string>>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PersonHistory.Add( new Tuple<string,string>(dt.Rows[i]["org_name"].ToString(), dt.Rows[i]["dateofdonation"].ToString()));
                }
                if (PersonHistory.Count > 0)
                {
                    return PersonHistory;
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
