string name;
int salary;
int selection;


    Console.WriteLine("1. Register a person with their name and salary: ");
    Console.WriteLine("2. Exit application ");
    selection = Convert.ToInt32(Console.ReadLine());

switch (selection)
{
    case 1:
        Console.WriteLine("Name: ");
        name = Console.ReadLine();
        Console.WriteLine("Salary: ");
        salary = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Registered " + name + " with monthly income: " + salary);
        break;

    case 2:
        break;

}