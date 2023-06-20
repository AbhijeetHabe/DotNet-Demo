namespace Assignment4
{
    internal class Assignment4Q2
    {
        static void Main2()
        {
            Employee[] arr = new Employee[2];
            
            for (int i = 0; i < arr.Length; i++)
            {
                Employee employee = new Employee();
                Console.WriteLine("Enter your name: ");
                employee.Name = Console.ReadLine();
                Console.WriteLine("Enter Employee Number: ");
                employee.EmpNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Basic: ");
                employee.Basic = Convert.ToInt32(Console.ReadLine());
                arr[i] = employee;
            }

            foreach (Employee emp in arr)
            {
                Console.WriteLine(emp.Name + " " + emp.EmpNo + " " + emp.Basic);
                Console.WriteLine();
            }
        }
    }
    class Employee()
    {
        public string? Name { get; set; }
        public int EmpNo { get; set; }
        public int Basic { get; set; }
    }
}
