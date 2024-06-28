// static = modifier to declare a static member, which belongs to the class itself
//          rather to any specific object. Similar to global in python, but to access
//          the static properties you have to call the class itself. Not an instance/object of that type.
//          If you apply the static modifier to a class, you won't be able to create objects from it.
//          They are useful if you do want to access methods but not instantiate the class:
//              You would not instantiate the math class.
//              Math math1 = new Math()
//              math1.Round(3.14)
//
//              But you would use its methods directly from the class.
//              Math. Round(3.14)
namespace Static;
class Car
{
    public static int numberOfCars;
    public String model;

    public Car(String model)
    {
        numberOfCars++;
        this.model = model;
    }

    public static void StartRace()
    {
        Console.WriteLine("The race has started.");
    }
}

class Program 
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Mustang");
        Car car1 = new Car("Mustang");

        Console.WriteLine(Car.numberOfCars); // 2.
        Car.StartRace() // "The race has started."

        Console.WriteLine(car1.numberOfCars); // does not work.
        car1.StartRace() // does not work.
    }
}
