using System.Collections.Generic;

public static class Kata
{
    public static string GetOrder(string input)
    {
        List<string> foods = new List<string>()
    {
      "Burger", "Fries", "Chicken", "Pizza", "Sandwich", "Onionrings", "Milkshake", "Coke"
    };

        List<string> result = new List<string>();

        foreach (string food in foods)
        {
            while (input.Contains(food.ToLower()))
            {
                result.Add(food);
                input = input.Remove(input.IndexOf(food.ToLower()), food.Length);
            }
        }

        return string.Join(" ", result);
    }
}
