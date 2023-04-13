using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BloodDonationSystem
{
    public partial class Form4 : Form
    {
        //Person 
        Person user;
        public Form4(Person user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(user);
            form6.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
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
                MessageBox.Show("You didn't donate before");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int x = 5;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(user.FirstName + ' ' + user.LastName + '\n' + user.Email + '\n' + user.BloodType);
        }
    }
}
