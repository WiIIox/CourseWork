using System;
using System.Collections.Generic;
using System.Text;

namespace TourLibrary
{
    public class Agency
    {
        public string Name { get; private set; }
        public Aviacompany[] AviaPartners { get; private set; }
        public Tour[] ProvidedTours { get; private set; }
        public Agency(string Name, Aviacompany[] AviaPartners, Tour[] ProvidedTours)
        {
            this.Name = Name;
            this.AviaPartners = AviaPartners;
            this.ProvidedTours = ProvidedTours;
        }
        //looping through Aviapartners list to find which one corresponds to the date and destination to form a list of avalaible
        public Aviacompany[] AvalaibleAviaLookUp(Tour MyTour)
        {
            Aviacompany[] AvailableAviacompanies = new Aviacompany[0];
            for (int i = 0; i < AviaPartners.Length; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    if (AviaPartners[i].FlightDays[j] == MyTour.TourDate.Day)
                    {
                        for (int k = 0; k < AviaPartners[i].Destination.Length; k++)
                        {
                            if (AviaPartners[i].Destination[k] == MyTour.Destination)
                            {

                                Array.Resize(ref AvailableAviacompanies, AvailableAviacompanies.Length + 1);
                                AvailableAviacompanies[AvailableAviacompanies.Length - 1] = AviaPartners[i];

                            }
                        }

                    }

                }

            }
            return AvailableAviacompanies;
        }

    }
}
