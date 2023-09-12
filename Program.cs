string name;
int salary;

Console.WriteLine("Register a person with their name and salary: ");
Console.WriteLine("Name: ");
name = Console.ReadLine();
Console.WriteLine("Salary: ");
salary = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Registered " + name + " with monthly income: " + salary);

/*Jag försökte göra en do-while loop så att man kan fortsätta registrera personal. I condition så ville jag ha att om man väljer 1. så lägger man till fler 
och 2. så avslutas loopen. Problemet var att jag inte fick till konvertering från användares input för val (readline) som vad jag förstår i C# måste vara en string (?)
till en int. Därför blev det ett väldigt basic program. */