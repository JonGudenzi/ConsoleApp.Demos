//Welcome Message

Console.WriteLine(" ------- Welcome to the Sample Calculator! --------- ");
// Show calulator options / Show menu
Console.WriteLine("Please select an operation: ");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
int choice = Convert.ToInt32(Console.ReadLine());

//Promt for user input
Console.WriteLine("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// Decide which operation is needed based on selected option
int answer = 0;
switch (choice)
{
    case 1:
        answer = num1 + num2;
        break;
    case 2:
        answer = num1 - num2;
        break;
    case 3:
        answer = num1 * num2;
        break;
    case 4:
        answer = num1 / num2;
        break;
    default:
        Console.WriteLine("Invalid choice. Please select a valid operation.");
        break;
}

// Print output
Console.WriteLine($"The result is : {answer}");