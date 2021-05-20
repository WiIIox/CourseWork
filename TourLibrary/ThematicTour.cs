using System;
using System.Collections.Generic;
using System.Text;

namespace TourLibrary
{
    public class ThematicTour : Tour
    {
        public delegate void ThematicTourHandler(string message);
        public event ThematicTourHandler ThematicTourIncreasePrice;
        public override void Consulting()
        {
            decimal ServiceCost = 12;
            DailyCost += ServiceCost;
            ThematicTourIncreasePrice?.Invoke($"\nThe daily cost of the tour was increased by {ServiceCost} $\nDaily cost: {DailyCost} $");
            ThematicTourIncreasePrice -= DisplayMessage;
        }
        public override void MedicalInsurance()
        {
            decimal ServiceCost = 16;
            DailyCost += ServiceCost;
            ThematicTourIncreasePrice?.Invoke($"\nThe daily cost of the tour was increased by {ServiceCost} $\nDaily cost: {DailyCost} $");
            ThematicTourIncreasePrice -= DisplayMessage;
        }
        public override void ConsultingAndInsurance()
        {
            decimal ServiceCost = 28;
            DailyCost += ServiceCost;
            ThematicTourIncreasePrice?.Invoke($"\nThe daily cost of the tour was increased by {ServiceCost} $\nDaily cost: {DailyCost} $");
            ThematicTourIncreasePrice -= DisplayMessage;
        }

    }
}
