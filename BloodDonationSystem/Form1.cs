using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;

namespace BloodDonationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"select bloodtype,count(bloodtype) as amount from Person,Donation where orgid= {3} and pid=p_id group by bloodtype;",
                                             Database.Connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Dictionary<string, int> bloodReport = new Dictionary<string, int>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bloodReport.Add(dt.Rows[i]["bloodtype"].ToString(), int.Parse(dt.Rows[i]["amount"].ToString()));
            }
        }
    }
}