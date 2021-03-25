using System.Text;

class MorseCodeDecoder
{
    public static string Decode(string morseCode)
    {
        string letter = "";
        string result = "";
        morseCode = morseCode.Trim();

        for (int i = 0; i < morseCode.Length; i++)
        {
            if (!morseCode[i].Equals(' '))
            {
                letter += morseCode[i];
            }
            else
            {
                result += MorseCode.Get(letter);
                letter = "";
                if (morseCode[i - 1].Equals(' ') && morseCode[i + 1].Equals(' '))
                {
                    result += " ";
                }
            }
            if (i == morseCode.Length - 1)
            {
                result += MorseCode.Get(letter);
            }
        }
        return result;
    }
}