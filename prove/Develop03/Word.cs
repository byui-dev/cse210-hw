<<<<<<< HEAD
public class Word;

Hide() : void
Show() : void
IsHidden() : bool
GetDisplayText() : string
=======
public class Word
{
    private string _text;
    public bool IsVisible { get; private set; }

    public Word(string text)
    {

        _text = text;
        IsVisible = true;

    }

    public void Hide()
    {

        IsVisible = false;
    }

    public override string ToString()
    {
        return IsVisible ? _text : "____";
    }
}
>>>>>>> 65c5d5125e0ccd05cb73f93f88163612b55a6a56
