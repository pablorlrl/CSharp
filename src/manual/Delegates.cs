// In C#, a delegate is a type that represents a reference to a method. It is similar to a function pointer in C and C++.
delegate int MathOperation(int x, int y);
// To create an instance of a delegate, you need to specify the method that the delegate should reference. You can do this using a method group or a lambda expression. Here's an example:
MathOperation add = (x, y) => x + y;
MathOperation multiply = (x, y) => x * y;
// Once you have an instance of a delegate, you can invoke the method that it references using the delegate's Invoke method, or by using the delegate as if it were a regular method call. Here's an example:
int result = add(3, 4); // result is 7
result = multiply(3, 4); // result is 12
