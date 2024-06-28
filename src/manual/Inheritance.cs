// inheritance = 1 or more child classes receiving fields, methods, etc. from a common parent.
//               this is interesting to for example refactor only the method go() one time to affect
//               every child that does use that common method.
namespace Inheritance;
class Vehicle
{
    public int speed = 0;

    public void go()
    {
        Console.WriteLine("This vehicle is moving!");
    }
    // virtual modifier. To become overridable. (you can do that with abstract too but the class has to be abstract too.)
    public virtual void StopEngine()
    {
        Console.WriteLine("Vehicle stopped.");
    }
}

class Car: Vehicle
{
    public int wheels = 4;
}

class Bicycle: Vehicle
{
    public int wheels = 2;
    // Method overriding. To override a method the original has to have the "virtual modifier".
    public override void StopEngine()
    {
        Console.WriteLine("A bycicle has not an engine to stop.");
    }
    public override string ToString()
    {
        String message = $"This vehicle has {wheels} wheels"; 
        return message;
    }
}
class Boat: Vehicle
{
    public int wheels = 0;
}