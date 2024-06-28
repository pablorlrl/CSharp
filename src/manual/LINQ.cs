// LINQ (Language Integrated Query) is a set of language extensions to C# (and other .NET languages) 
// that allow you to write queries against different data sources, such as collections, arrays, databases, 
// and XML. LINQ provides a unified syntax and programming model for working with data, regardless of its source or format.

// Suppose we have a collection of Person objects defined as follows:
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

List<Person> people = new List<Person>
{
    new Person { Name = "Alice", Age = 25 },
    new Person { Name = "Bob", Age = 30 },
    new Person { Name = "Charlie", Age = 35 },
};
// We can use LINQ to query this collection and retrieve, for example, all people who are older than 30:
var result = from p in people
             where p.Age > 30
             select p;

foreach (var person in result)
{
    Console.WriteLine(person.Name);
}
// Querying a database with LINQ to SQL.
using (var context = new MyDataContext())
{
    result = from e in context.Employees
                 where e.Salary > 50000
                 select e;

    foreach (var employee in result)
    {
        Console.WriteLine(employee.Name);
    }
}
// Querying an XML document
// XML doc.
<people>
  <person name="Alice" age="25" />
  <person name="Bob" age="30" />
  <person name="Charlie" age="35" />
</people>
// Query.
XDocument doc = XDocument.Load("people.xml");

result = from p in doc.Descendants("person")
             where (int)p.Attribute("age") > 30
             select (string)p.Attribute("name");

foreach (var name in result)
{
    Console.WriteLine(name);
}