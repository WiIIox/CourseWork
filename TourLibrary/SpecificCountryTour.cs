using System;
using System.Collections.Generic;
using System.Text;

namespace TourLibrary
{
    public class SpecificCountry : Tour
    {
        public delegate void SpecificCountryHandler(string message);
        public event SpecificCountryHandler SpecificCountyIncreasePrice;
        public override void Consulting()
        {
            decimal ServiceCost = 15;
            DailyCost += ServiceCost;
            SpecificCountyIncreasePrice?.Invoke($"\nThe daily cost of the tour was increased by {ServiceCost} $\nDaily cost: {DailyCost} $");
            SpecificCountyIncreasePrice -= DisplayMessage;
        }
        public override void MedicalInsurance()
        {
            decimal ServiceCost = 25;
            DailyCost += ServiceCost;
            SpecificCountyIncreasePrice?.Invoke($"\nThe daily cost of the tour was increased by {ServiceCost} $\nDaily cost: {DailyCost} $");
            SpecificCountyIncreasePrice -= DisplayMessage;
        }
        public override void ConsultingAndInsurance()
        {
            decimal ServiceCost = 40;
            DailyCost += ServiceCost;
            SpecificCountyIncreasePrice?.Invoke($"\nThe daily cost of the tour was increased by {ServiceCost} $\nDaily cost: {DailyCost} $");
            SpecificCountyIncreasePrice -= DisplayMessage;
        }

    }

}
