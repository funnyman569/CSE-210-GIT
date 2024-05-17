using System.Formats.Asn1;
using System.Runtime.ConstrainedExecution;
using Microsoft.Win32.SafeHandles;
using System.IO;

class Program
{
     static UserEntry userEntry = new();
    static void Main(String[] args)
    {
        System.Console.WriteLine("Welcome to the Journal Progam");
        System.Console.WriteLine("Please select one of the corresponding number from the list below");
        System.Console.WriteLine("1. Write\n2. Display\n3. Load New Jounral from a File\n4. Save your current Jounral to a new file on your computer\n5. Quit");
        string choice = Console.ReadLine();
        bool exitKey = true;
        int counter = 0;
        while(exitKey)
        {
            if(counter > 0)
            {
                System.Console.WriteLine("What would you like to do next?");
                System.Console.WriteLine("1. Write\n2. Display\n3. Load New Jounral from a File\n4. Save your current Jounral to a new file on your computer\n5. Quit");
                choice = Console.ReadLine();
            }

            counter += 1;

            if (choice == "1")
            {
                System.Console.WriteLine("Would you like a prompt to help you write your entry? ");
                string answer = Console.ReadLine().ToLower();
                
                while (answer == "yes")
                {
                    RandomPrompt randomPrompt = new();
                    randomPrompt.GetRandomPrompt();
                    System.Console.WriteLine("Would you like a different prompt? ");
                    answer = Console.ReadLine().ToLower();
                }
                
                AddEntry();
            }

            else if (choice == "2")
            {
                DisplayEntryOptions();
            }
            
            else if (choice == "3")
            {
                LoadNewJournal();
            }

            else if (choice == "4")
            {
                SaveJournal();
            }

            else if (choice == "5")
            {
                Console.WriteLine("Are you sure you would like to exit the program? ");
                string answer = Console.ReadLine().ToLower();
                if(answer == "yes")
                {
                    exitKey = false;
                }
            }

            else
            {
                System.Console.WriteLine("Im sorry, that was not a valid entry.");
            }

        }
    }

    static void AddEntry()
    {
        string entry = userEntry.get_user_input();
        userEntry.add_to_dictionary(entry);
        System.Console.WriteLine("Awesome! Here is the entry");
        foreach (var key_and_entry in userEntry.dict)
        {
            System.Console.WriteLine($"Date:{key_and_entry.Key} \nJournal Entry:{key_and_entry.Value}\n\n");              
        }
            
    }

    //load will inlcude load all entries with date or search entry by date
    static void DisplayEntryOptions()
    {
        System.Console.WriteLine("Would you like to retrieve all entries or just one entry?");
        System.Console.WriteLine("Please enter 'all' or 'one' ");
        string answer = Console.ReadLine().ToLower();
        if( answer == "all")
        {
            userEntry.get_all_entries();
        }
        else if ( answer == "one")
        {
            System.Console.WriteLine("You can find the entry by the date you wrote it. What date would you like to search? (YYYY-MM-DD) ");
            string date = Console.ReadLine();
            userEntry.get_entry_by_date(date);
        }

    }
    
    //will load a new journal from a sepcific file as speicifed by user
    static void LoadNewJournal()
    {
        System.Console.WriteLine("What is the name of the text-file you want to load ('filename.txt) ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string key = parts[0];
            string value = parts[1];
            userEntry.dict.Add(key, value);
        }
        System.Console.WriteLine("Would you like to print out the journal?");
        string answer = Console.ReadLine().ToLower();
        if (answer == "yes")
        {
            userEntry.get_all_entries();
        }
    }

    //will print whatever load() outputs
    static void PrintEntry()
    {
        userEntry.get_all_entries();
    }

    //must save whole journal to a file as specified by the user
    static void SaveJournal()
    {
        System.Console.WriteLine("What would you like to name your file? ('filename.txt') ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (KeyValuePair<string, string> key in userEntry.dict)
            {
                string keyString = key.ToString();
                outputFile.WriteLine(keyString);
            }
        }
    }
}
    