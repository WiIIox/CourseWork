using System;
using System.Collections.Generic;
using System.Text;


namespace TourLibrary
{
    public class User
    {
        public delegate void UserHandler(object sender, string message);
        public event UserHandler Notify;
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public List<PersonalTour> AllUserTours { get; set; }
        public User()
        {
            Name = null;
            Balance = 0;
            AllUserTours = new List<PersonalTour>();
        }
        public User(decimal sum, string name)
        {
            Name = name;
            Balance = sum;
            AllUserTours = new List<PersonalTour>();
        }
        public void PrintBalance()
        {
            Notify?.Invoke(this, $"\nHi, {Name}!\nYour account balance is {Balance} $\n");
        }
        public void TopUp()
        {
            bool WillTopUp = true;
            while (WillTopUp)
            {
                try
                {
                    Console.Write("Enter an amount to top up: ");
                    int sum = Input.NonNegative();
                    Balance += sum;
                    Notify?.Invoke(this, $"\n{sum} $ were successfully deposited to your account!\nYour current account balance is {Balance} $");
                    Console.ReadKey();
                    WillTopUp = false;
                }
                catch (LessThenZeroException)
                {
                    Output.Print("The amount can't be less then zero!");
                }
                catch (OverflowException)
                {
                    Output.Print("The amount is ratether too big or too small!");
                }
                catch (FormatException)
                {
                    Output.Print("Incorrect input!");
                }
            }
        }
        public void PayForTour(decimal price)
        {
            if (Balance >= price)
            {
                Balance -= price;
                Notify?.Invoke(this, $"-{price} $\nYour tour was paid successfully. Your balance is {Balance} $");
            }
            else
            {
                Notify?.Invoke(this, $"Not enough money. Your balance is {Balance} $");
                throw new NotEnoughMoneyException("You don't have enough money!");
            }
        }
        public static void DisplayMessage(object sender, string message)
        {
            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = temp;
        }

    }
}
