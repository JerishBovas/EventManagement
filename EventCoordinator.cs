using System;
using System.Collections.Generic;
using System.Text;

namespace CSAssignmentTwo
{
    class EventCoordinator
    {
        CustomerManager custMan;
        EventManager eventMan;
        RSVPManager rsvpMan;

        public EventCoordinator(int custIdSeed, int maxCust, int eventIdSeed, int maxEvents, int rsvpIdSeed, int maxRsvp)
        {
            custMan = new CustomerManager(custIdSeed, maxCust);
            eventMan = new EventManager(eventIdSeed, maxEvents);
            rsvpMan = new RSVPManager(rsvpIdSeed, maxRsvp);
        }

        //customer related methods
        public bool addCustomer(string fname, string lname, string phone)
        {
            return custMan.addCustomer(fname, lname, phone);
        }

        public string[][] customerList()
        {
            return custMan.getCustomerList();
        }

        public string getCustomerInfoById(int id)
        {
            return custMan.getCustomerInfo(id);
        }
        public bool deleteCustomer(int id)
        {
            return custMan.deleteCustomer(id);
        }

        // Event related methods
        public bool addEvent(string name, string venue, DateTime eventDate, DateTime eventTime, int maxAttendee)
        {
            return eventMan.addEvent(name, venue, eventDate, eventTime,  maxAttendee);
        }

        public string[][] eventList()
        {
            return eventMan.getEventList();
        }

        public string getEventInfoById(int id)
        {
            return eventMan.getEventInfo(id);
        }

        public bool addRsvp(int custId, int eventId)
        {
            Customer custm = custMan.getCustomer(custId);
            Event even = eventMan.getEvent(eventId);
            if (custm != null && even != null)
            {
                if (even.getNumAttendees() >= even.getMaxAttendees()) { return false; }
                if (rsvpMan.addRsvp(custm, even))
                {
                    if (even.addAttendee(custm))
                    {
                        custm.incrementBookings();
                        return true;
                    }
                }
            }
            return false;
        }

        public string[][] viewRsvp()
        {
            return rsvpMan.getRsvpList();
        }
    }
}
