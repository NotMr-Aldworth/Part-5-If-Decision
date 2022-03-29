



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_If_Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection;
            Console.WriteLine("Welcome to the Jackson Cowan Project database");
            Console.WriteLine("Please enter a number coressponding to which project you would like:");
            Console.WriteLine("Enter 1 for Stages");
            Console.WriteLine("Enter 2 for Hurricane");
            Console.WriteLine("Enter 3 for Dice");
            while (Int32.TryParse(Console.ReadLine(), out selection))
                {
                    if (selection == 1)
                        Stages();
                    else if (selection == 2)
                        Hurricane();
                    else if (selection == 3)
                        Dice();
                    else
                    Console.WriteLine("Please enter a valid selection");


                }

        }



        public static void Hurricane()
        {
            int category;
            Console.WriteLine("This is the hurricane information datatbase. Please enter the category number that you would wish to look at");
            while (!Int32.TryParse(Console.ReadLine(), out category))
                Console.WriteLine("Please enter a valid entry");
                
            switch (category)
                {
                    case 1:
                        Console.WriteLine("This category has wind speeds from 74-95mp/h, 64-82kt or 119-153 km/h");
                        break;
                    case 2:
                        Console.WriteLine("This category has wind speeds from 96-110mp/h, 83-95 kt or 154-177 km/h");
                        break;
                    case 3:
                        Console.WriteLine("This category has wind speeds from 111-129 mph, 96-112 kt or 178-208 km/h");
                        break;
                    case 4:
                        Console.WriteLine("This category has wind speeds from 130-156 mph, 113-136 kt or 209-251 km/h");
                        break;
                    case 5:
                        Console.WriteLine("This category has wind speeds from 157 mph or higher, 137 kt or higher, or 252 km/h and higher");
                        break;





                }
            }
        public static void Stages()

        {

            int age;

            Console.WriteLine("Please enter an age:");
            while (!Int32.TryParse(Console.ReadLine(), out age))
                Console.WriteLine("Please enter a valid age:");

            if (age > 18)
                Console.WriteLine("Adult");

            else if (age <= 18 && age > 12)
                Console.WriteLine("Teen");

            else if (age <= 12 && age > 10)
                Console.WriteLine("Preteen");

            else if (age <= 10 && age > 5)
                Console.WriteLine("Child");

            else if (age <= 5)
                Console.WriteLine("Toddler");





        }
        public static void Dice()
        {

            Random generator = new Random();
            int dice1 = generator.Next(1, 7);
            int dice2 = generator.Next(1, 7);
            int money = 100;
            double bet;
            bool done = false;

            Console.WriteLine("Welcome to the dice game, where you can bet your money on 4 outcomes, Double, Not Double, Even Sum and Odd Sum.");
            Console.WriteLine("  Roll               Returns");
            Console.WriteLine(" Doubles               2x");
            Console.WriteLine("Not Double             1.5x");
            Console.WriteLine(" Odd Sum             Your Bet");
            Console.WriteLine(" Even Sum            Your Bet");
            Console.WriteLine($"Your account balance is: {money}$");
            Console.WriteLine("Please enter your bet:");
            do
            {
                if (!Double.TryParse(Console.ReadLine(), out bet))
                {
                    Console.WriteLine("Not a valid input");
                }
                else if (bet < 0)
                    Console.WriteLine("No negative bets....nice try");
                else if (bet > money)
                    Console.WriteLine("You dont have enough money");
                else
                    done = true;
            } while (!done);
            Console.WriteLine("Please enter a valid bet");



            Console.WriteLine("Excellent, now enter what type of bet you would like to place:");
            Console.WriteLine("Enter a 1 for a Double bet");
            Console.WriteLine("Enter a 2 for a Not Double bet");
            Console.WriteLine("Enter a 3 for a Odd Sum bet");
            Console.WriteLine("Enter a 4 for a Even Sum bet");



            int outcome = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Great, The dice have been rolled, you rolled a {dice1} and a {dice2}");
            switch (outcome)
            {
                case 1:
                    if (dice1 == dice2)
                        Console.WriteLine($"Congratulations! You have bet correctly, your new account balance is {money + (bet * 2)}");
                    else
                        Console.WriteLine($"Wahhh, wahhh. You bet incorrectly, your new account balance is {money - bet}");
                    break;
                case 2:
                    if (dice1 != dice2)
                        Console.WriteLine($"Excellent assumption! You have won your bet, your new account balance is {money + (bet * 1.5)}");
                    else
                        Console.WriteLine($"Uh oh, you have lost your bet. Your new account balance is {money - bet}. ");
                    break;
                case 3:
                    if (dice1 + dice2 == 3 || dice1 + dice2 == 5 || dice1 + dice2 == 7 || dice1 + dice2 == 9 || dice1 + dice2 == 11 || dice1 + dice2 == 1)
                        Console.WriteLine($"Good bet! Your new account balance is {money + bet}.");
                    else
                        Console.WriteLine($"Too bad. You lost your best, your new account balance is {money - bet}.");
                    break;
                case 4:
                    if (dice1 + dice2 == 2 || dice1 + dice2 == 4 || dice1 + dice2 == 6 || dice1 + dice2 == 8 || dice1 + dice2 == 10 || dice1 + dice2 == 12)
                        Console.WriteLine($"Good bet! Your new account balance is {money + bet}.");
                    else
                        Console.WriteLine($"Too bad. You lost your best, your new account balance is {money - bet}.");
                    break;


            }





        }
    }

    
}