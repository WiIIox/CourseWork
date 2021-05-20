using System;
using System.Collections.Generic;
using System.Text;

namespace TourLibrary
{
    public abstract class Tour
    {
        public DateTime TourDate { get; set; }
        public string Destination { get; set; }
        public string TourType { get; set; }
        public string Name { get; set; }
        public int TourDuration { get; set; }
        public decimal DailyCost { get; set; }
        public abstract void ConsultingAndInsurance();
        public abstract void Consulting();
        public abstract void MedicalInsurance();
        public static void DisplayMessage(string message)
        {
            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = temp;
        }

    }
}
