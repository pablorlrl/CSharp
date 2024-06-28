// In this class we can see the importance of the encapsulation to limit the values that can be set into the speed values.
// The property Speed adds security to the parameter speed by not letting anyone set that property to whatever value.
namespace Encapsulation;

class Car
{
    private int speed = 0;
    private int wheels = 4;
    public Car(int speed)
    {
        Speed = speed;
    }
    public int Speed
    {
        get{ return speed; } //read
        set                  //write.
        {
            if (value >500)
            {
                speed = 500;
            } 
            else 
            {
                speed = value;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car(400);
        car.Speed = 100000;
        Console.WriteLine(car.Speed);
        Console.ReadKey();

    }
}