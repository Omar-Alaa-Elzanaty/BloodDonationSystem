using System;
using System.Collections.Generic;
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
        public Organization(int id)
        {
            signUpOf = new Organizationsignup();
            //implement startgy pattern
        }

        public override List<Tuple<string, string>> getdonationhistory()
        {
            return null;
        }

        public Dictionary<string,int> bloodamountreport()
        {
            //t
            return null;
        }
    }
}
