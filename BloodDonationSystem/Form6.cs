using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodDonationSystem
{
    public partial class Form6 : Form
    {
        Person user;
        public Form6(Person user)
        {
            InitializeComponent();
            this.user = user;
            foreach (var organize in Donation.Organizationlist())
            {
                listView1.Items.Add(organize.Value.ToString()).SubItems.Add(organize.Key);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text.ToString(),out int id)&&Donation.Organizationlist().ContainsValue(id)) 
            {
                MessageBox.Show(this.user.donate(id));
                this.Visible = false;
                Form4 form4 = new Form4(user);
                form4.Show();
            }
            else
            {
                MessageBox.Show("Please enter vaild Organziation ID");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 form4 = new Form4(user);
            form4.Show();
        }
    }
}
