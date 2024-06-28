// thread = an execution path of a program
//          We can use multiple threads to perform,
//          different tasks of ur program at the same time.
//          Current thread running is "main" thread
//          using System.Threading;
namespace Threads;
class Program
{
    static void Main(string[] args)
    {
        Thread mainThread = Thread.CurrentThread;
        mainThread.Name = "Main Thread";
        Console.WriteLine(mainThread.Name);

        Thread thread1 = new Thread(() => CountDown("Timer #1"));
        Thread thread2 = new Thread(() => CountUp("Timer #1"));
        thread1.Start();
        thread1.Start();
        
        Console.WriteLine(mainThread.Name + " is complete!");  
        // Mainthread is complete, and the rest of timers acting concurrently. 

        // In this example, we're creating a new Thread instance and defining an anonymous method using a lambda expression. 
        // The lambda expression takes no parameters explicitly, but it does define two local variables x and y and calls a method called Calculate with those two values as arguments. 
        // The Calculate method is not shown, but presumably it takes two integers as input and returns a boolean value indicating whether some condition is true or false.
        // After calling Calculate, the lambda expression assigns the result to a local variable result, and then writes a message to the console indicating what the result was.
        Thread thread3 = new Thread(() => {
            int result = Calculate(10, 20);
            Console.WriteLine($"The result is {result}");
        });     
    }
    public static void CountDown(string name)
    {
        for(int i=10; i>=0; i--)
        {
            Console.WriteLine("Timer #1 : "+ i + " seconds");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Timer #1 is complete!");
    }
    public static void CountUp(string name)
    {
        for(int i=0; i<=10; i++)
        {
            Console.WriteLine("Timer #1 : "+ i + " seconds");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Timer #2 is complete!");
    }
    public static int Calculate(int x, int y)
    {
        return x+y;
    }
}