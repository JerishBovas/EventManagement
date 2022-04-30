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
    public partial class MainForm : Form
    {
        UserControl uc;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            uc = new HomeControl();
            mainPanel.Controls.Add(uc);
        }

        public void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Remove(uc);
            uc = new HomeControl();
            mainPanel.Controls.Add(uc);
        }

        public void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Remove(uc);
            uc = new AddControl(1);
            mainPanel.Controls.Add(uc);
        }

        public void viewAllCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Remove(uc);
            uc = new ViewControl(1);
            mainPanel.Controls.Add(uc);
        }

        public void viewCustomerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Remove(uc);
            uc = new ViewControl(2);
            mainPanel.Controls.Add(uc);
        }

        public void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Remove(uc);
            uc = new ViewControl(3);
            mainPanel.Controls.Add(uc);
        }

        public void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Remove(uc);
            uc = new AddControl(2);
            mainPanel.Controls.Add(uc);
        }

        public void viewAllEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Remove(uc);
            uc = new ViewControl(4);
            mainPanel.Controls.Add(uc);
        }

        public void viewEventDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Remove(uc);
            uc = new ViewControl(5);
            mainPanel.Controls.Add(uc);
        }

        public void addRSVPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Remove(uc);
            uc = new AddRsvpControl();
            mainPanel.Controls.Add(uc);
        }

        public void viewRSVPsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Remove(uc);
            uc = new ViewControl(6);
            mainPanel.Controls.Add(uc);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
