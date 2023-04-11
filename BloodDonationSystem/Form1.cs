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
            int id = 2;
            SqlCommand cmd = new SqlCommand($"select org_name, dateofdonation from Organization, Donation where pid = {id} and orgid = O_id;",
                               Database.Connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            for(int i=0;i<dt.Rows.Count;i++)
            {
                var x = dt.Rows[i]["org_name"].ToString();
                var y = dt.Rows[i]["dateofdonation"].ToString();
            }
        }
    }
}