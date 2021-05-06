public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        // Your code here
        int balance = 0;

        foreach (char n in input)
        {
            if (n.Equals('('))
            {
                balance++;
            }
            else if (n.Equals(')'))
            {
                balance--;
            }
            if (balance < 0)
            {
                return false;
            }
        }
        return balance == 0;
    }
}
