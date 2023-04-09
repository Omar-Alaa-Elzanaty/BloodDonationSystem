using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonationSystem
{
    public class Account
    {
        protected int id=-1;
        protected string userName=null;
        protected string password=null;
        protected bool isPerson=false;
        protected Signupoperation signUpOf;
        public bool runsignup()
        {
            return signUpOf.signup(this);
        }

        public virtual List<KeyValuePair<string, string>> getdonationhistory()
        {
            if (userName == null || password == null)
                return null;
            if (isPerson == true)
            {

            }
            return new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("s", "s") 
            };
        }
    }
}
