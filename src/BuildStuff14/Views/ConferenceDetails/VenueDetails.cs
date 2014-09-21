using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BuildStuff14.Views.ConferenceDetails
{
    public class VenueDetails : View
    {

        public VenueDetails()
        {
            var venueDetails = new Label() { Text = "Venue Details:" };
            var venueName = new Label() { Text = "RADISSON BLU HOTEL LIETUVA", Font = Font.BoldSystemFontOfSize(NamedSize.Medium) };
            var venueAddress = new Label() { Text = "Konstitucijos prospektas 20, Radisson Blu Hotel Lietuva Vilnius - 08105 - Lithuania" };

             = new StackLayout() { Children = { venueDetails, venueName, venueAddress } };
            
        }


    }
}
