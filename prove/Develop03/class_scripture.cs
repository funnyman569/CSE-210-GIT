//
using System.Dynamic;

class Scripture
{
   private List<string> _listofWords = new ();

   public Scripture()
   {
    List<string> listofWords = _listofWords;
   }

   public List<string> GetList()
   {
    return _listofWords;
   }

   public List<string> SetList(List<string> list)
   {
    list = _listofWords;
    return _listofWords;
   }

    //Takes input and turns it into a list
   public List<string> GetScripture(List<string> _listofWords)
   {
    System.Console.WriteLine("Please type out your scriputre. ");
    string input = Console.ReadLine();
    _listofWords.AddRange(input.Split(' '));
    return _listofWords;
   }

   public List<string> UpdateListWithUnderscoredWord(List<string> _listofWords)
   {
    Wordz wordz = new();
    Random random = new();
    int numberOfWordsInList = _listofWords.Count();

    int replacedCount = 0;

    while (replacedCount < 3 && _listofWords.Count > 0) // Ensure there are words left to modify
    {
        int randomNumber = random.Next(_listofWords.Count);
        string word = _listofWords[randomNumber];
        wordz.SetWordz(word);
        int numberOfCharactersOfWord = wordz.NumberOfCharactersInWord();
        string underScore = wordz.ChangeWordToDashes(numberOfCharactersOfWord);

        // Replace the original word with underscores in the main list
        _listofWords[randomNumber] = underScore;

        replacedCount++;
    }
    
    
    return _listofWords;
   }

}

