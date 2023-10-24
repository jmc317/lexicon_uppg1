using lexicon_uppg1;
using System;

Employee employee = new Employee();
bool run=true; //Loop that determines if the app continues to run
List<Employee> employees = new List<Employee>();

do
{
    Console.WriteLine("1. Register employee ");
    Console.WriteLine("2. Show employee list ");
    Console.WriteLine("0. Exit application ");
    var selection = Convert.ToInt32(Console.ReadLine());


    switch (selection)
    {
        case 1:

            Console.Write("Enter the employee's name and salary: ");
            RegisterEmployee(employees);

            Console.WriteLine("Continue registrating? ");
            break;

        case 2:
            Console.WriteLine("Listing employees: ");
            ListEmployees(employees);
            break;
        case 0:
            Console.WriteLine("Shutting down application ");
            run = false;
            break;
    }
}
while (run == true);
static void RegisterEmployee(List<Employee> employees)
{
    Employee employee = new Employee();

    Console.Write("Enter the employee's name: ");
    employee.name = Console.ReadLine();

    Console.Write("Enter the employee's salary: ");
    if (double.TryParse(Console.ReadLine(), out double salary))
    {
        employee.salary = salary;
        employees.Add(employee);
        Console.WriteLine("Employee registered successfully.");
    }
    else
    {
        Console.WriteLine("Invalid salary. Please enter a valid numeric value.");
    }
}
static void ListEmployees(List<Employee> employees)
{
    if (employees.Count == 0)
    {
        Console.WriteLine("No employees registered yet.");
    }
    else
    {
        Console.WriteLine("\nList of Registered Employees:");
        foreach (var employee in employees)
        {
            Console.WriteLine($"Name: {employee.name}, Salary: {employee.salary:C}");
        }
    }
}