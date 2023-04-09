using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonationSystem
{
    internal class Database
    {
        public SqlConnection Connection => new SqlConnection("Data Source=.;Initial Catalog=BloodDonationsystemdb;Integrated Security=True");
    }
}
