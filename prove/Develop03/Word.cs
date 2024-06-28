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