using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSAssignmentTwo
{
    public static class Program
    {
        //Jerish Bradly Bovas - 101239138
        //Sanjay Kannan - 101232944

        public static MainForm mainForm;
        static EventCoordinator eCoord;

        public static bool addCustomer(string fName, string lName, string phNum)
        {
            return eCoord.addCustomer(fName, lName, phNum);
        }
        public static string[][] getCustomerString()
        {
            return eCoord.customerList();
        }
        public static string getCustomerDetails(int id)
        {
            return eCoord.getCustomerInfoById(id);
        }
        public static bool deleteCustomer(int id)
        {
            return eCoord.deleteCustomer(id);
        }
        public static bool addEvent(string name, string venue, DateTime eventDate, DateTime eventTime, int maxAttendee)
        {
            return eCoord.addEvent(name, venue, eventDate, eventTime, maxAttendee);
        }
        public static string[][] getEventString()
        {
            return eCoord.eventList();
        }
        public static string getEventDetails(int id)
        {
            return eCoord.getEventInfoById(id);
        }
        public static bool addRsvp(int custId, int eventId)
        {
            return eCoord.addRsvp(custId, eventId);
        }
        public static string[][] getRsvpString()
        {
            return eCoord.viewRsvp();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainForm();
            eCoord = new EventCoordinator(201, 1000, 101, 5000, 501, 5000);
            Application.Run(mainForm);
        }
    }
}
