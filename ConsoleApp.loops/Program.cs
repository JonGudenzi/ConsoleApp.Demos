

Console.WriteLine("--------- for loop --------");

Console.WriteLine("How many times do you want to print 'Hello world!'? ");

int userCount = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < userCount; i++)
{
    Console.WriteLine($"Hello world! - {i}");
}

Console.WriteLine("--------- while loop --------");
// This will print "Hello world!" 10 times, with the count number
int count = 0;
while (count < 10)
{
    Console.WriteLine($"Hello world! - {count}");
    count++;
}

// This will keep asking the user to enter numbers until they enter -1, and it will sum up all the numbers entered (except -1) and print the total sum at the end.
int sum = 0;
int num = 0;
while (num != -1)
{
    Console.Write("Please enter numbers to be summed up (enter 0 to stop): "); 
    num = Convert.ToInt32(Console.ReadLine());
    if(num != -1)
    {
        sum += num;
    }
}

Console.WriteLine($"The total sum is: {sum}");

Console.WriteLine("--------- do.. while loop --------");

