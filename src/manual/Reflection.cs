using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Type myType = typeof(MyClass);
        object obj = Activator.CreateInstance(myType);
        MethodInfo myMethod = myType.GetMethod("MyMethod");
        myMethod.Invoke(obj, null);
    }
}

class MyClass
{
    public void MyMethod()
    {
        Console.WriteLine("Hello, world!");
    }
}
