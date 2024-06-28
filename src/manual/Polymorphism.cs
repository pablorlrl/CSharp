// polymorphism = Objects can be identified as more than one type
//              also same method works for different objects cat dog mehtod talk, miau woof.
namespace Polymorphism;
class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Bicycle bicycle = new Bicycle();
        Boat boat = new Boat();
        
        Car[] vehicles = {car, bicycle, boat}; // Will not work.
        Vehicle[] vehicles2 = {car, bicycle, boat}; // They can also identify as a vehicle (polymorphism).
    }
}
class Vehicle
{
    public int speed = 0;

    public void go()
    {
        Console.WriteLine("This vehicle is moving!");
    }
}

class Car: Vehicle
{
    public int wheels = 4;
    public int maxSpeed = 200;
}

class Bicycle: Vehicle
{
    public int wheels = 2;
    public int maxSpeed = 50;
}
class Boat: Vehicle
{
    public int wheels = 0;
    public int maxSpeed = 100;
}