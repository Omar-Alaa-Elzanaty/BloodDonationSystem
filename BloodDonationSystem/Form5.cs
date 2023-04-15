using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodDonationSystem
{
    public partial class Form5 : Form
    {
        Organization user;
        public Form5(Organization user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var report = user.bloodamountreport();
            if (report != null)
            {
                foreach (var column in report)
                {
                    listView2.Items.Add(column.Key).SubItems.Add(column.Value.ToString());
                }
            }
            else
            {
                listView2.Items.Add("O+").SubItems.Add("0");
                listView2.Items.Add("O-").SubItems.Add("0");
                listView2.Items.Add("A+").SubItems.Add("0");
                listView2.Items.Add("A-").SubItems.Add("0");
                listView2.Items.Add("B+").SubItems.Add("0");
                listView2.Items.Add("B-").SubItems.Add("0");
                listView2.Items.Add("AB+").SubItems.Add("0");
                listView2.Items.Add("AB-").SubItems.Add("0");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Name: {user.Name}\nContactNumber: {user.ContactNum}\nLocation: {user.City}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var historyList = user.getdonationhistory();
            if (historyList != null)
            {
                foreach (var i in historyList)
                {
                    listView1.Items.Add(i.Item1).SubItems.Add(i.Item2);
                }
            }
            else
            {
                MessageBox.Show("Couldn't find any donator");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
