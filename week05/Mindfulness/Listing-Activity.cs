class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people you appreciate?",
        "What are your strengths?",
        "Who have you helped recently?",
        "What made you happy this week?"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "List as many positive things as you can.";
    }

    protected override void PerformActivity()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];

        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("Get ready...");
        ShowCountdown(5);

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
    }
}