using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment("John", "Great video! Learned a lot.");
        Comment comment2 = new Comment("Sarah", "Very informative, thanks for sharing.");
        Comment comment3 = new Comment("Michael", "I love the detailed explanation.");
        Comment comment4 = new Comment("Emma", "Please make more videos like this!");
        //Video 1
        Video video1 = new Video("Learn C# in 10 minutes", "David Lopez", 600);
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        //Video 2
        Video video2 = new Video("Introduction to Artificial Intelligence", "Laura Gomez", 1200);
        video2.AddComment(comment4);
        video2.AddComment(comment1);
        //Video 3
        Video video3 = new Video("Building a Web Application", "Carlos Martinez", 900);
        video3.AddComment(comment2);
        video3.AddComment(comment3);
        video3.AddComment(comment4);

        List<Video> videos = new List<Video> { video1, video2, video3 };
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.Author}: {comment.Text}");
            }
            Console.WriteLine(); 
        }
    }
}