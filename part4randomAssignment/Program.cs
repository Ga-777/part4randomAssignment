// See https://aka.ms/new-console-template for more information
Random generator = new Random();
int randomNumber;
int number1, number2;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Random_Numbers.com");
Console.WriteLine("//////////////////");
Console.WriteLine("Please press enter to continue...");
Console.ReadLine();
Console.Clear();
Thread.Sleep(1000);
Console.WriteLine("Enter your first number: ");
while (!int.TryParse(Console.ReadLine(), out number1))
    
    Console.WriteLine("Please enter a valid number.");
Console.WriteLine();
Console.WriteLine("Enter your second number: ");
while (!int.TryParse(Console.ReadLine(), out number2))
        
        Console.WriteLine("Please enter a valid number.");
Console.WriteLine("Please press enter to continue...");
Console.ReadLine();
Console.Clear();
Thread.Sleep(1000);
if (Convert.ToInt32(number1) > Convert.ToInt32(number2))
{
    Console.WriteLine("Your first number is greater than your second number. Please try again.");
    Console.WriteLine("Press enter to continue...");
    Console.ReadLine();
    Console.Clear();
    Thread.Sleep(1000);
    while (!int.TryParse(Console.ReadLine(), out number1))
        
        Console.WriteLine("Please enter a valid number.");
    Console.WriteLine();
    Console.WriteLine("Enter your second number: ");
    while (!int.TryParse(Console.ReadLine(), out number2))
        
        Console.WriteLine("Please enter a valid number.");
}
randomNumber = generator.Next(Convert.ToInt32(number1), Convert.ToInt32(number2));
Console.WriteLine("Your random number is: " + randomNumber);   
Console.WriteLine("");
Thread.Sleep(1000);
Console.WriteLine("Press enter to contiune...");
Console.ReadLine();
Console.Clear();
Console.WriteLine("roll both dice? (y/n)");
if (Console.ReadLine().ToLower() == "y")
{
    int die1 = generator.Next(1, 7);
    int die2 = generator.Next(1, 7);
    int sum = (die1 + die2) / 2;
    Console.WriteLine("You rolled a " + die1 + " and a " + die2 + ".");
    Console.WriteLine("the average of the two dice is: " + sum);
}
else
{
    Console.WriteLine("You chose not to roll the dice.");
    
}
Console.WriteLine("Press enter to contiune...");
Console.ReadLine();
Console.Clear();
// 
decimal  number3, number4;
Console.WriteLine("Please enter your base number: ");
while (!decimal.TryParse(Console.ReadLine(), out number3))
    Console.WriteLine("Please enter a valid number.");
Console.WriteLine("Please enter your mix number: ");
while (!decimal.TryParse(Console.ReadLine(), out number4))
    Console.WriteLine("Please enter a valid number.");

decimal decimalRange = number3 - number4;




for (int i = 0; i < 10; i++)
{
    decimal randomDecimal = ((decimal)generator.NextDouble() * decimalRange) + number4;
    randomDecimal = Math.Round(randomDecimal, 2);

    Console.WriteLine("Your random decimal number is:" + randomDecimal);
}
