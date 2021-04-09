using System.Linq;

class Kata
{
    public static string Bump(string input)
    {
        //Do Some Magic
        if (input.Count(f => f == 'n') > 15)
        {
            return "Car Dead";
        }
        return "Woohoo!";
    }
}
