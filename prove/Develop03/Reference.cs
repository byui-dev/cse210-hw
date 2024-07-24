<<<<<<< HEAD
public class Reference;
{

    
}

GetDisplayText() : string
Possible getters and setters
=======
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
>>>>>>> 65c5d5125e0ccd05cb73f93f88163612b55a6a56
