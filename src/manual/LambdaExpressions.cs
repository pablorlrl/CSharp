// In C#, a lambda expression is a concise way to define an anonymous function. A lambda expression can be thought of as a shorthand notation for defining a delegate instance.
// This lambda expression defines an anonymous function that takes two integer parameters x and y, and returns their sum. The types of x and y are inferred to be int based on the context in which the lambda expression is used.
(int x, int y) => x + y;
// As a delegate instance: A lambda expression can be assigned to a delegate variable to create a delegate instance that refers to the anonymous function. Here's an example:
// In this case, the lambda expression (x, y) => x + y takes two int parameters and returns their sum as an int. The Func type now specifies three type parameters, where the first two are the input parameter types, and the last one is the return type of the delegate.
Func<int, int, int> add = (x, y) => x + y;
int result = add(3, 4); // result is 7
// As a parameter to a method: A lambda expression can be passed as a parameter to a method that expects a delegate instance. Here's an example:
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
int count = numbers.Count(n => n % 2 == 0); // count is 2
