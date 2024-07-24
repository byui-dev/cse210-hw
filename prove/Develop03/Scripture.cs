<<<<<<< HEAD
public class Scripture;
{
    
}

HideRandomWords(numberToHide : int) : void
GetDisplayText() : string
IsCompletelyHidden() : bool
=======
public class Scripture
{

    private List<Word> _words;

    public Scripture(string scripture)
    {

        _words = scripture.Split(' ').Select(word  => new Word(word)).ToList();

    }

    public void Display()
    {

        Console.WriteLine(string.Join(" ", _words.Select(word => word.ToString())));
    }

    public void HideWords(int count)
    {

        int wordsToHide = Math.Min(count, _words.Count(word => word.IsVisible));
        foreach (var word in _words.Where(word => word.IsVisible).Take(wordsToHide))
        {

            word.Hide();
        }
    }

    public bool AllWordsHidden()
    {

        return _words.All(word => !word.IsVisible);
    }
}
>>>>>>> 65c5d5125e0ccd05cb73f93f88163612b55a6a56
