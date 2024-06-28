using Static;
Car[] garage = { new Car("Mustang"), new Car("Corvette"), new Car("Lambo") };

foreach (Car car in garage)
{
    Console.WriteLine(car.model);
}