using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonationSystem
{
    static internal class Database
    {
        public static SqlConnection Connection => new SqlConnection("Data Source=.;Initial Catalog=BloodDonationsystemdb;Integrated Security=True");
    }
}
