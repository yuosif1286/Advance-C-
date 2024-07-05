// See https://aka.ms/new-console-template for more information



class  Employee
{
    public string Name { get; set; }
    public int BasicSalary { get; set; }
    public int Deduction { get; set; }
    public int Bonus { get; set; }
}

partial class Program
{
    delegate bool ShouldCalculate(Employee employee);
    public static void Main(string[] args)
    {
        List<Employee> employees = new();

        for (int i = 0; i < 100; i++)
        {
            employees.Add(new Employee
            {
                Name = $"Employee {i}",
                BasicSalary = Random.Shared.Next(1000, 5000),
                Deduction = Random.Shared.Next(0, 500),
                Bonus = Random.Shared.Next(0, 800)
            });
        }
        CalculateSalary(employees,e=>e.BasicSalary < 2000);
    }

     static void CalculateSalary(List<Employee> employees,ShouldCalculate predicate)
    {
        foreach (var employee in employees)
        {
            if (predicate(employee))
            {
                  var result = employee.BasicSalary + employee.Bonus - employee.Deduction;
                  Console.WriteLine($"employee name :{employee.Name} and salary is : {result}");
            }
        }
    }
} 