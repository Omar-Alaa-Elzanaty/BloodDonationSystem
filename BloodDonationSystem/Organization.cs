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
        string contactnum;
        string city;

        public Organization()
        {
            name = "No name";
            contactnum = "No number";
            city = "NO location";
            //implement startgy pattern
        }
        public Organization(int id)
        {
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
