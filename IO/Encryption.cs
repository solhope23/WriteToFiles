
public static class Encryption
{
    public static char AtbashChar(char Letter)
    {
        string[] AllLetters = { "Aa", "Bb", "Cc", "Dd", "Ee", "Ff", "Gg", "Hh", "Ii", "Jj", "Kk", "Ll", "Mm",
                                "Nn", "Oo", "Pp", "Qq", "Rr", "Ss", "Tt", "Uu", "Vv", "Ww", "Xx", "Yy", "Zz" };

        for (int i = 0; i < AllLetters.Length; i++ )
        {
            if (Letter == AllLetters[i][0])
            {
                Letter = AllLetters[AllLetters.Length - 1 - i][0];
                break;
            }
            else if (Letter == AllLetters[i][1])
            {
                Letter = AllLetters[AllLetters.Length - 1 - i][1];
                break;
            }
        }
        return Letter;
    }

    public static string AtbashString(string String)
    {
        string NewString = "";

        foreach (char Letter in String)
        {
            NewString += Encryption.AtbashChar(Letter);
        }
        return NewString;
    }
}