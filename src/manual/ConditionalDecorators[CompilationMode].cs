// In this case, the TraceMethod method will only be executed if both the DEBUG and TEST1 symbols are defined during compilation.
[Conditional("DEBUG"), Conditional("TEST1")]
void TraceMethod()
{
    // ...
}

// To define a compilation symbol, you can use the #define directive in your code or add the symbol to the project properties in Visual Studio. For example, to define the TEST1 symbol, you could add the following line at the top of your code file:
#define TEST1
