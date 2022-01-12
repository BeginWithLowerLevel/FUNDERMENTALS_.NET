// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("The current time is : " + DateTime.Now);

// var name = "Bob";
// var value = 3;
// var celsious = 34.4m;

// Console.Write("Hello, " + name);
// Console.Write(" You have " + value + " in your inbox.");
// Console.Write(" The temperature is " + celsious + " celsius");

// Console.WriteLine(@"   c:\source\repos   
//       (this is where your code goes)");

// // Kon'nichiwa World
// Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// string firstName = "Bob";
// string greeting = "Hello";
// string message = $"{greeting} {firstName}!";
// Console.WriteLine(message);

// int fahrenheit = 94;
// decimal celsius = (fahrenheit -32) *  5.0m/9;

// Console.WriteLine($"The temperature is {celsius}");

// Random dice = new Random();
// int roll = dice.Next(1,7);
// Console.WriteLine(roll);

// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// int firstValue = 500;
// int secondValue = 600;
// int largerValue;

// largerValue = Math.Max(firstValue , secondValue);

// Console.WriteLine(largerValue);

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if(daysUntilExpiration <= 10){
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

else if(daysUntilExpiration <= 5){
    Console.WriteLine(@$"Your subscription expires in {daysUntilExpiration} days.
                         \nRenew now and save 10%!");
}

else
    Console.WriteLine("Your subscription has expired.");