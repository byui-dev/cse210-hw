using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Video
{
    private string title;
    private string author;
    private int lengthInSeconds;
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.lengthInSeconds = length;
        this.comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public string GetTitle()
    {
        return title;
    }

    public string GetAuthor()
    {
        return author;
    }   

    public int GetLength()
    {
        return lengthInSeconds;
    } 

    public List<Comment> GetComments()
    {
        return comments;
    }
  

}