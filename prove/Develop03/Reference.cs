using System.Runtime.InteropServices;

public class Reference
{
    private List<string> _scriptures;

    public Reference(List<string> scriptures)
    {

        _scriptures = scriptures;
    }

    public string GetScripture(int index)
    {

        if (index >= 0 && index < _scriptures.Count)
        {

           return _scriptures[index];
        }
        throw new ArgumentOutOfRangeException("Invalid scripture reference. ");
    }
}
