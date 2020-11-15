using System;
public class ReplacedString
{
    private string replacedString;

    public ReplacedString(string s, string initialSubstring, string finalSubstring)
    {
        replacedString = s;

        while (replacedString != replacedString.Replace(initialSubstring, finalSubstring))
        {
            replacedString = replacedString.Replace(initialSubstring, finalSubstring);
        }
        
    }

    public override string ToString()
    {
        return replacedString;
    }
}