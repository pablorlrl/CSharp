// Lists = data structure that represents a list of objects. Similar to an array, but can dynamically
//         increase/decrease in size dynamically. More flexible and easy to use.
//         using System.Collections.Generic;
namespace Lists;
class Program
{
    static void Main(string[] args)
    {
        string[] food = new string[3];
        food[0] = "pizza"; 
        food[1] = "hamburger";
        food[2] = "hotdog";
        Array.Resize(ref food, 4); //To add more data to the array we have to resize it.
        food[3] = "sushi"; // Not having done the prior line, this will crash because of the length of the array.

        List<String> foodList = new List<string>();
        foodList.Add("pizza");
        foodList.Add("hamburger");
        foodList.Add("hotdog");
        foodList.Remove("hamburger");
        foodList.Insert(0, "sushi"); // This will insert sushi at index 0 {sushi, pizza, hotdog}.
        Console.WriteLine(foodList.Count); // 3
        Console.WriteLine(foodList.IndexOf("sushi")); // 0
        foodList.Add("sushi");
        Console.WriteLine(foodList.LastIndexOf("sushi")); // 3
        Console.WriteLine(foodList.Contains("pizza")); // true
        foodList.Sort(); // Alphabetically {hotdog, pizza, sushi, sushi}
        foodList.Reverse(); // Reverse order {sushi, sushi, pizza, hotdog}
        foodList.Clear(); // To wipe the list.
        String[] foodArray = foodList.ToArray(); // To convert it to an array.
    }
}
