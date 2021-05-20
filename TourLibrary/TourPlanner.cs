using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourLibrary
{
    class TourPlanner
    {
        //this method should handle all the settings in any type of tour
        public static void Planner(Tour[] TourList, PersonalTour MyTour, User User, int ChoosenOption, Club TourClub)
        {

            MyTour.Description = TourList[ChoosenOption - 1].Name;
            MyTour.Destination = TourList[ChoosenOption - 1].Destination;
            MyTour.DailyCost = TourList[ChoosenOption - 1].DailyCost;
            Console.WriteLine("\nEnter a date you want to book a tour for.\nDate format example: yyyy/mm/dd");

            //date input validation
            bool DateOK = false;
            while (!DateOK)
            {
                try
                {
                    Console.Write("\nInput desired date: ");
                    MyTour.TourDate = DateTime.Parse(Console.ReadLine());
                    DateOK = true;
                }
                catch (FormatException)
                {
                    Output.Print("Invalid format!");
                }
            }
            Console.WriteLine("\nTour TourAgencies avalaible:\n");
            Agency[] AvailableAgencies = TourClub.AvalaibleAgenciesLookUp(MyTour);

            //printing all avalaible agencies
            if (AvailableAgencies.Length > 0)
            {
                for (int i = 0; i < AvailableAgencies.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {AvailableAgencies[i].Name}");
                }
            }
            else
            {
                Console.WriteLine("There is no agancies avalaible on that date\nPress any key to go back to the main menu...");
                Console.ReadKey();
                return;
            }

            //validation of input for choosing an agency
            bool AgencyOk = false;
            while (!AgencyOk)
            {
                try
                {
                    Console.Write("Choose an Agency: ");
                    int AgencyChoise = Input.InBound(AvailableAgencies.Length);
                    MyTour.ChoosenAgency = AvailableAgencies[AgencyChoise - 1];
                    AgencyOk = true;
                }
                catch (OutOfBoundaries)
                {
                    Output.Print("Out of boundaries!");
                }
                catch (OverflowException)
                {
                    Output.Print("The amount is rather too big or too small!");
                }
                catch (FormatException)
                {
                    Output.Print("Incorrect input!");
                }
            }

            Console.WriteLine("\nAviacompanies avalaible:\n");
            Aviacompany[] AvailableAviacompanies = MyTour.ChoosenAgency.AvalaibleAviaLookUp(MyTour);

            //printing all avalaible aviacompanies
            if (AvailableAviacompanies.Length > 0)
            {
                for (int i = 0; i < AvailableAviacompanies.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {AvailableAviacompanies[i].Name}");
                }
            }
            else
            {
                Console.WriteLine("There is no aviacompanies avalaible on that date\nPress any key to go back to the main menu...");
                Console.ReadKey();
                return;
            }
            //validation of input for choosing an aviacompany
            bool CompanyOk = false;
            while (!CompanyOk)
            {
                try
                {
                    Console.Write("Choose a company: ");
                    int CompanyChoise = Input.InBound(AvailableAviacompanies.Length);
                    MyTour.ChoosenAvia = AvailableAviacompanies[CompanyChoise - 1];
                    CompanyOk = true;
                }
                catch (OutOfBoundaries)
                {
                    Output.Print("Out of boundaries!");
                }
                catch (OverflowException)
                {
                    Output.Print("The amount is rather too big or too small!");
                }
                catch (FormatException)
                {
                    Output.Print("Incorrect input!");
                }
            }

            //date input validation
            bool DaysOk = false;
            while (!DaysOk)
            {
                try
                {
                    Console.Write("\nEnter the amount of days you want to travel for: ");
                    int Days = Input.NonNegative();
                    MyTour.TourDuration = Days;
                    DaysOk = true;
                }
                catch (LessThenZeroException)
                {
                    Output.Print("The amount of days can't be less then zero!");
                }
                catch (OverflowException)
                {
                    Output.Print("The amount is rather too big or too small!");
                }
                catch (FormatException)
                {
                    Output.Print("Incorrect input!");
                }
            }

            //Additional services cost addition
            Console.WriteLine("\nAdditional Services:\n\n1. Consulting\n2. Medical Insurance\n3. Both of the above\n\n\nPress any other key if you don't need any Additional Services...");
            Console.Write("Your input: ");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        TourList[ChoosenOption - 1].Consulting();
                        MyTour.DailyCost = TourList[ChoosenOption - 1].DailyCost;
                        break;
                    }
                case "2":
                    {
                        TourList[ChoosenOption - 1].MedicalInsurance();
                        MyTour.DailyCost = TourList[ChoosenOption - 1].DailyCost;
                        break;
                    }
                case "3":
                    {
                        TourList[ChoosenOption - 1].ConsultingAndInsurance();
                        MyTour.DailyCost = TourList[ChoosenOption - 1].DailyCost;
                        break;
                    }
                default:
                    break;
            }
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            //paying and saving screen
            Output.Title("Tourism Enjoyer's Club");
            Console.WriteLine("Total price: " + MyTour.TotalPrice() + "$");
            bool PayOrSave = true;
            while (PayOrSave)
            {
                Console.WriteLine("\nPress 1 to pay for your tour\nPress 2 to save this tour and pay for it later\n\n\nPress any other key to go back to the main menu...");
                Console.Write("Your input: ");
                switch (Console.ReadLine())
                {
                    //paying for the tour, setting status to paid and adding it to the tour list
                    case "1":
                        {
                            try
                            {
                                User.PayForTour(MyTour.Price);
                                MyTour.Status = PayStatus.Paid;
                                User.AllUserTours.Add(MyTour);
                                Console.ReadKey();
                                Console.Clear();
                                PersonalTour.PrintTourInfo(MyTour.Name, MyTour.TourType, MyTour.Description, MyTour.Destination, MyTour.TourDate.Date, MyTour.TourDuration, MyTour.ChoosenAgency.Name, MyTour.ChoosenAvia.Name, MyTour.Price);
                                PayOrSave = false;
                                Console.ReadKey();

                            }
                            catch (NotEnoughMoneyException)
                            {
                                Console.WriteLine("\nPress 1 to top up your account\nPress any key to go back to the main menu...");
                                Console.Write("Your input: ");
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        {
                                            User.TopUp();
                                            break;
                                        }
                                    default:
                                        {
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    default:
                        {
                            PayOrSave = false;
                            break;
                        }
                    //setting status to unpaid and adding to the tour list
                    case "2":
                        {
                            MyTour.Status = PayStatus.Unpaid;
                            User.AllUserTours.Add(MyTour);
                            Output.Print("You tour was successfully added to your tourlist, so you might pay for it later!");
                            Console.ReadKey();
                            Console.Clear();
                            PersonalTour.PrintTourInfo(MyTour.Name, MyTour.TourType, MyTour.Description, MyTour.Destination, MyTour.TourDate.Date, MyTour.TourDuration, MyTour.ChoosenAgency.Name, MyTour.ChoosenAvia.Name, MyTour.Price);
                            PayOrSave = false;
                            Console.ReadKey();
                            break;
                        }
                }
            }

        }
    }
}