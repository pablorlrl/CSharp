// generic = "not specific to a particular data type"
//          add <T> to: classes, methods, fields, etc.
//          allows for code reusability for different data types.
namespace Generics;
class Program
{
    static void Main(string[] args)
    {
        int[] intArray = {1, 2, 3};
        double[] doubleArray = {1.0, 2.0, 3.0};
        string[] stringArray = {"1", "2", "3"};

        displayElements(intArray);
        displayElements(doubleArray); // We can only use it for ints, we cannot pass the method a double array.
        // We could copy the same method that accepts an array of doubles as an argument, but...
        displayElements(stringArray);

        // Creation of a generic method. That will accept an array of whatever type.
        displayElementsGeneric(intArray);
        displayElementsGeneric(doubleArray);
        displayElementsGeneric(stringArray);
    }
    // <T> could be <Thing> or whatever.
    public static void displayElementsGeneric<T>(T[] array)
    {
        foreach (T item in array)
        {
            Console.Write(item + " ");
        }
    }
    public static void displayElements(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
    }
    public static void displayElements(double[] array)
    {
        foreach (double item in array)
        {
            Console.Write(item + " ");
        }
    }
    public static void displayElements(string[] array)
    {
        foreach (string item in array)
        {
            Console.Write(item + " ");
        }
    }
}