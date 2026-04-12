class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;

    static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\n--- Eternal Quest ---");
            Console.WriteLine($"Score: {score}");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": RecordEvent(); break;
                case "3": ShowGoals(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": running = false; break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Choose goal type: 1=Simple, 2=Eternal, 3=Checklist");
        string type = Console.ReadLine();
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == "2")
        {
            goals.Add(new EternalGoal(name, desc, points));
        }
        else if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(name, desc, points, target, 0, bonus));
        }
    }

    static void RecordEvent()
    {
        ShowGoals();
        Console.Write("Which goal did you complete? (index): ");
        int index = int.Parse(Console.ReadLine());
        if (index >= 0 && index < goals.Count)
        {
            int earned = goals[index].RecordEvent();
            score += earned;
            Console.WriteLine($"You earned {earned} points!");
        }
    }

    static void ShowGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i}. {goals[i].GetStatus()} {goals[i].Name} - {goals[i].Description}");
        }
    }

    static void SaveGoals()
    {
        using (StreamWriter output = new StreamWriter("goals.txt"))
        {
            output.WriteLine(score);
            foreach (Goal g in goals)
            {
                output.WriteLine(g.Serialize());
            }
        }
        Console.WriteLine("Goals saved!");
    }

    static void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");
            score = int.Parse(lines[0]);
            goals.Clear();
            for (int i = 1; i < lines.Length; i++)
            {
                goals.Add(Goal.Deserialize(lines[i]));
            }
            Console.WriteLine("Goals loaded!");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}