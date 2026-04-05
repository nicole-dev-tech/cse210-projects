using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        /*
         * EXCEEDING REQUIREMENTS:
         * - Added session counter (tracks how many activities completed)
         * - Prevents repeating prompts/questions in same session
         * - Added spinner + countdown animations
         */

        int sessionCount = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            Activity activity = null;

            if (choice == "1")
                activity = new BreathingActivity();
            else if (choice == "2")
                activity = new ReflectionActivity();
            else if (choice == "3")
                activity = new ListingActivity();
            else if (choice == "4")
                break;

            if (activity != null)
            {
                activity.Run();
                sessionCount++;
                Console.WriteLine($"\nTotal sessions completed: {sessionCount}");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}