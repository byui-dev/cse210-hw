using System;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {
        var scriptures = new List<string>
        {

            "Matthew 7:1 Judge not, that ye be not judged.",
            "Matthew 7:7 Ask, and it shall be given you; seek, and ye shall find; knock, and it shall be opened unto you ",
            "John 3:16 For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
            "James 1:5 If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.",
            "Malachi 3:8-9 Will a man rob God? Yet ye have robbed me. But ye say, Wherein have we robbed thee? In tithes and offerings. Ye are cursed with a curse: for ye have robbed me, even this whole nation."
        };
        var reference = new Reference (scriptures);

        var scriptureText = reference.GetScripture(0);
        var scripture = new Scripture(scriptureText);

        while (!scripture.AllWordsHidden())
        {

            scripture.Display();
            scripture.HideWords(2);
            System.Threading.Thread.Sleep(1000); 
        }
    }
}