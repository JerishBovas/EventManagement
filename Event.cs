using System;
using System.Collections.Generic;
using System.Text;

namespace CSAssignmentTwo
{
    class Event
    {
        private int eventId;
        private string eventName;
        private string venue;
        private DateTime eventDate;
        private DateTime eventTime;
        private int maxAttendees;
        private int numAttendees;
        private string dateCreated;
        private Customer[] attendeeList;

        public Event(int eventId, string name, string venue, DateTime date, DateTime time, int maxAttendees)
        {
            this.eventId = eventId;
            eventName = name;
            this.venue = venue;
            eventDate = date;
            eventTime = time;
            this.maxAttendees = maxAttendees;
            numAttendees = 0;
            attendeeList = new Customer[maxAttendees];
            dateCreated = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
        }

        public int getEventId() { return eventId; }
        public string getEventName() { return eventName; }
        public string getVenue() { return venue; }
        public DateTime getDate() { return eventDate; }
        public DateTime getTime() { return eventTime; }
        public int getMaxAttendees() { return maxAttendees; }
        public int getNumAttendees() { return numAttendees; }

        public bool addAttendee(Customer c)
        {
            if (numAttendees >= maxAttendees) { return false; }
            attendeeList[numAttendees] = c;
            numAttendees++;
            return true;
        }

        private int findAttendee(int custId)
        {
            if(numAttendees <= 0) { return -1; }
            for (int x = 0; x < numAttendees; x++)
            {
                if (attendeeList[x].getId() == custId)
                    return x;
            }
            return -1;
        }

        public bool removeAttendee(int custId)
        {
            int loc = findAttendee(custId);
            if (loc == -1) { return false; }
            attendeeList[loc] = attendeeList[numAttendees - 1];
            numAttendees--;
            return true;
        }

        public string getAttendees()
        {
            string s = "\nCustomers registered :";
            if(numAttendees <= 0) { return "\n\tNo Customers Registered Yet"; }
            for (int x = 0; x < numAttendees; x++)
            {
                s = s + "\n" + attendeeList[x].getFirstName() + " " + attendeeList[x].getLastName();
            }
            return s;
        }

        public override string ToString()
        {
            string s = "Event: " + eventId + "\nName: " + eventName;
            s = s + "\nVenue: " + venue;
            s = s + "\nDate: " + eventDate.ToString("MM dd yyyy") + " "+eventTime.ToString("hh:mm tt");
            s = s + "\nRegistered Attendees: " + numAttendees;
            s = s + "\nAvailable spaces: " + (maxAttendees - numAttendees);
            s = s + getAttendees();
            return s;
        }
    }
}
