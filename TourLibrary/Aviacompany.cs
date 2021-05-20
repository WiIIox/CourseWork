using System;
using System.Collections.Generic;
using System.Text;

namespace TourLibrary
{
    public class Aviacompany
    {
        public string Name { get; private set; }
        public string[] Destination { get; private set; }
        public int[] FlightDays { get; private set; }
        public Aviacompany(string Name, string[] Destination, int[] FlightDays)
        {
            this.Name = Name;
            this.Destination = Destination;
            this.FlightDays = FlightDays;
        }
    }
}
