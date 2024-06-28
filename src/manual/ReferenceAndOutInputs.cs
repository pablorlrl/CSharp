// To pass an object by reference and modify it inside a method we can pass it by reference:
// USES:
//      Reference: To change the properties of an object inside a method and preserve the changes.
//      Out: To be able to retrieve multiple outputs from a method. Not doing this will lead you 
//           to manage the results only with the return statement.
namespace References;
class Program
{
    static void Main(string[] args)
    {
        String[] food = new string[3];
        Array.Resize(ref food, 4);

        int x = 0;
        Increment(ref x); // x is now 1

        int a, b;
        GetValues(out a, out b); // a is 1, b is 2
    }
    public static void Increment(ref int x)
    {
        x++;
    }

    public static void GetValues(out int a, out int b)
    {
        a = 1;
        b = 2;
    }
}