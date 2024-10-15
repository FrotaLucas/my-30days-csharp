// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

Employee lucas = new Employee("Lucas", 31);
Employee viviane = new Employee("Viviane", 23);


//defini taxID como private. Nao pode por isso ser alterado
//lucas.taxID = 1;


//set e get para evitar de mudar o value
lucas.tax = -13;
//Console.WriteLine("Tax: {0}", lucas.tax);


//LISTAS

List<Employee> employees = new List<Employee>();

employees.Add(lucas);   
employees.Add(viviane);


foreach (Employee e in employees)
{
    e.CalculateTax();
}

