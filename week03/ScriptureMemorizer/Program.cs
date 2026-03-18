using System;

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDING REQUIREMENT: I changed the scripture
        Reference reference = new Reference("Philippians", 4, 6, 7);
        Scripture scripture = new Scripture(
            reference,
            "Trust in the Lord with all thine heart and lean not unto thine own understanding"
        );

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program ending.");
                break;
            }

            scripture.HideRandomWords(3); // hides 3 words at a time
        }
    }
}
        
    
