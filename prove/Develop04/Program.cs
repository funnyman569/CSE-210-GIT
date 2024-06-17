using System;

class Program
{
    static void Main()
    { 
        bool exitKey = true;
        System.Console.WriteLine("Welcome to the mindfulness app! \nPlease Select from the following . . .");
        
        while (exitKey)
        {
            System.Console.WriteLine(   "1. Breathing Activity \n2. Reflection Activity \n3. Listing Activity");
            
            string userSelection = Console.ReadLine();
        
            if( userSelection == "1")
            {
                Breathing breathing = new();
                breathing.BreatheInAndOut();

                System.Console.WriteLine("Would you like to do another activity? (Y / N)");
                string anotherActivity = Console.ReadLine().ToUpper();
                if (anotherActivity == "Y")
                {
                    exitKey = true;
                }
                else
                    exitKey = false;
            }

            else if ( userSelection == "2")
            {
                Reflection reflection = new();
                reflection.ReflectionActivity();
               
                System.Console.WriteLine("Would you like to do another activity? (Y / N)");
                string anotherActivity = Console.ReadLine().ToUpper();
                if (anotherActivity == "Y")
                {
                    exitKey = true;
                }
                else
                    exitKey = false;
                
                
            }

            else if ( userSelection == "3")
            {
                Listing listing = new();
                listing.ListingExercise();
                
                System.Console.WriteLine("Would you like to do another activity? (Y / N)");
                string anotherActivity = Console.ReadLine().ToUpper();
                if (anotherActivity == "Y")
                {
                    exitKey = true;
                }
                else
                    exitKey = false;

            }

            else
            {
                System.Console.WriteLine("I'm sorry, that was not a valid resposnse. Try again.");
            }

        }
    System.Console.WriteLine("Thank you using the mindfulness app. Pleas let Bill Gates know Im open for hiring");
    
    }
}