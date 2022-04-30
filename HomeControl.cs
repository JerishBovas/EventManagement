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
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            addCustomerTool.SetToolTip(addCustomer, "Add a Customer");
            createEventTool.SetToolTip(createEvent, "Create an Event");
            mkRSVPTool.SetToolTip(mkRSVP, "Make an RSVP");
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            Program.mainForm.addCustomerToolStripMenuItem_Click(sender, e);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Program.mainForm.Close();
        }

        private void createEvent_Click(object sender, EventArgs e)
        {
            Program.mainForm.addEventToolStripMenuItem_Click(sender, e);
        }

        private void mkRSVP_Click(object sender, EventArgs e)
        {
            Program.mainForm.addRSVPToolStripMenuItem_Click(sender, e);
        }
    }
}
