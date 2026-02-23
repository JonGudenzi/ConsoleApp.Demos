

//Ask user how many times they want to print "Hello world"

Console.WriteLine("How many times do you want to print 'Hello world!'? ");

int userCount = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < userCount; i++)
{
    Console.WriteLine($"Hello world! - {i}");
}





