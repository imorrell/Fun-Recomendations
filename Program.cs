//Programer: Ivoire Morrell
//Program: Fun Reccomendations
//Date: September 6, 2019
//Description: This program uses conditional statements to reccomend ideas for fun to the user

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunRecommendations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intialize variables
            int userChoice;
            bool ok = false;
            String activity;
            String transportation;
            int myPeeps;

            //diplay welcome message
            Console.WriteLine("What up fam! What you trying to get into tonight?" +
                " Here are a few options (enter number for corresponding activity)" + "\n");

            //use while loop to ensure user selects one of the available options
            while (ok == false)
            {
                Console.WriteLine("1) Action" + "\n" +
                              "2) Chill vibes" + "\n" +
                              "3) Danger" + "\n" +
                              "4) Slapping Food" + "\n"
                              );

                //read user input
                userChoice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                //Determine if the user choice is one of the above options
                if (userChoice >= 1 && userChoice <= 4)
                { 
                    //user enter one of the above options.
                    ok = true;

                    //create a fun activities object that sets the different variables
                    FunActivities active = new FunActivities(userChoice);

                    //ask the user how many people are coming
                    Console.WriteLine("How many of your peoples are you bringing?" + "\n");

                    //get user entry
                    myPeeps = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();

                    //use methods from FunActivities class to return the activity, transportation
                    activity = active.userActivity();

                    transportation = active.howWeRide(myPeeps);

                    //Display what activity the user selected along with the method of transportation
                    active.displayMessage();
                }
                else
                {
                    //wrong entry. User must select one of the correct options.
                    Console.WriteLine("Whoa I dont know about that actitvty. Please select from options below" + "\n");
                    ok = false;
                }

            }

            //Display goodbye message
            Console.WriteLine();

            Console.WriteLine("Dueces!");

            Console.ReadKey();
            
        }
    }
}
