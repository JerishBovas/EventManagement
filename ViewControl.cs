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
    public partial class ViewControl : UserControl
    {
        public ViewControl(int num)
        {
            InitializeComponent();
            methodSelector(num);
        }

        public void allRsvps()
        {
            listLabel.Text = "All RSVPs";
            errorLabel.Text = "";
            searchButton.Text = "Add RSVP";
            searchButton.Click += viewAllRsvpsButton_Click;
        }

        public void oneEvent()
        {
            listLabel.Text = "Event Details";
            searchId.Text = "Please enter the Event ID to Search: ";
            searchId.Visible = true;
            idBox.Visible = true;
            errorLabel.Text = "";
            errorLabel.Visible = true;
            searchButton.Text = "View Details";
            searchButton.Click += viewOneEventButton_Click;
        }
        public void allEvents()
        {
            listLabel.Text = "All Events";
            errorLabel.Text = "";
            searchButton.Text = "Add Event";
            searchButton.Click += viewAllEventsButton_Click;
        }

        public void deleteCustomer()
        {
            listLabel.Text = "Delete Customer";
            searchId.Text = "Please enter the Customer ID to Delete: ";
            searchId.Visible = true;
            idBox.Visible = true;
            errorLabel.Text = "";
            errorLabel.Visible = true;
            searchButton.Text = "Delete";
            searchButton.Click += deleteCustomerButton_Click;
        }
        public void oneCustomer()
        {
            listLabel.Text = "Customer Details";
            searchId.Text = "Please enter the Customer ID to Search: ";
            searchId.Visible = true;
            idBox.Visible = true;
            errorLabel.Text = "";
            errorLabel.Visible = true;
            searchButton.Text = "View Details";
            searchButton.Click += viewOneCustomerButton_Click;
        }
        public void allCustomers()
        {
            listLabel.Text = "All Customers";
            errorLabel.Text = "";
            searchButton.Text = "Add Customer";
            searchButton.Click += viewAllCustomersButton_Click;
        }

        public void viewRsvps()
        {
            listView1.View = View.Details;
            listView1.LabelEdit = false;
            listView1.AllowColumnReorder = false;
            listView1.CheckBoxes = false;
            listView1.FullRowSelect = false;
            listView1.GridLines = true;
            listView1.Sorting = SortOrder.None;

            listView1.Columns.Add("RSVP Date", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("RSVP ID", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("Customer Name", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("Event ID", 150, HorizontalAlignment.Center);

            listView1.Items.AddRange(getAllLists(Program.getRsvpString()));
        }
        public void viewEvents()
        {
            listView1.View = View.Details;
            listView1.LabelEdit = false;
            listView1.AllowColumnReorder = false;
            listView1.CheckBoxes = false;
            listView1.FullRowSelect = false;
            listView1.GridLines = true;
            listView1.Sorting = SortOrder.None;

            listView1.Columns.Add("Event ID", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("Event Name", 225, HorizontalAlignment.Center);
            listView1.Columns.Add("Venue", 225, HorizontalAlignment.Center);

            listView1.Items.AddRange(getAllLists(Program.getEventString()));
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

            listView1.Columns.Add("Customer ID", 140, HorizontalAlignment.Center);
            listView1.Columns.Add("First Name", 170, HorizontalAlignment.Center);
            listView1.Columns.Add("Last Name", 170, HorizontalAlignment.Center);
            listView1.Columns.Add("Phone Number", 170, HorizontalAlignment.Center);

            listView1.Items.AddRange(getAllLists(Program.getCustomerString()));
        }

        private void viewAllRsvpsButton_Click(object sender, EventArgs e)
        {
            Program.mainForm.addRSVPToolStripMenuItem_Click(sender, e);
        }

        private void viewOneEventButton_Click(object sender, EventArgs e)
        {
            int id;
            string str = idBox.Text;
            if (int.TryParse(str, out id))
            {
                errorLabel.Text = "";
                MessageBox.Show(Program.getEventDetails(id));
            }
            else
            {
                errorLabel.Text = "Please check your Event ID";
            }
        }

        private void viewAllEventsButton_Click(object sender, EventArgs e)
        {
            Program.mainForm.addEventToolStripMenuItem_Click(sender, e);
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            int id;
            string str = idBox.Text;
            if (int.TryParse(str, out id))
            {
                errorLabel.Text = "";
                if(Program.deleteCustomer(id))
                {
                    MessageBox.Show("Customer Deleted Successfully...");
                }
                else
                {
                    MessageBox.Show("Sorry, Customer Deletion Failed...");
                }
                Program.mainForm.deleteCustomerToolStripMenuItem_Click(this, e);
            }
            else
            {
                errorLabel.Text = "Please check your Customer ID";
            }
        }

        private void viewOneCustomerButton_Click(object sender, EventArgs e)
        {
            int id;
            string str = idBox.Text;
            if(int.TryParse(str, out id))
            {
                errorLabel.Text = "";
                MessageBox.Show(Program.getCustomerDetails(id));
            }
            else
            {
                errorLabel.Text = "Please check your Customer ID";
            }
        }
        private void viewAllCustomersButton_Click(object sender, EventArgs e)
        {
            Program.mainForm.addCustomerToolStripMenuItem_Click(sender, e);
        }
        
        private ListViewItem[] getAllLists(string[][] str)
        {
            ListViewItem[] lvi = new ListViewItem[str.Length];
            for(int i = 0; i < str.Length; i++)
            {
                lvi[i] = new ListViewItem(str[i]);
            }
            return lvi;
        }

        private void methodSelector(int num)
        {
            switch (num)
            {
                case 1:
                    viewCustomers();
                    allCustomers();
                    break;
                case 2:
                    viewCustomers();
                    oneCustomer();
                    break;
                case 3:
                    viewCustomers();
                    deleteCustomer();
                    break;
                case 4:
                    viewEvents();
                    allEvents();
                    break;
                case 5:
                    viewEvents();
                    oneEvent();
                    break;
                case 6:
                    viewRsvps();
                    allRsvps();
                    break;
            }
        }
    }
}
