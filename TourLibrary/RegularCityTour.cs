using System;
using System.Collections.Generic;
using System.Text;

namespace TourLibrary
{
    public class RegularCityTour : Tour
    {
        public delegate void RegulatCityTourHandler(string message);
        public event RegulatCityTourHandler RegularCityTourIncreasePrice;
        public override void Consulting()
        {
            decimal ServiceCost = 10;
            DailyCost += ServiceCost;
            RegularCityTourIncreasePrice?.Invoke($"\nThe daily cost of the tour was increased by {ServiceCost} $\nDaily cost: {DailyCost} $");
            RegularCityTourIncreasePrice -= DisplayMessage;
        }
        public override void MedicalInsurance()
        {
            decimal ServiceCost = 30;
            DailyCost += ServiceCost;
            RegularCityTourIncreasePrice?.Invoke($"\nThe daily cost of the tour was increased by {ServiceCost} $\nDaily cost: {DailyCost} $");
            RegularCityTourIncreasePrice -= DisplayMessage;
        }
        public override void ConsultingAndInsurance()
        {
            decimal ServiceCost = 40;
            DailyCost += ServiceCost;
            RegularCityTourIncreasePrice?.Invoke($"\nThe daily cost of the tour was increased by {ServiceCost} $\nDaily cost: {DailyCost} $");
            RegularCityTourIncreasePrice -= DisplayMessage;
        }

    }
}
