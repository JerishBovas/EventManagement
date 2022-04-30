using System;
using System.Collections.Generic;
using System.Text;

namespace CSAssignmentTwo
{
    class RSVP
    {
        private string date;
        private int rsvpId;
        private Event events;
        private Customer customer;

        public RSVP(int rsvpId, Event events, Customer customer)
        {
            date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
            this.rsvpId = rsvpId;
            this.events = events;
            this.customer = customer;
        }
        public string getDate() { return date; }
        public int getId() { return rsvpId; }
        public Event getEvent() { return events; }
        public Customer getCustomer() { return customer; }

        public string toString()
        {
            return $"Date: {date}\nEvent: {events.getEventName()}\nCustomer: {customer.getFirstName()} {customer.getLastName()}";
        }
    }
}
