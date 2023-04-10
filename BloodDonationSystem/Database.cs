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
        static SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=BloodDonationsystemdb;Integrated Security=True");
        public static SqlConnection Connection =>connection;
    }
}
