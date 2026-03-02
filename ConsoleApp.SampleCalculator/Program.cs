//Variable Declarations
int choice = 0;
int num1 = 0;
int num2 = 0;

// Show calulator options / Show menu
while (choice != -1)
{
    try
    {
        Console.WriteLine(" ------- Welcome to the Sample Calculator! --------- ");
        Console.WriteLine("Please select an operation: ( -1 to exit )");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Fibonacci sequence");

        choice = Convert.ToInt32(Console.ReadLine());

        if (choice == -1)
        {
            break;
        }

        Console.WriteLine("Please enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

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

            case 5:
                for (int i = num1; i <= num2; i++)
                {
                    answer += i;
                }
                break;
            default:
                throw new Exception("Invalid Menu Item Selected.");
        }

        //Print output
        Console.WriteLine($"The answer is: {answer}");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot divide by zero");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
        continue;
    }
    finally
    {
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
        Console.Clear();
    }
}
Console.WriteLine(" ------- Thank you for using the simple calculator ------- ");

