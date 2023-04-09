using System;
using System.Collections.Generic;
using System.Linq;
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
        public Person()
        {
            signUpOf = new Personsignup();
            //implement startgy pattern
        }
        public Person(int id)
        {
            //implement startgy pattern
        }
        public string donate(int organizationid)
        {
            return null;
        }

        public override List<Tuple<string, string>> getdonationhistory()
        {
            return null;
        }
    }
}
