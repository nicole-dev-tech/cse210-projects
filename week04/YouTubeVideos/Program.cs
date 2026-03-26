using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("C# Abstraction Explained", "TechWithNicole", 720);
        video1.AddComment(new Comment("Lude", "Great explanation of abstraction!"));
        video1.AddComment(new Comment("Sam", "This helped me a lot with my classes."));
        video1.AddComment(new Comment("Jordan", "Love the real-world example."));
        video1.AddComment(new Comment("Kendra", "Can you do one on encapsulation next?"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Top 10 Programming Tips", "CodeMaster", 1250);
        video2.AddComment(new Comment("Collin", "Number 7 changed how I code!"));
        video2.AddComment(new Comment("Peter", "Thanks for the tips."));
        video2.AddComment(new Comment("Morgan", "Very practical advice."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Building Classes in C#", "DevJourney", 890);
        video3.AddComment(new Comment("Jamie", "Clear and concise."));
        video3.AddComment(new Comment("Pat", "The Comment class is perfect."));
        video3.AddComment(new Comment("Quinn", "This is exactly what I needed."));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("YouTube Analytics for Beginners", "Nicoletech", 650);
        video4.AddComment(new Comment("Gift", "Super useful for my project!"));
        video4.AddComment(new Comment("Beven", "The comment tracking part is cool."));
        video4.AddComment(new Comment("Amanda", "Thanks for sharing."));
        videos.Add(video4);

        // Display all videos
        Console.WriteLine("YouTube Videos and Comments\n");
        foreach (var video in videos)
        {
            video.Display();
        }

        Console.WriteLine("Program complete. Press any key to exit...");
        Console.ReadKey();
    }
}