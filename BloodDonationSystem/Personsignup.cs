using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonationSystem
{
    internal class Personsignup : Signupoperation
    {
        public bool signup(Account account)
        { 
            if(account is Person man)
            {
                //to implement
            }
            throw new NotImplementedException();
        }
    }
}
