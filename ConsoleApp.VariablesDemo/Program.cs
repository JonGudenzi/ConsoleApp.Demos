//Different DataTypes
/*
text - string
integer - int
decimal - double, float, decimal
logical - bool
*/


string name = "Jon";

Console.WriteLine(name);
Console.WriteLine("I am " + name); // String concatenation
Console.WriteLine($"My name is {name}");// String interpolation
Console.WriteLine( "{0} is my name", name);// string formatting

int age = 43;
int retirementYearsLeft = 24;
int retirementAge = age + retirementYearsLeft;
Console.WriteLine("My age is: " + age);

Console.WriteLine("My retirement age is " + retirementAge);

bool isRetired = false;
Console.WriteLine("Am I retired? " + isRetired);