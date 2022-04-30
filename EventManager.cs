using System;
using System.Collections.Generic;
using System.Text;

namespace CSAssignmentTwo
{
    class EventManager
    {
        private static int currentEventId;
        private int maxEvents;
        private int numEvents;
        private Event[] eventList;

        public EventManager(int idSeed, int max)
        {
            currentEventId = idSeed;
            maxEvents = max;
            numEvents = 0;
            eventList = new Event[maxEvents];
        }

        public bool addEvent(string name, string venue, DateTime eventDate, DateTime eventTime, int maxAttendees)
        {
            if (numEvents >= maxEvents) { return false; }
            for (int i = 0; i < numEvents; i++)
            {
                if (eventList[i].getVenue().ToLower() == venue.ToLower() && eventList[i].getDate().ToString("MM dd yyyy") == eventDate.ToString("MM dd yyyy")) { return false; }
            }
            Event e = new Event(currentEventId, name, venue, eventDate, eventTime, maxAttendees);
            eventList[numEvents] = e;
            numEvents++;
            currentEventId++;
            return true;
        }

        private int findEvent(int eid)
        {
            if(numEvents <= 0) { return -1; }
            for (int x = 0; x < numEvents; x++)
            {
                if (eventList[x].getEventId() == eid)
                    return x;
            }
            return -1;
        }

        public bool eventExists(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return false; }
            return true;
        }

        public Event getEvent(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return null; }
            return eventList[loc];
        }

        public bool deleteEvent(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return false; }
            eventList[loc] = eventList[numEvents - 1];
            numEvents--;
            return true;
        }
        public string getEventInfo(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return "There is no event with id " + eid + "."; }
            return eventList[loc].ToString();
        }
        public string[][] getEventList()
        {
            string[][] s;

            if (numEvents <= 0) { return new string[][] { new string[] { "No Events", "Added", "Yet" } }; }
            s = new string[numEvents][];
            for (int x = 0; x < numEvents; x++)
            {
                s[x] = new string[] { "" + eventList[x].getEventId(), eventList[x].getEventName(), eventList[x].getVenue()};
            }
            return s;
        }
    }
}
