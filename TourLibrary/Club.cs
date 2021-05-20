using System;
using System.Collections.Generic;
using System.Text;

namespace TourLibrary
{
    public class Club
    {
        public string Name { get; private set; }
        public List<User> Userlist { get; set; }
        public List<SpecificCountry> SpecificCountryTours { get; set; }
        public List<ThematicTour> ThematicTours { get; set; }
        public List<RegularCityTour> RegularCityTours { get; set; }
        public List<Agency> TourAgencies { get; set; }

        public Club(string Name)
        {
            this.Name = Name;
            Userlist = new List<User>();
            SpecificCountryTours = new List<SpecificCountry>();
            ThematicTours = new List<ThematicTour>();
            RegularCityTours = new List<RegularCityTour>();
            TourAgencies = new List<Agency>();
        }
        //looping through Agancies list array to find wich one corresponds to our destination to add to an avalaible array
        public Agency[] AvalaibleAgenciesLookUp(PersonalTour MyTour)
        {
            Agency[] AvailableAgencies = new Agency[0];
            for (int m = 0; m < TourAgencies.Count; m++)
            {
                for (int j = 0; j < TourAgencies[m].ProvidedTours.Length; j++)
                {
                    if (TourAgencies[m].ProvidedTours[j].Destination == MyTour.Destination)
                    {
                        Array.Resize(ref AvailableAgencies, AvailableAgencies.Length + 1);
                        AvailableAgencies[AvailableAgencies.Length - 1] = TourAgencies[m];
                        break;
                    }
                }
            }
            return AvailableAgencies;
        }
    }
}
