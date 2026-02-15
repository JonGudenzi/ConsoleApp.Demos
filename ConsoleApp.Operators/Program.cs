Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
/*
 * Math operations and operators
 */
// Add numbers
int sum = num1 + num2;
// multiply
int multiply = num1 * num2;
// division
int division = num1 / num2;
// subtraction
int difference = num1 - num2;
// Modulus
int mod = num1 % num2;

Console.WriteLine(("------- Math Results ----------"));
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"multiply: {multiply}");
Console.WriteLine($"divided by: {division}");
Console.WriteLine($"difference: {difference}");
Console.WriteLine($"modulus: {mod}");
Console.WriteLine(("-------- End Math Results ---------"));

/*
 * Logic operations and operators
 */

var isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqualTo = num1 != num2;

Console.WriteLine(("-------- Logic Results ---------"));
Console.WriteLine($"Is greater than? {isGreaterThan}");
Console.WriteLine($"Is less than? {isLessThan}");
Console.WriteLine($"Is equal to? {isEqualTo}");
Console.WriteLine($"Is greater than or equal to? {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is less than or equal to? {isLessThanOrEqualTo}");
Console.WriteLine($"Is not equal to? {isNotEqualTo}");
Console.WriteLine(("-------- End Logic Results ---------"));
