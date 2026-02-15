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
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"multiply: {multiply}");
Console.WriteLine($"divided by: {division}");
Console.WriteLine($"difference: {difference}");
Console.WriteLine($"modulus: {mod}");
Console.WriteLine();

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
Console.WriteLine();
Console.WriteLine($"Is greater than? {isGreaterThan}");
Console.WriteLine($"Is less than? {isLessThan}");
Console.WriteLine($"Is equal to? {isEqualTo}");
Console.WriteLine($"Is greater than or equal to? {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is less than or equal to? {isLessThanOrEqualTo}");
Console.WriteLine($"Is not equal to? {isNotEqualTo}");
Console.WriteLine();
Console.WriteLine(("-------- End Logic Results ---------"));


/*
 * Assignment operations and operators
 */
//num1 = num1 + 5;
//num1 += 5;
//num1 -= 3;
//num1 %= 2;
//num1 /=
//num1 *= 10;
Console.Write("Enter random value for assignment operations: ");
int randomValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(("-------- Assignment Results ---------"));
Console.WriteLine();
num1 += randomValue;
Console.WriteLine($"num 1 increase by {randomValue}: {num1}");
num1 -= randomValue;
Console.WriteLine($"num 1 reduce by {randomValue}: {num1}");
num1 /= randomValue;
Console.WriteLine($"num 1 divided by {randomValue}: {num1}");
num1 %= randomValue;
Console.WriteLine($"num 1 mod by {randomValue}: {num1}");
num1 *= randomValue;
Console.WriteLine($"num 1 multiplied by {randomValue}: {num1}");
Console.WriteLine();
Console.WriteLine(("-------- End Assignment Results ---------"));