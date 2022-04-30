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
    public partial class AddControl : UserControl
    {
        public AddControl(int option)
        {
            InitializeComponent();
            if(option == 1)
            {
                customerControl();
            }
            else if(option == 2)
            {
                eventControl();
            }
        }

        private void customerControl()
        {
            headLabel.Text = "Add Customer";
            label1.Text = "First Name: ";
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Text = "Last Name: ";
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Text = "Phone Number: ";
            label3.Visible = true;
            textBox3.Visible = true;
            errorLabel.Text = "";
            errorLabel.Visible = true;
            addButton.Text = "Add Customer";
            addButton.Click += customerAddButton_Click;
        }
        private void eventControl()
        {
            headLabel.Text = "Add Event";
            label1.Text = "Event Name: ";
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Text = "Event Venue: ";
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Text = "Maximum Attentees: ";
            label3.Visible = true;
            textBox3.Visible = true;

            label4.Text = "Event Date: ";
            label4.Visible = true;
            datePicker.MinDate = DateTime.Today;
            datePicker.MaxDate = new DateTime(2021, 12, 31);
            datePicker.Visible = true;

            label5.Text = "Event Time: ";
            label5.Visible = true;
            timePicker.Visible = true;
            

            errorLabel.Text = "";
            errorLabel.Visible = true;
            addButton.Text = "Add Event";
            addButton.Click += eventAddButton_Click;
        }

        private void customerAddButton_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string phNum = textBox3.Text;

            if(firstName != "" && lastName != "")
            {
                if(phNum != "")
                {
                    errorLabel.Text = "";
                    if(Program.addCustomer(firstName, lastName, phNum))
                    {
                        MessageBox.Show("Customer Added Successfully...");
                    }
                    else
                    {
                        MessageBox.Show("Customer Cannot be Added.\nPlease check your values and try again");
                    }
                    Program.mainForm.addCustomerToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    errorLabel.Text = "Phone Number cannot be empty";
                }
            }
            else
            {
                errorLabel.Text = "Name cannot be empty";
            }
        }

        private void eventAddButton_Click(object sender, EventArgs e)
        {
            string eventName = textBox1.Text;
            string venue = textBox2.Text;
            int maxAttent;
            DateTime date = datePicker.Value;
            DateTime time = timePicker.Value;

            if(eventName != "" && venue != "")
            {
                if(int.TryParse(textBox3.Text, out maxAttent))
                {
                    if(maxAttent > 4)
                    {
                        errorLabel.Text = "";
                        if (Program.addEvent(eventName, venue, date, time, maxAttent))
                        {
                            MessageBox.Show("Event Added Successfully...");
                        }
                        else
                        {
                            MessageBox.Show("Sorry, Event Addition Failed..\nTry Changing the Date...");
                        }
                        Program.mainForm.addEventToolStripMenuItem_Click(sender, e);
                    }
                    else
                    {
                        errorLabel.Text = "Minimum number of Attentees is 5";
                    }
                }
                else 
                { 
                    errorLabel.Text = "Please type an integer for Maximum Attentees";
                }
            }
            else
            {
                errorLabel.Text = "Event Name or Venue cannot be empty";
            }
        }
    }
}
