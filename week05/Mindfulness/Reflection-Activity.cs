class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time you helped someone.",
        "Think of a time you overcame a challenge.",
        "Think of a time you did something selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "What made it successful?",
        "How can you apply this again?"
    };

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "Reflect on times of strength and resilience.";
    }

    protected override void PerformActivity()
    {
        Random rand = new Random();

        // prevent repeats
        List<string> usedQuestions = new List<string>();

        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("\nReflect on the following questions:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            if (usedQuestions.Count == questions.Count)
                usedQuestions.Clear();

            string question;
            do
            {
                question = questions[rand.Next(questions.Count)];
            } while (usedQuestions.Contains(question));

            usedQuestions.Add(question);

            Console.WriteLine($"\n> {question}");
            ShowSpinner(5);
        }
    }
}