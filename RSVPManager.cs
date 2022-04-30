using System;
using System.Collections.Generic;
using System.Text;

namespace CSAssignmentTwo
{
    class RSVPManager
    {
        private static int currentRsvpNumber;
        private int maxNumRsvp, numOfRsvp;
        private RSVP[] rsvpList;

        public RSVPManager(int crn, int mnr)
        {
            currentRsvpNumber = crn;
            maxNumRsvp = mnr;
            numOfRsvp = 0;
            rsvpList = new RSVP[maxNumRsvp];
        }
        public bool addRsvp(Customer cust, Event even)
        {
            if (numOfRsvp < maxNumRsvp)
            {
                rsvpList[numOfRsvp] = new RSVP(currentRsvpNumber, even, cust);
                currentRsvpNumber++;
                numOfRsvp++;
                return true;
            }
            return false;
        }
        public string[][] getRsvpList()
        {
            string[][] s;

            if (numOfRsvp <= 0) { return new string[][] { new string[] { "No", "RSVPs", "Added", "Yet" } }; }
            s = new string[numOfRsvp][];
            for (int x = 0; x < numOfRsvp; x++)
            {
                s[x] = new string[] { "" + rsvpList[x].getDate(), ""+rsvpList[x].getId(), rsvpList[x].getCustomer().getFirstName()+" "+ rsvpList[x].getCustomer().getLastName(), ""+rsvpList[x].getEvent().getEventId() };
            }
            return s;
        }
    }
}
