
 class RandomPrompt
{
    public void GetRandomPrompt()
    {
        List<string> prompts = new();

        string prompt1 = "What are you grateful for today?";
        string prompt2 = "What made you feel a strong emotion today?";
        string prompt3 = "What interactions with others did you have today?";
        string prompt4 = "How did someone help you today?";
        string prompt5 = "What did you witness someone do today that was unique?";

         prompts.Add(prompt1);
         prompts.Add(prompt2);
         prompts.Add(prompt3);
         prompts.Add(prompt4);
         prompts.Add(prompt5);


        Random random = new Random();
        int index = random.Next(prompts.Count);
        System.Console.WriteLine(prompts[index]);
    }

    //public static void Main(string[] args)
    //{
    //    RandomPrompt promptInstance = new();
    //    string prompt = promptInstance.GetRandomPrompt();
    //    Console.WriteLine(prompt);

    //}
}