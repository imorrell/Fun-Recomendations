using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace FunRecommendations
{
    class FunActivities
    {
        //intialize class variables
        int userChoice;
        String activity;
        String transportation;
        int myPeeps;

        //intialize constructor that accepts one parameter
        public FunActivities(int choice)
        {
            userChoice = choice;
        }

        //create a method that determines what activity was selected based off the numeric input
        public String userActivity()
        {
            //use switch statement to determine and identify which activity was selected
            switch (userChoice)
            {
                //If user selects action
                case 1:
                {
                        activity = "action";
                   break;
                }
                
                //if user selects Chill
                case 2:
                {
                        activity = "chill vibes";
                        break;
                }

                //if user select danger
                case 3:
                {
                        activity = "danger";
                        break;
                }

                //user selects slapping food
                case 4:
                {
                        activity = "slapping food";
                        break;
                }

                default:
                    break;
            }

            return activity;
        }

        //create a String method that accepts an integer parameter for number of friends. Based off the number,
        //return a string for the method of transportaion that the user should take.
        public String howWeRide(int people)
        {

            //use if else statements to determine what vehicle of tranportation to take based off the number of people
            if (people == 0)
            {
                //take your scooter
                transportation = "laser fast scooter!";
            }
            else if (people >=1 && people <= 4)
            {
                //Lets take the Benz
                transportation = " Big Body Benz!";
            }
            else if (people >= 5 && people <= 10)
            {
                //Lets take the party bus
                transportation = "dubbed out Party bus!";
            }
            else if (people >= 1 && people <= 4)
            {
                //Lets take the private jet
                transportation = "private jet";
            }


            return transportation;
        }

        //create method that has distinctive messages for what the user is doing, who is going, and transportation
        public void displayMessage()
        {
            //if user is looking for action
            if (activity == "action")
            {
                Console.WriteLine("If you're in the mood for some " + activity + 
                    " tonight, you should go to CJ Barrymores and travel using a " + transportation);
            }

            else if (activity == "chill vibes")
            {
                Console.WriteLine("If you're in the mood for some " + activity +
                    " tonight, you should go to The Commons and travel using a " + transportation);
            }

            else if (activity == "danger")
            {
                Console.WriteLine("If you're in the mood for some " + activity +
                    " tonight, you should go to bunjee jumping and travel using a " + transportation);
            }

            else
            {
                Console.WriteLine("If you're in the mood for some " + activity +
                    " tonight, you should go to Buckets & Biscuits and travel using a " + transportation);
            }


        }

    }
}
