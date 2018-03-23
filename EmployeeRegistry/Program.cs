using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegistry
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            do
            {

                Console.Write("Name: ");
                string name = Console.ReadLine();
                if (name == "") {
                    break;
                }

                

                Console.Write("Salary: ");
                string salaryAsString = Console.ReadLine();
                int salary = 0;
                int.TryParse(salaryAsString, out salary);
                
                //Employee e = new Employee();
                //e.Name = name;
                //e.SetSalary(salary);
                //e.Salary = salary;
                //e.Salary -= 500;
                employees.Add(new Employee(name, salary));

            } while (true);

            Console.WriteLine("We have " + employees.Count + " employees");
            foreach (Employee employee in employees)
            {                
                Console.WriteLine();
                Console.WriteLine("Employee:");
                Console.WriteLine(employee.Name);
                Console.WriteLine(employee.Salary);
            }
        }
    }


    class Employee
    {
        //public Employee() { }
        public Employee(string name, int salary) {
            Name = name;
            Salary = salary;
        }

        public string Name { get; set; }


        private int salary;
        public int Salary {
            get {
                return salary;
            }
            set
            {
                salary = Math.Max(value, 0);
            }
        }

        //public int GetSalary()
        //{
        //    return salary;
        //}

        //public void SetSalary(int s)
        //{
        //    if (s >= 0)
        //    {
        //        salary = s;
        //    }
        //}

        //public void ChangeSalary(int difference) {
        //    SetSalary(GetSalary() + difference);
        //}
    }
}
