using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fortune Teller Program

            // Ask the user for the user’s first name
            //case sensitve?
            string firstName;
            Console.WriteLine("**Welcome to GMO's Fortune Teller**");
            Console.WriteLine("\n\nPlease your first name?");
            firstName = Console.ReadLine();
            
            // Ask the user for the user’s last name
            //case sensitive?
            string lastName;
            Console.WriteLine("\nPlease enter yout last name");
            lastName = Console.ReadLine();

            // Ask the user for the user’s age
            //done
            int age;
            Console.WriteLine("\nPlease enter you age");
            age = int.Parse (Console.ReadLine());

            // Ask the user for the user’s birth month(as an 'int')
            //done
            int birthMonth;
            Console.WriteLine("\nPlease enter you birth month [i.e. 08]");
            birthMonth = int.Parse(Console.ReadLine());

            // Ask the user for the user’s favorite ROYGBIV color
            // If the user does not know what ROYGBIV is, ask them to enter “Help” to get a list of the ROYGBIV colors
            string favColor="purple";
            String help;
            Console.WriteLine("\nUsing ROYGBIV please enter your favorite color [i.e. blue] *Enter \"help\" if you need a list to choose from*");
            favColor = Console.ReadLine().ToLower();
            
            if (favColor == "red")
            {
                Console.WriteLine("\nRed is a great choice!");
            }
            else if (favColor == "orange")
            {
                Console.WriteLine("\nOrange is a great choice!");
            }
            else if (favColor == "yellow")
            {
                Console.WriteLine("\nYellow is a great choice!");
            }
            else if (favColor == "green")
            {
                Console.WriteLine("\nGreen is a great choice!");
            }
            else if (favColor == "blue")
            {
                Console.WriteLine("\nBlue is a great choice!");
            }
            else if (favColor == "indigo")
            {
                Console.WriteLine("\nIndigo is a great choice!");
            }
            else if (favColor == "violet")
            {
                Console.WriteLine("\nViolet is a great choice!");
            }
            else if (favColor == "help")
            {
                Console.WriteLine("Your choices are red, orange, yellow, green, blue, indigo, or violet");
                Console.WriteLine("\nUsing ROYGBIV please enter your favorite color [i.e. red]");
                favColor = Console.ReadLine().ToLower();
                Console.WriteLine("\n"+favColor+" is a great choice!");
            }
            else 
            {
                Console.WriteLine("invaild entry please try again");
                Console.WriteLine("\nWhat is your favorite color? [i.e. blue]");
                favColor = Console.ReadLine().ToLower();
                Console.WriteLine("\n"+favColor + " is a great choice!");
            }
            // Ask the user number of siblings the user has
            Console.WriteLine("\nHow many Siblings do you have? If none enter 0");
            int siblingsNum = int.Parse(Console.ReadLine());


            //Determining Their Fortune

            // If the user’s age is an odd number, then they will retire in 20 years 
            //or 10 years if their age is an even number.
            string retireAge;
            if (age % 2==0)
            {
                retireAge = " 10 Years";
            }
            else
            {
                retireAge = "20 years";
            }

            // If the user’s number of siblings is 0, then they will have a vacation home in ____(location)
            //or 1 then they will have a vacation home in ____(location)
            //or 2 then they will have a vacation home in ____(location)
            //or 3 then they will have a vacation home in ____(location)
            //or more than 3 then they will have a vacation home in ____(location)
            //If the user enters anything other than a number greater than or equal to 0, they should get a bad vacation home!
            string vacationHome;
            if (siblingsNum == 0)
            {
                vacationHome = "Maui, Holllllla!";
            }
            else if (siblingsNum == 1)
            {
                vacationHome = "Miami, careful of hurricane season!";
            }
            else if (siblingsNum == 2)
            {
                vacationHome = "Las Vegas, what happens there stays there.";
            }
            else if (siblingsNum >= 3)
            {
                vacationHome = "grandmas house, maybe she will bake cookies!";
            }
            else
            {
                vacationHome = "the core of the sun, dont forget your tanning lotion!";
            }

            //Depending on which ROYGBIV color is the user’s favorite, they will have a specific mode of transportation
            //(i.e.car, boat, plane, etc.)
            string ROYGBIV;
            if (favColor == "red")
            {
                ROYGBIV = "a sports car!";
            }
            else if (favColor == "orange")
            {
                ROYGBIV = "a astrovan!";
            }
            else if (favColor == "yellow")
            {
                ROYGBIV = "a jeep!";
            }

            else if (favColor == "green")
            {
                ROYGBIV = "a private yacht!";
            }
            else if (favColor == "blue")
            {
                ROYGBIV = "a private jumbo jet";
            }
            else if (favColor == "indigo")
            {
                ROYGBIV = "a private jet!";
            }
            else if (favColor == "violet")
            {
                ROYGBIV = "a horse carrage!";
            }
            else
            {
                ROYGBIV = "your bare feet! Keeping it simple and classic!";
            }


            // If the user’s birth month is 1 - 4, they will have $____ in the bank; 
            //if the user's birth month is 5-8, they will have $____ in the bank; 
            //and if it is 9-12, then they will have $____ in the bank. 
            //If the user enters something other than 1-12 as their birth month, they will have $0.00 in the bank.
            string bankRoll;             

            if (birthMonth <=4)
            {
                bankRoll = "$100,000.00";
            }
           else if (birthMonth >= 5 && birthMonth <= 8)
            {
                bankRoll = "$400,000.00";
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                bankRoll = "$21,000,000,000.00";
            }
            else 
            {
                bankRoll = "$0.00";
            }

            //Printing out the Results
            
            Console.WriteLine("\n"+firstName +" "+ lastName);
            Console.WriteLine("You will retire in " + retireAge+".");
            Console.WriteLine("With "+bankRoll+" in the bank.");
            Console.WriteLine("With a vaction home in " + vacationHome);
            Console.WriteLine("Traveling around in " + ROYGBIV);
            Console.WriteLine("\n**Your credit card will now be charged $19.95**");
            Console.WriteLine("*NO REFUNDS!!*");
            Console.WriteLine("*Thank You For Using Our Service :) Perhaps Order Another Reading For A Loved One?*");




            //**Added notes**
            // Program should be able to handle whether or not a user inputs capital or lowercase letters.

            //Stretch Tasks:

            //Give the user the ability to quit the program at any point where the program is looking for user input, 
            //by typing “Quit” (should not be case sensitive). 
            //The program should print “Nobody likes a quitter...” before ending.

            //The way I think I could do this is wrap the entire program in a loop (which I havent learned yet). The loop would
            //function like while the user enters any other value accept "Quit"/"quit"/"Q"/"q" then it would just contnue to run
            //but if on of those words get typed it breaks out and ends. I can understand the theroy, just dont know how to code it
            //... yet.
        }
    }
}
