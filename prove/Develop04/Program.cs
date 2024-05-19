using System;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;
        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("Please select your activity:\n1. Breathing Activity\n2. Listing Activity\n3. Reflection Activity\n0. Quit");
            string menu = Console.ReadLine();
            

            if (menu == "1")
            {
                string name = "Breathing Activity";
                string description = "Did you know that 100% of people who don't breathe die? This activity will help you remember to do so.";
                
                BreathingActivity breathing = new BreathingActivity(name, description);
                
                breathing.DisplayStartingMessage();
                breathing.ShowSpinner(5);
                
                Console.WriteLine("\nHow many seconds would you like to Breath for?");
               
                string time = Console.ReadLine();
                int seconds = int.Parse(time);
                
                breathing.Run(seconds);

                breathing.DisplayEndingMessage();

                breathing.ShowSpinner(8);

            }

            else if (menu == "2")
            {
                string name = "Listing Activity";
                string description = "Test your skills with this quick list exercise! Try to list as many things as you can.";

                ListingActivity listing = new ListingActivity(name, description);

                listing.DisplayStartingMessage();
                listing.ShowSpinner(5);

                Console.WriteLine("\nHow many seconds would you like to list for?");
               
                string time = Console.ReadLine();
                int seconds = int.Parse(time);

                listing.Run(seconds);
                listing.DisplayEndingMessage();
                listing.ShowSpinner(8);

            }



            else if (menu == "3")
            {
                string name = "Reflection Activity";
                string description = "The scriptures teach us that when we 'Remember, remeber' we are happier. Take some time to do that.";

                ReflectionActivity reflection = new ReflectionActivity(name, description);

                reflection.DisplayStartingMessage();
                reflection.ShowSpinner(5);

                reflection.Run();

                reflection.DisplayEndingMessage();
                reflection.ShowSpinner(8);

            }

            else if (menu == "0")
            {
                keepRunning = false;
            }

            else 
            {
                Console.Clear();
                Console.WriteLine("Sorry, not a valid option");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }

        // Activity activity = new Activity();
        // activity.ShowSpinner(10);

        // activity.ShowCountdownTimer(10);
    }
}