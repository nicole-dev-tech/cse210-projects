// EXCEEDING REQUIREMENTS:
// I added a "Search Entries" feature to the journal program.
// This allows the user to enter a keyword and the program will display
// all journal entries that contain that word in the entry text.


using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5.Search entries");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option:");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine("\nPrompt:");
                Console.WriteLine(prompt);

                Console.Write("Your response:");
                string response = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry entry = new Entry();
                entry._date = date;
                entry._promptText = prompt;
                entry._entryText = response;

                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();

            }
            else if (choice == 3 )
            {
                Console.Write("Enter file name to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == 4)
            {
                Console.Write("Enter Filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                
            }
            else if (choice == 5)
            {
                Console.WriteLine("Enter Keyword to search: ");
                string keyword = Console.ReadLine();
                journal.SearchEntries(keyword);
            }
            else if (choice == 6)
            {
                Console.WriteLine("Goodbye!");
            }

        }
    }
       
}