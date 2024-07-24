using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create songs and add responses
        Video video1 = new Video("Outdoor Adventures", "Sam Smith", 354);
        video1.AddComment(new Comment("Steve Mark", "Great adventure!"));
        video1.AddComment(new Comment("Phillip Mason", "Excellent work!"));
        video1.AddComment(new Comment("Lawrence Moroka", "I want to experience it myself."));
        videos.Add(video1);

        Video video2 = new Video("For the love of the game", "Lesiba Moshoeu", 183);
        video2.AddComment(new Comment("Lucas Radebe", "What a gifted footballer."));
        video2.AddComment(new Comment("Philemon Masinga", "He was a true football legend."));
        video2.AddComment(new Comment("Carol Manana", "An exceptional talent."));
        videos.Add(video2);

        Video video3 = new Video("Bophuthatswana - once upon an era", "Mothusi Magano", 294);
        video3.AddComment(new Comment("Thomas Spencer", "A nostalgic experience for me!"));
        video3.AddComment(new Comment("Obakeng Diphala", "Remembering my childhood."));
        video3.AddComment(new Comment("Lucas Mangope", "A great time to be a leader."));
        video3.AddComment(new Comment("Gert Nkau", "It was a great era in our country's history!"));
        videos.Add(video3);

        // Display information for each song
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }
            Console.WriteLine();
        }
    }
}