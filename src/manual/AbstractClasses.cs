// abstract classes = modifier that indicates missing components or incomplete implementation.
//                    if you do want to prevent people to create a vehicle instance because is an incomplete
//                    version of a vehicle, you do want people to instantiate only specific vehicles, you can 
//                    convert the vehicle into an abstract class.
namespace AbstractClasses;
abstract class Vehicle
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

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Bicycle bicycle = new Bicycle();
        Boat boat = new Boat();
        // Vehicle vehicle = new Vehicle //This cannot be done as the Vehicle class is an abstract class.
    }
}