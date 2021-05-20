using System;
using System.Collections.Generic;
using System.Text;

namespace TourLibrary
{
    public class PersonalTour : Tour
    {
        public PayStatus Status { get; set; }
        public decimal Price { get; private set; }
        public Agency ChoosenAgency { get; set; }
        public Aviacompany ChoosenAvia { get; set; }
        public string Description { get; set; }
        
        public static void PrintTourInfo(string Name, string TourType, string Description, string Destination, DateTime Date, int Duration, string AgencyName, string AviacompanyName, decimal Price)
        {
            Output.Title("Tourism Enjoyer's Club");
            Console.WriteLine("\n=========== TOUR INFO ==============\n");
            Console.WriteLine($"Name: '{Name}'\nType: {TourType}\nDescription: {Description}\nAviadestination: {Destination}\nDate: {Date}\nDuration: {Duration} day(s)\nAgency: {AgencyName}\nAviacompany: {AviacompanyName}\nPrice: {Price} $");
            Console.WriteLine("\n====================================");
            Console.WriteLine("\n\nPress any key to continue...");
        }
        public override void ConsultingAndInsurance()
        {
            throw new NotImplementedException();
        }

        public decimal TotalPrice()
        {
            return Price = DailyCost * TourDuration;
        }

        public override void MedicalInsurance()
        {
            throw new NotImplementedException();
        }

        public override void Consulting()
        {
            throw new NotImplementedException();
        }
    }
}
