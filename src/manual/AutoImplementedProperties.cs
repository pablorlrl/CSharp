// Auto Implemented Properties = shortcut when no additional logic is required in the property 
//      you do not have to define a field for a property, you only have to write get; and/or set; inside the property.
namespace AutoImplementedProperties;

class WellEncapsulatedCar
{
    private string model;
    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    public WellEncapsulatedCar(string model)
    {
        this.Model = model;
    }
}

// If you have no additional logic to add to th e getters/setters, you will shortcut a little:
// But with Auto Implemented Properties does not encapsulate properly.
class Car
{
    private string model;
    public string Model {get; set;}
    public Car(string model)
    {
        this.Model = model;
    }
}
// That, does not store the data into the model but the Model itself and is like:
class Car2
{
    public string Model {get; set;}
    public Car2(string model)
    {
        this.Model = model;
    }
}
// So it is a worse solution in terms of encapsulation.