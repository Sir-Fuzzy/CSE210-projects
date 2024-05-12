using System;

class Program
{
    static void Main(string[] args)
    {
        //calling the inital class constructors and setting up variables
        Reference reference = new Reference("2 Nephi",2,4);
        Scripture scripture = new Scripture(reference, "And thou hast beheld in thy youth his glory; wherefore, thou art blessed even as they unto whom he shall minister in the flesh; for the Spirit is the same, yesterday, today, and forever. And the way is prepared from the fall of man, and salvation is free.");
        Random random = new Random();
        string userInput = "";
        
        
        //The main while loop bulk of the program that goes until either the user types quit or all the words are hidden
        while (!scripture.IsCompletelyHidden() && !string.Equals(userInput,"quit"))
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            scripture.HideRandomWords();
            Console.ReadLine();
        }
    }
}