using System.Collections.Generic;
using System.IO;

namespace Labb_4___Collection_generics___Linus_Aspelöf_SUT23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Del 1 - Stack
            Stack<Employee> employeeStack = new Stack<Employee>();

            // Lägg till fem objekt i Stack
            for (int i = 1; i <= 5; i++)
            {
                Employee emp = new Employee
                {
                    ID = i,
                    Name = $"Employee{i}",
                    Gender = i % 2 == 0 ? "Male" : "Female",
                    Salary = 50000 + i * 10000
                };

                employeeStack.Push(emp);
            }

            Console.WriteLine("\n\tObjects in Stack:");
            foreach (var emp in employeeStack)
            {
                Console.WriteLine($"\n\tID: {emp.ID}, Name: {emp.Name}, Gender: {emp.Gender}, Salary: {emp.Salary}" +
                    $"\n\tItems left in Stack: {employeeStack.Count}");
            }

            Console.WriteLine("\n\t---------------------------------------------------------------");

            Console.WriteLine("\n\tPop items from Stack:");
            while (employeeStack.Count > 0)
            {
                Employee poppedEmp = employeeStack.Pop();
                Console.WriteLine($"\n\tID: {poppedEmp.ID}, Name: {poppedEmp.Name}, Gender: {poppedEmp.Gender}, Salary: {poppedEmp.Salary}" +
                    $"\n\tItems left in Stack: {employeeStack.Count}");
            }

            Console.WriteLine("\n\t---------------------------------------------------------------");

            // Lägg till alla objekt igen
            for (int i = 1; i <= 5; i++)
            {
                Employee emp = new Employee
                {
                    ID = i,
                    Name = $"Employee{i}",
                    Gender = i % 2 == 0 ? "Male" : "Female",
                    Salary = 50000 + i * 10000
                };

                employeeStack.Push(emp);
            }

            Console.WriteLine("\n\tPeek at items in Stack:");
            Console.WriteLine($"\n\tID: {employeeStack.Peek().ID}, Name: {employeeStack.Peek().Name}, " +
                $"Gender: {employeeStack.Peek().Gender}, Salary: {employeeStack.Peek().Salary}" +
                $"\n\tItems left in Stack: {employeeStack.Count}");

            Console.WriteLine($"\n\tID: {employeeStack.Peek().ID}, Name: {employeeStack.Peek().Name}, " +
                $"Gender: {employeeStack.Peek().Gender}, Salary: {employeeStack.Peek().Salary}" +
                $"\n\tItems left in Stack: {employeeStack.Count}");

            // Check if item number 3 is in Stack
            Console.WriteLine($"\n\tIs item number 3 in Stack? {employeeStack.Contains(employeeStack.ToArray()[2])}");

            Console.WriteLine("\n\t---------------------------------------------------------------");

            // Del 2 - List
            List<Employee> employeeList = new List<Employee>();

            // Lägg till fem objekt i List
            for (int i = 1; i <= 5; i++)
            {
                Employee emp = new Employee
                {
                    ID = i,
                    Name = $"Employee{i}",
                    Gender = i % 2 == 0 ? "Male" : "Female",
                    Salary = 50000 + i * 10000
                };

                employeeList.Add(emp);
            }

            // Kollar ifall Employee2 finns i listan
            if (employeeList.Contains(new Employee { ID = 2, Name = "Employee2", Gender = "Male", Salary = 70000 }))
            {
                Console.WriteLine("\n\tEmployee2 object exist in the list");
            }
            else
            {
                Console.WriteLine("\n\tEmployee2 object does not exist in the list");
            }

            // Hittar och skriver ut första objektet som är "Male"
            Employee maleEmployee = employeeList.Find(emp => emp.Gender == "Male");
            Console.WriteLine($"\n\tID: {maleEmployee.ID}, Name: {maleEmployee.Name}, Gender: {maleEmployee.Gender}, Salary: {maleEmployee.Salary}");

            // Hittar och skriver ut alla objektet som är "Male"
            List<Employee> maleEmployees = employeeList.FindAll(emp => emp.Gender == "Male");
            Console.WriteLine("\n\tAll Male Employees found:");
            foreach (var emp in maleEmployees)
            {
                Console.WriteLine($"\n\tID: {emp.ID}, Name: {emp.Name}, Gender: {emp.Gender}, Salary: {emp.Salary}");
            }
            Console.ReadKey();
        }
    }
}
