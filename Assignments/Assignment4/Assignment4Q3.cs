using System.Collections;

namespace Assignment4
{
    internal class Assignment4Q3
    {
        static void Main3()
        {
            int i = 0;
            Dictionary<int, Employee2> emp = new Dictionary<int, Employee2>();
            while (true)
            {
                Console.WriteLine("Do you want to add Employee");
                string s = Console.ReadLine();
                if (s != "yes")
                {
                    break;
                }
                Employee2 emp2 = new Employee2();
                Console.WriteLine("Enter your name: ");
                emp2.Name = Console.ReadLine();
                Console.WriteLine("Enter Employee Number: ");
                emp2.EmpNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Basic: ");
                emp2.Basic = Convert.ToInt32(Console.ReadLine());
                i++;
                emp.Add(i, emp2);
            }

            foreach(KeyValuePair<int, Employee2> entry in emp)
            {
                Console.WriteLine(entry.Key);
                Console.WriteLine(entry.Value.Name + " " + entry.Value.EmpNo
                    + " " + entry.Value.Basic);
                Console.WriteLine();
            }
            int highSalary = 0;
            Employee2 highSalaryEmployee = null;
            foreach (KeyValuePair<int, Employee2> entry in emp)
            {
                if (entry.Value.Basic > highSalary)
                {
                    highSalary = entry.Value.Basic;
                    highSalaryEmployee = entry.Value;
                }
            }
            if (highSalaryEmployee != null)
            {
                Console.WriteLine("Employee with highest salary: ");
                Console.WriteLine(highSalaryEmployee.Name + " " + highSalaryEmployee.EmpNo
                    + " " + highSalaryEmployee.Basic);
            }
            Console.WriteLine("Enter Employee number to search");
            int emNo = Convert.ToInt32(Console.ReadLine());
            Employee2 empSearch = null;
            foreach (KeyValuePair<int, Employee2> entry in emp)
            {
                if (entry.Value.EmpNo == emNo)
                {
                    empSearch = entry.Value;
                }
            }
            if (empSearch != null)
            {
                Console.WriteLine($"Employee with emp number {emNo}: ");
                Console.WriteLine(empSearch.Name + " " + empSearch.EmpNo
                    + " " + empSearch.Basic);
            }
        }
    }

    internal class Employee2()
    {
        public string? Name { get; set; }
        public int EmpNo { get; set; }
        public int Basic { get; set; }
    }
}
