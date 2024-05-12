using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("2 Nephi",2,4);
        Scripture scripture = new Scripture(reference, "And thou hast beheld in thy youth his glory; wherefore, thou art blessed even as they unto whom he shall minister in the flesh; for the Spirit is the same, yesterday, today, and forever. And the way is prepared from the fall of man, and salvation is free.");
        Random random = new Random();
        string userInput = "";
        
        
        while (scripture.IsCompletelyHidden() == false || userInput == "quit")
        {
            scripture.GetDisplayText();
            userInput = Console.ReadLine();
            int randomNumber = random.Next(1,5);
            scripture.HideRandomWords(randomNumber);
            Console.Clear();
        }
    }
}