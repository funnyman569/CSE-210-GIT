using System.Text.Encodings.Web;

class Program
{
    Wordz wordz = new();
    Scripture scripture = new();
    Reference reference = new();

    
    //need to figure out if i need to update the setlist
    static void Main()
    {
        System.Console.WriteLine("Welcome to the scriputre memorization program.");
        Program program = new();
        string reference = program.BookNameChapterandVerse();

        List<string> scriptureList = program.WholeScripture();
       int wordCount = scriptureList.Count();
       
       int exitKey = 0;
       double exitKeyCount = wordCount - 2;
       string userExit = "";

       //continues to remove words 3ish at a time until the user types done or all of the words are underscored
       while (exitKey < exitKeyCount && userExit != "done")
       {
        Console.Clear();
        
        //Prints Book Name Chapter and Verse
        System.Console.WriteLine(reference);
    
        //Prints scritpure
        foreach (string word in scriptureList)
            {
                Console.Write(word + " ");
            }
        
        //Removes word and updates the scripturelist with underscored wrods
        program.RemoveWords(scriptureList);
         
         //Pause for enter, increase counter by 1
         System.Console.WriteLine("\nPlease Press Enter to Continue or type 'done' ");
         userExit = Console.ReadLine();
         exitKey += 1;

       }





    }

    //Compiles the Book Name Chapter and Verse Together
     public String BookNameChapterandVerse()
    {
        System.Console.WriteLine("What is the name of the Scripture Book? ");
        string bookName = Console.ReadLine();
        reference.SetBookName(bookName);

        System.Console.WriteLine("What is the chapter of the book of Scripture? ");
        int chapter = int.Parse(Console.ReadLine());
        reference.SetChapter(chapter);
        
        System.Console.WriteLine("What is the verse number?");
        int verse = int.Parse(Console.ReadLine());
        reference.SetVerse(verse);

        return reference.CompileReference();
    }

    public List<string> WholeScripture()
    {
        List<string> listofWords = scripture.GetScripture(scripture.GetList());
        return listofWords;
    }
    
    //local function to update the list with words. Not really neccessary but its here
    List<string> RemoveWords(List<string> listofWords)
    {
        return scripture.UpdateListWithUnderscoredWord(listofWords);

    }
    

   
}