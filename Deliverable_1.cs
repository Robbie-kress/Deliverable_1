using System;
using System.Reflection;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Deliverable_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What theme would you like for your trip, tropical, musical, or adventurous");
            string vacationType = Console.ReadLine();

            Console.WriteLine("how many friends in your group? Make sure you enter a whole number: ");
            int groupSize = Convert.ToInt32(Console.ReadLine());

            string travelmethod = "";
            string location = "";

            switch (vacationType)
            {



                case "tropical":

                    if (groupSize > 0 && groupSize < 3)
                    {

                        travelmethod = "first class";
                        location = "Beach vacation in Mexico.";
                    }
                    else if (groupSize > 2 && groupSize <= 5)
                    {

                        travelmethod = "helicopter";
                        location = "Beach vacation in Mexico.";
                    }
                    else if (groupSize >= 6)
                    {

                        travelmethod = "charter plane";
                        location = "Beach vacation in Mexico.";
                    }
                    break;

                case "musical":

                    if (groupSize > 0 && groupSize < 3)
                    {

                        travelmethod = "first class";
                        location = "New Orleans.";
                    }
                    else if (groupSize > 2 && groupSize <= 5)
                    {

                        travelmethod = "helicopter";
                        location = "New Orleans.";
                    }
                    else if (groupSize >= 6)
                    {

                        travelmethod = "charter plane";
                        location = "New Orleans.";
                    }
                    break;

                case "adventurous":

                    if (groupSize > 0 && groupSize < 3)
                    {

                        travelmethod = "first class";
                        location = "Whitewater Rafting the Grand Canyon.";
                    }
                    else if (groupSize > 2 && groupSize <= 5)
                    {

                        travelmethod = "helicopter";
                        location = "Whitewater Rafting the Grand Canyon.";
                    }
                    else if (groupSize >= 6)
                    {

                        travelmethod = "charter plane";
                        location = "Whitewater Rafting the Grand Canyon.";
                    }
                    break;
            }
            {
                Console.WriteLine("In my opinion with " + groupSize + " people heading out on a " + vacationType
                    + " trip, I'd recommend taking a " + travelmethod + " to " + location);




            }
        }

    }
}

