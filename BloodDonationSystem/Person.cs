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

        public string FirstName => firstName;
        public string LastName => lastName;
        public string Email => email;
        public string BloodType => bloodType;

        public Person(int id,string user,string pass, string firstName, string lastName, string email, string bloodType)
        {
            this.id = id;
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
