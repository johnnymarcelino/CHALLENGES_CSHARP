using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace CLG_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> employees = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split('\u002C');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        employees.Add(new Employee(name, email, salary));
                    }

                    var emails = employees.Where(obj => obj.Salary > limit).OrderBy(p => p.Email).Select(obj => obj.Email);

                    var sum = employees.Where(obj => obj.Name[0] == 'M').Sum(p => p.Salary);

                    Console.WriteLine("Email of people whose salary is more than " + limit.ToString("F2", CultureInfo.InvariantCulture));
                    foreach (string employee in emails)
                    {
                        Console.WriteLine(employee);
                    }

                    Console.WriteLine("Sum of salary of people whose starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
