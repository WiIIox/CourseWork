using System;
using TourLibrary;
using System.Collections.Generic;
namespace TourApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating class instances with all the inforation needed
            Club Club = new Club("Tourism Enjoyer's Club");

            //tour types
            string[] TourTypes = new string[] { "Journey to a specific country", "Thematic tour", "A regular city tour" };
            
            //counties for a specific country option
            SpecificCountry Botswana = new SpecificCountry() { TourType = TourTypes[0], Name = "Botswana", DailyCost = 89, Destination = "Botswana" };
            SpecificCountry Australia = new SpecificCountry() { TourType = TourTypes[0], Name = "Australia", DailyCost = 103, Destination = "Australia" };
            SpecificCountry India = new SpecificCountry() { TourType = TourTypes[0], Name = "India", DailyCost = 124, Destination = "India" };
            SpecificCountry USA = new SpecificCountry() { TourType = TourTypes[0], Name = "USA", DailyCost = 138, Destination = "USA" };
            SpecificCountry Italy = new SpecificCountry() { TourType = TourTypes[0], Name = "Italy", DailyCost = 141, Destination = "Italy" };

            Club.SpecificCountryTours.AddRange(new SpecificCountry[] { Botswana, Australia, India, USA, Italy });
            
            //tour types for a thematic tour option
            ThematicTour FoodTour = new ThematicTour { TourType = TourTypes[1], Name = "Food tour", DailyCost = 149, Destination = "Italy" };
            ThematicTour WildlifeTour = new ThematicTour { TourType = TourTypes[1], Name = "Wildlife Tour", DailyCost = 97, Destination = "Botswana" };
            ThematicTour UrbanAdventure = new ThematicTour { TourType = TourTypes[1], Name = "Urban Adventure", DailyCost = 135, Destination = "China" };
            ThematicTour RetreatJourney = new ThematicTour { TourType = TourTypes[1], Name = "Retreat Journey", DailyCost = 98, Destination = "India" };
            ThematicTour CyclingTour = new ThematicTour { TourType = TourTypes[1], Name = "Cycling Tour", DailyCost = 85, Destination = "Turkey" };

            Club.ThematicTours.AddRange(new ThematicTour[] { FoodTour, WildlifeTour, UrbanAdventure, RetreatJourney, CyclingTour });
            
            //cities for a regular city tour option
            RegularCityTour HongKong = new RegularCityTour() { TourType = TourTypes[2], Name = "Hong Kong", DailyCost = 143, Destination = "China" };
            RegularCityTour Zurich = new RegularCityTour() { TourType = TourTypes[2], Name = "Zurich", DailyCost = 208, Destination = "Switzerland" };
            RegularCityTour Istanbul = new RegularCityTour() { TourType = TourTypes[2], Name = "Istanbul", DailyCost = 129, Destination = "Turkey" };
            RegularCityTour Venice = new RegularCityTour() { TourType = TourTypes[2], Name = "Venice", DailyCost = 138, Destination = "Italy" };
            RegularCityTour London = new RegularCityTour() { TourType = TourTypes[2], Name = "London", DailyCost = 150, Destination = "United Kingdom" };

            Club.RegularCityTours.AddRange(new RegularCityTour[] { HongKong, Zurich, Istanbul, Venice, London });

            //creating an array of even and odd days
            int[] EvenDays = new int[0];
            int[] OddDays = new int[0];
            for (int i = 0; i <= 31; i++)
            {
                if (i % 2 == 0)
                {
                    Array.Resize(ref EvenDays, EvenDays.Length + 1);
                    EvenDays[EvenDays.Length - 1] = i;
                }
                else if (i % 2 != 0 )
                {
                    Array.Resize(ref OddDays, OddDays.Length + 1);
                    OddDays[OddDays.Length - 1] = i;
                }
            }
            //aviacompanies - names, destinations and flight days
            Aviacompany Aeromexico = new Aviacompany("Aeromexico", new string[] { "Botswana", "Australia", "China", "United Kingdom" }, EvenDays);
            Aviacompany QatarAirways = new Aviacompany("QatarAirways", new string[] { "Botswana", "Italy", "China", "United Kingdom" }, OddDays);
            Aviacompany Qantas = new Aviacompany("Qantas", new string[] { "Italy", "USA", "Switzerland", "United Kingdom" }, EvenDays);
            Aviacompany SASScandinavianAirlines = new Aviacompany("SAS Scandinavian Airlines", new string[] { "India", "Switzerland", "United Kingdom" }, OddDays);
            Aviacompany Luxair = new Aviacompany("Luxair", new string[] { "USA", "Australia", " United Kingdom" }, EvenDays);
            Aviacompany AustrianAirlines = new Aviacompany("AustrianAirlines", new string[] { "Botswana", "USA", "United Kingdom" }, OddDays);
            Aviacompany WestJet = new Aviacompany("WestJet", new string[] { "Italy", "Australia", "Turkey", "USA" }, OddDays);
            Aviacompany Emirates = new Aviacompany("Emirates", new string[] { "India", "Italy", "United Kingdom", "Turkey" }, EvenDays);

            Aviacompany[] Aviacomanies = new Aviacompany[] { Aeromexico, QatarAirways, Qantas, SASScandinavianAirlines, Luxair, AustrianAirlines, WestJet, Emirates };
            //agencies - names, aviapartners and provided tours
            Agency Expedia = new Agency("Expedia", new Aviacompany[] { Aeromexico, QatarAirways, Luxair, AustrianAirlines, WestJet, Emirates }, new Tour[] { Botswana, Australia, HongKong, Venice, WildlifeTour, UrbanAdventure });
            Agency AmericanExpress = new Agency("American Express", new Aviacompany[] { SASScandinavianAirlines, WestJet, Emirates, QatarAirways, Aeromexico, Qantas, Luxair }, new Tour[] { India, Italy, HongKong, Zurich, London, FoodTour, UrbanAdventure, RetreatJourney });
            Agency BCDTravel = new Agency("BCD Travel", new Aviacompany[] { Qantas, Luxair, WestJet, SASScandinavianAirlines, Emirates, QatarAirways }, new Tour[] { USA, Zurich, Istanbul, Venice, London, CyclingTour });
            Agency Internova = new Agency("Internova", new Aviacompany[] { Aeromexico, QatarAirways, Luxair, AustrianAirlines, WestJet, Emirates }, new Tour[] { Botswana, Australia, HongKong, Venice, WildlifeTour, UrbanAdventure });
            Agency Fareportal = new Agency("Fareportal", new Aviacompany[] { SASScandinavianAirlines, WestJet, Emirates, QatarAirways, Aeromexico, Qantas, Luxair }, new Tour[] { India, Italy, HongKong, Zurich, London, FoodTour, UrbanAdventure, RetreatJourney });
            Agency EasyTravel = new Agency("Easy Travel", new Aviacompany[] { Qantas, Luxair, WestJet, SASScandinavianAirlines, Emirates, QatarAirways }, new Tour[] { USA, Zurich, Istanbul, Venice, London, CyclingTour });

            Club.TourAgencies.AddRange(new Agency[] { Expedia, AmericanExpress, BCDTravel, Internova, Fareportal, EasyTravel });
            
            //existing users, only one for now, which I used for tests
            User[] Userlist = new User[] { new User(999999, "Admin") };
            Club.Userlist.AddRange(Userlist);
            
            //login screen
            Console.ForegroundColor = ConsoleColor.Green;
            Output.Title("Tourism Enjoyer's Club");
            string Username = null;
            Console.WriteLine("Hello and welcome to our Tourism club!\nPlease input your username below, if you don't have one just type a \"-\" symbol and you will be suggested to Sign Up.\n");
            Console.Write("Enter your username: ");

            //username input validation
            while (string.IsNullOrWhiteSpace(Username = Console.ReadLine()))
            {
                Output.Print("Username can't be blank!");
                Console.Write("\nEnter your username: ");
            }
            //if user exists - login
            User User = new User();
            for (int i = 0; i < Club.Userlist.Count; i++)
            {
                if (Username == Club.Userlist[i].Name)
                {
                    User = Club.Userlist[i];
                }
            }
            if (User.Name != null)
            {
                User.Notify += User.DisplayMessage; //adding event processor
                Console.Write($"\nHi, {User.Name}!\nYour balance is {User.Balance} $\n\nPress any key to go to the main menu...");
                Console.ReadKey();
            }
            //if user doesn't exist - creating it
            else
            {
                Output.Print("User Not Found!");
                string NewUsername = null;
                bool AllGood = false;
                while (!AllGood)
                {
                    Console.Write("Please enter a username to Sign Up: ");
                    while (string.IsNullOrWhiteSpace(NewUsername = Console.ReadLine()))
                    {
                        Output.Print("Username can't be blank!");
                        Console.Write("Please enter a username to Sign Up: ");
                    }
                    AllGood = true;
                    for (int i = 0; i < Club.Userlist.Count; i++)
                    {
                        if (NewUsername == Club.Userlist[i].Name)
                        {
                            AllGood = false;
                            Output.Print("This username is already taken!");
                        }
                    }
                }
                User = new User(0, NewUsername);
                Club.Userlist.Add(User);
                User.Notify += User.DisplayMessage;
                Output.Print("Signed up successfully!");
                //account top up and validation
                Console.WriteLine("\n\n\nAs a new user, you have 0$ on your balance, if you want to top up your account, then press 1 on your keyboard.\nOr just press any other key to go to the main menu...");
                Console.Write("\nYour input: ");
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
            //Main menu screen
            bool MenuAlive = true;
            while (MenuAlive)
            {
                Console.Clear();
                Output.Title("Tourism Enjoyer's Club");
                Console.WriteLine("Choose one of the options below:\n");
                Console.WriteLine($"1. {TourTypes[0]}\n2. {TourTypes[1]}\n3. {TourTypes[2]}\n4. My tourlist\n5. My balance\n0. Exit");
                int MenuOption = -1;
                while (MenuOption != 1 && MenuOption != 2 && MenuOption != 3 && MenuOption != 4 && MenuOption != 5 && MenuOption != 0)
                {
                    try
                    {
                        Console.Write("\nEnter a digit: ");
                        MenuOption = int.Parse(Console.ReadLine());
                        if (MenuOption != 1 && MenuOption != 2 && MenuOption != 3 && MenuOption != 4 && MenuOption != 5 && MenuOption != 0)
                        {
                            Output.Print("Only digits from the list are allowed!");
                        }
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
                //Creating a new tour
                PersonalTour MyTour = new PersonalTour();
                if (MenuOption == 1 || MenuOption == 2 || MenuOption == 3)
                {
                    MyTour.TourType = TourTypes[MenuOption - 1]; //Tour type, depends on option above
                    Console.Write("\nPlease name your tour(optional): ");
                    MyTour.Name = Console.ReadLine(); //Tour name(if written)
                }
                switch (MenuOption)
                {
                    case 1:
                        {
                            Console.Clear();
                            Output.Title("Tourism Enjoyer's Club");
                            for (int k = 0; k < Club.SpecificCountryTours.Count; k++)
                            {
                                Console.WriteLine($"{k + 1}. Country: {Club.SpecificCountryTours[k].Name}, Daily cost: {Club.SpecificCountryTours[k].DailyCost} $");
                            }
                            Console.WriteLine();
                            int index = 0;
                            bool FirstOption = true;
                            while (FirstOption)
                            {
                                try
                                {
                                    Console.Write("Enter a tour number you would like to choose: ");
                                    index = Input.InBound(Club.SpecificCountryTours.Count);
                                    FirstOption = false;
                                }
                                catch (OutOfBoundaries)
                                {
                                    Output.Print("Out of boundaries!");
                                }
                                catch (OverflowException)
                                {
                                    Output.Print("The amount in rather too small or too big!");
                                }
                                catch (FormatException)
                                {
                                    Output.Print("Incorrect input!");
                                }
                            }
                            Club.SpecificCountryTours[index - 1].SpecificCountyIncreasePrice += Tour.DisplayMessage;
                            TourPlanner.Planner(Club.SpecificCountryTours.ToArray(), MyTour, User, index, Club);
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            for (int j = 0; j < Club.ThematicTours.Count; j++)
                            {
                                Console.WriteLine($"{j + 1}. Tour: {Club.ThematicTours[j].Name}, Daily cost: {Club.ThematicTours[j].DailyCost} $");
                            }
                            Console.WriteLine();
                            int index = 0;
                            bool SecondOption = true;
                            while (SecondOption)
                            {
                                try
                                {
                                    Console.Write("Enter a tour number you would like to choose: ");
                                    index = Input.InBound(Club.ThematicTours.Count);
                                    SecondOption = false;
                                }
                                catch (OutOfBoundaries)
                                {
                                    Output.Print("Out of boundaries!");
                                }
                                catch (OverflowException)
                                {
                                    Output.Print("The amount in rather too small or too big!");
                                }
                                catch (FormatException)
                                {
                                    Output.Print("Incorrect input!");
                                }
                            }
                            Club.ThematicTours[index - 1].ThematicTourIncreasePrice += Tour.DisplayMessage;
                            TourPlanner.Planner(Club.ThematicTours.ToArray(), MyTour, User, index, Club);
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            for (int j = 0; j < Club.RegularCityTours.Count; j++)
                            {
                                Console.WriteLine($"{j + 1}. Tour: {Club.RegularCityTours[j].Name}, Daily cost: {Club.RegularCityTours[j].DailyCost} $");
                            }
                            Console.WriteLine();
                            int index = 0;
                            bool ThirdOption = true;
                            while (ThirdOption)
                            {
                                try
                                {
                                    Console.Write("Enter a tour number you would like to choose: ");
                                    index = Input.InBound(Club.RegularCityTours.Count);
                                    ThirdOption = false;
                                }
                                catch (OutOfBoundaries)
                                {
                                    Output.Print("Out of boundaries!");
                                }
                                catch (OverflowException)
                                {
                                    Output.Print("The amount in rather too small or too big!");
                                }
                                catch (FormatException)
                                {
                                    Output.Print("Incorrect input!");
                                }
                            }
                            Club.RegularCityTours[index - 1].RegularCityTourIncreasePrice += Tour.DisplayMessage;
                            TourPlanner.Planner(Club.RegularCityTours.ToArray(), MyTour, User, index, Club);
                            break;
                        }
                    case 0:
                        {
                            MenuAlive = false;
                            Output.Print("Hope to see you soon!");
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Output.Title("Tourism Enjoyer's Club");
                            User.PrintBalance();
                            Console.WriteLine("\nPress 1 to top up your account\nPress any other key to go back to the main menu...");
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
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("\t\t\t\t\t\t  Tourism Enjoyer's Club\n\n");
                            if (User.AllUserTours.Count == 0)
                            {
                                Console.WriteLine("It seems that your tourlist is empty :c");
                                Console.WriteLine("\n\n\nPress any key to go back to the main menu...");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine($"Here is the list of your tours: \n");
                                for (int i = 0; i < User.AllUserTours.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. Name: {User.AllUserTours[i].Name}\n   Type: {User.AllUserTours[i].TourType}\n   Price: {User.AllUserTours[i].Price} $\n   Agency: {User.AllUserTours[i].ChoosenAgency.Name}\n   Duration: {User.AllUserTours[i].TourDuration} day(s)\n   Aviacompany: {User.AllUserTours[i].ChoosenAvia.Name}\n   Date: {User.AllUserTours[i].TourDate.Day}.{User.AllUserTours[i].TourDate.Month}.{User.AllUserTours[i].TourDate.Year}\n   Status: {User.AllUserTours[i].Status}\n\n");
                                }
                                Console.WriteLine("\nPress 1 to pay for you tour\n\n\nPress any other key to continue...");
                                Console.Write("Your input: ");
                                string ChoosenOption = Console.ReadLine();
                                switch (ChoosenOption)
                                {
                                    case "1":
                                        {
                                            bool PayTourOk = false;
                                            while (!PayTourOk)
                                            {
                                                try
                                                {
                                                    Console.Write("\nEnter a digit which corresponds to the number of tour you want to pay for: ");
                                                    int NumPayTour = Input.InBound(User.AllUserTours.Count);
                                                    if (User.AllUserTours[NumPayTour - 1].Status == PayStatus.Paid)
                                                    {
                                                        Console.WriteLine("This tour is already paid!");
                                                        Console.ReadKey();
                                                        break;
                                                    }
                                                    try
                                                    {
                                                        User.PayForTour(User.AllUserTours[NumPayTour - 1].Price);
                                                        Console.ReadKey();
                                                        User.AllUserTours[NumPayTour - 1].Status = PayStatus.Paid;

                                                    }
                                                    catch (NotEnoughMoneyException)
                                                    {
                                                        Console.WriteLine("\nPress 1 to top up your account\nPress any other key to go back to the main menu...");
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
                                                    PayTourOk = true;
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
                }
            }
        }
    }
}