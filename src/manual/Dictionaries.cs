namespace Dictionaries;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> superheroes = new Dictionary<string, string>();
        superheroes.Add("Clark Kent", "Superman");
        superheroes.Add("Bruce Wayne", "Batman");
        superheroes.Add("Barry Allen", "The Flash");

        superheroes.Remove("Barry Allen");
        Console.WriteLine("Count : {0}",
            superheroes.ContainsKey("Clark Kent"));
        
        superheroes.TryGetValue("Clark Kent", out string test);
        Console.WriteLine($"Clark Kent : {test}");

        foreach (KeyValuePair<string, string> item in superheroes)
        {
            Console.WriteLine("{0} : {1}",
                item.Key, item.Value);
        }
        superheroes.Clear();
    }
}