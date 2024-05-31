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
       
       int exitKey = 0;

       int wordCount = scriptureList.Count();
    //Math.Floor((wordCount / 3.0) + 1)
       double exitKeyCount = wordCount - 3;
       string userExit = "";
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
    
    //need to create variable "listofWords" to be assigneed to WholeScriputre()
    List<string> RemoveWords(List<string> listofWords)
    {
        return scripture.UpdateListWithUnderscoredWord(listofWords);

    }
    

   
}