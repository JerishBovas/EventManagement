using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSAssignmentTwo
{
    public partial class AddRsvpControl : UserControl
    {
        public AddRsvpControl()
        {
            InitializeComponent();
        }

        private void AddRsvpControl_Load(object sender, EventArgs e)
        {
            viewCustomers();
            viewEvents();
            errorLabel.Text = "";
            button1.Click += addRsvpButton_Click;
        }

        private void addRsvpButton_Click(object sender, EventArgs e)
        {
            int custId, evenId;
            if(int.TryParse(textBox1.Text, out custId))
            {
                if(int.TryParse(textBox2.Text, out evenId))
                {
                    errorLabel.Text = "";
                    if(Program.addRsvp(custId, evenId))
                    {
                        MessageBox.Show("RSVP Added Successfully...");
                    }
                    else
                    {
                        MessageBox.Show("RSVP Addition Failed...");
                    }
                    Program.mainForm.addRSVPToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    errorLabel.Text = "Please enter an integer for Event ID";
                }
            }
            else
            {
                errorLabel.Text = "Please enter an integer for Customer ID";
            }
        }

        public void viewEvents()
        {
            listView2.View = View.Details;
            listView2.LabelEdit = false;
            listView2.AllowColumnReorder = false;
            listView2.CheckBoxes = false;
            listView2.FullRowSelect = false;
            listView2.GridLines = true;
            listView2.Sorting = SortOrder.None;

            listView2.Columns.Add("Event ID", 150, HorizontalAlignment.Center);
            listView2.Columns.Add("Event Name", 200, HorizontalAlignment.Center);
            listView2.Columns.Add("Venue", 200, HorizontalAlignment.Center);

            listView2.Items.AddRange(getAllLists(Program.getEventString()));
        }
        public void viewCustomers()
        {
            listView1.View = View.Details;
            listView1.LabelEdit = false;
            listView1.AllowColumnReorder = false;
            listView1.CheckBoxes = false;
            listView1.FullRowSelect = false;
            listView1.GridLines = true;
            listView1.Sorting = SortOrder.None;

            listView1.Columns.Add("Customer ID", 135, HorizontalAlignment.Center);
            listView1.Columns.Add("First Name", 140, HorizontalAlignment.Center);
            listView1.Columns.Add("Last Name", 140, HorizontalAlignment.Center);
            listView1.Columns.Add("Phone Number", 135, HorizontalAlignment.Center);

            listView1.Items.AddRange(getAllLists(Program.getCustomerString()));
        }
        private ListViewItem[] getAllLists(string[][] str)
        {
            ListViewItem[] lvi = new ListViewItem[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                lvi[i] = new ListViewItem(str[i]);
            }
            return lvi;
        }
    }
}
