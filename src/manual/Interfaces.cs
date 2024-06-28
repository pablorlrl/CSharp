// interface = defines a "contract" that all the classes inheriting from should follow.
//              An interface declares "what a class should have".
//              An inheriting class defines "how it should do it"
//              Benefit = security + multiple inheritance + "plug-and-play"
namespace Interfaces;
class Program
{
    static void Main(string[] args)
    {
        Rabbit rabbit = new Rabbit();
        rabbit.Flee(); //The rabbit runs away!

        Hawk hawk = new Hawk();
        hawk.Hunt(); //The hawk is searching for food.

        Fish fish = new Fish();
        fish.Hunt(); //The fish is searching for food.
    }
}
interface IPrey
{
    void Flee();
}
interface IPredator
{
    void Hunt();
}
class Rabbit : IPrey
{
    public void Flee()
    {
        Console.WriteLine("The rabbit runs away!");
    }
}
class Hawk : IPredator
{
    public void Hunt()
    {
        Console.WriteLine("The hawk is searching for food.");
    }
}
// Inherit multiple interfaces.
class Fish: IPrey, IPredator
{
    public void Flee()
    {
        Console.WriteLine("The fish runs away!");
    }
    public void Hunt()
    {
        Console.WriteLine("The fish is searching for food.");
    }
}