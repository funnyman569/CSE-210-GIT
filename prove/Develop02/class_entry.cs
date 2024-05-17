
using System.Data.Common;
using System.Formats.Tar;
using System.Net.Mail;
using System.Runtime.Intrinsics.Arm;

class UserEntry
{
   public Dictionary<string,string> dict{get; private set; } = new();
   
     public string get_user_input()
    {
        Console.WriteLine("Please write your journal entry down below");
        string entry = Console.ReadLine();
        return entry;
    }

    public void add_to_dictionary(string entry)
    {
        string date_today = DateTime.Now.ToString("yyyy-MM-dd");
        dict.Add(date_today, entry);
    }

    

    public string get_entry_by_date(string date)
    {
        if (dict.TryGetValue(date, out string entry))
        {
            return entry;
        }
        else
        {
            return "No value found for that date";
        }
    }

    public void get_all_entries()
    {
        foreach(var key_and_entry in dict)
        {
            System.Console.WriteLine($"Date:{key_and_entry.Key} \nJournal Entry:{key_and_entry.Value}\n\n");
        }
    }

    public void itererate_the_dictionary()
    {
        
    }

    
    
}