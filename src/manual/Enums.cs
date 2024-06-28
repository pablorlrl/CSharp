// enums = special "class that contains a set of named integer constants.
//         Use enums when you have values that you know will not change, 
//         To get the integer value from an item, you must explicitly convert to an int.

namespace Enums;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Planets.Pluto+" is a planet."); // Pluto is a planet.
        Console.WriteLine(Planets.Mercury+" is planet #"+(int)Planets.Mercury); // Mercury is planet 0
        string name = PlanetRadious.Earth.ToString();
        int radious = (int) PlanetRadious.Earth;
        double volume = Volume(PlanetRadious.Earth);
        Console.WriteLine("planet: " + name + "radious: " + radious); // planet: Earth.
        Console.WriteLine("radious: " + radious + " km"); // radious: 6371 km
        Console.WriteLine("volume: " + volume + " km^3"); // volume: 1083206916845.7535 km^3
    }
    public static double Volume(PlanetRadious radious)
    {
        double volume = (4.0/3.0) * Math.PI * Math.Pow((int)radious, 3);
        return volume;
    }
}
enum Planets
{
    Mercury,
    Venus, 
    Earth,
    Mars, 
    Jupyter,
    Saturn,
    Uranus,
    Neptune,
    Pluto
}
// We can define its number manually for example to begin with 1 instead of 0 like:
enum Planets2
{
    Mercury = 1,
    Venus = 2, 
    Earth = 3,
    Mars = 4, 
    Jupyter = 5,
    Saturn = 6,
    Uranus = 7,
    Neptune = 8,
    Pluto = 9,
}
// You can store another type of info:
enum PlanetRadious
{
    Mercury = 2439,
    Venus = 6051, 
    Earth = 6371,
    Mars = 3389, 
    Jupyter = 69911,
    Saturn = 58232,
    Uranus = 25362,
    Neptune = 24622,
    Pluto = 1188,
}
