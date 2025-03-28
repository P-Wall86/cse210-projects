using System;

class Program
{
    static void Main(string[] args)
    {
        var videos = new List<Video>
        {
            new Video("Pioneer Life Hacks: Surviving the Wild Without WiFi", "Brigham Young", 600),
            new Video("Liahona Black Screen: How to Fix It", "SonOfLehi", 400),
            new Video("Built an Ark in 120 years | Timelapse", "Noah Smith", 950)
        };

        videos[0].AddComment(new Comment("PioneerTechie", "Great tutorial!"));
        videos[0].AddComment(new Comment("SidneyR", "Just what we all needed."));

        videos[1].AddComment(new Comment("LamanTheDoubter", "Show-off"));
        videos[1].AddComment(new Comment("SteadySam", "That was helpful. Thanks!"));

        videos[2].AddComment(new Comment("FloodedWithQuestions", "Need more details"));
        videos[2].AddComment(new Comment("DINOmic", "Perfect for beginners"));

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments ({video.GetCommentCount()}):");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetCommentText()}");
            }
            Console.WriteLine();
        }
    }
}