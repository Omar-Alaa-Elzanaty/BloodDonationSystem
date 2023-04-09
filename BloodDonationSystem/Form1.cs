using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            int id = 3;
            Database.Connection.Open();
            SqlCommand cmd;
            SqlDataAdapter adapter;
            DataTable dt;
            List<Tuple<string, string>> list = new List<Tuple<string, string>>();
            cmd = new SqlCommand($"select fname,lname from Donation,person where orgid={id} and p_id=pid;",
                                              Database.Connection);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            string firstName, lastName;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                firstName = dt.Rows[i]["fname"].ToString();
                lastName = dt.Rows[i]["lname"].ToString();
                list.Add(new Tuple<string, string>(firstName, lastName));
            }
            Database.Connection.Close();
        }
    }
}