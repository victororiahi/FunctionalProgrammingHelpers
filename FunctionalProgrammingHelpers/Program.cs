/* Delegates, Lamdba Expressions, and Anonymous Methods
 Action Delegates
 Function Delegates (Func Delegates)
 Predicate Delegates
 Lambda Expressions
 Anonymous Methods
 
 What is a Delegate?
 A delegate is a type that represents references to methods.

Action is a pre-defined delegate for void returning methods.
Action can take between 0 - 16 input parameters.

Func is a pre-defined delegate for methods that return a value. 
Func can take between 0 - 16 input parameters and must return a value.

Predicate is a pre-defined delegate for methods that return a boolean value.

Lambda expressions are a concise way to represent anonymous methods or inline methods.
They are often used with LINQ queries and can be used to create delegates or expression trees.
The syntax for Lambda is =>
(input parameters) => expression
(input parameters) => { statement block }
() => expression
() => { statement block }
 */

using FunctionalProgrammingHelpers;

SampleClass sample = new SampleClass();



Greet greet = sample.SayHello;

greet("Joshua");

//Action
Action<string> greet2 = sample.SayHello;
greet2("Anita");

Action<string, int> greet3 = sample.SayGoodbye;
greet3("Joshua", 10);

Action greet4 = sample.Goodnight;
greet4();


//Func
Func<string> getName = sample.GetName;
string Name = getName();

Func<int, int> getTime = sample.GetTime;
int Time = getTime(10);


//Predicate
Predicate<int> isPast = sample.IsInThePast;
bool isInThePast = isPast(2020);

if (isInThePast == true)
{
    Console.WriteLine("The given year is in the past");
}

else
{
    Console.WriteLine("The given year is in the future");
}


//Lambda Expressions
Func<string> getName2 = () => "Joshua"; //This matches with line 24
Func<string> func = () =>
{
    Console.WriteLine("GetName was called");
    return "Joshua";
}; //This matches with line 25

string ReturnedName = func();

List<string> strings = new List<string> { "Joshua", "Anita", "John" };

strings.Where((x) => x.Length > 5);

sample.EnterAge(x => x + 10, 20);

Console.ReadKey();