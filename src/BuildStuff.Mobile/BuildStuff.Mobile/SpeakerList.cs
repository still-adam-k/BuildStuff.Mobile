using System;
using System.Collections.Generic;
using System.Text;

namespace BuildStuff.Mobile
{
    class SpeakerList
    {
        private List<Speaker> underlyingList;

        public SpeakerList()
        {
            underlyingList = new List<Speaker>();

            underlyingList.Add(new Speaker() { Name = "Greg Young" , Bio = "Author of CQRS", ImageUri = @"http://buildstuff.lt/wp-content/uploads/2014/03/greg.png"});
            underlyingList.Add(new Speaker() { Name = "Udi Dahan", Bio = "Creator of NServiceBus", ImageUri = @"http://buildstuff.lt/wp-content/uploads/2014/06/Udi-Dahan-207x222.jpg" });
            underlyingList.Add(new Speaker() { Name = "Eric Evans", Bio = "Author of Domain Driven Design", ImageUri = @"http://buildstuff.lt/wp-content/uploads/2014/04/EricEvans-222x222.jpg" });
        }

        public List<Speaker> ToList()
        {
            return underlyingList;
        }

        //public static implicit operator (SpeakerList s)
        //{
        //    return s.underlyingList;
        //}
    }
}
