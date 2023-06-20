namespace Assignment4
{
    internal class Assignment4Q4
    {
        static void Main()
        {
            Employee3[] arr = new Employee3[2];

            for (int i = 0; i < arr.Length; i++)
            {
                Employee3 employee = new Employee3();
                Console.WriteLine("Enter your name: ");
                employee.Name = Console.ReadLine();
                Console.WriteLine("Enter Employee Number: ");
                employee.EmpNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Basic: ");
                employee.Basic = Convert.ToInt32(Console.ReadLine());
                arr[i] = employee;
            }
            List<Employee3> lst = new List<Employee3>();
            lst.AddRange(arr);

            Employee3[] arr2 = lst.ToArray();
            foreach (Employee3 emp in arr2)
            {
                Console.WriteLine(emp.Name + " " + emp.EmpNo + " " + emp.Basic);
                Console.WriteLine();
            }
        }
    }
    class Employee3()
    {
        public string? Name { get; set; }
        public int EmpNo { get; set; }
        public int Basic { get; set; }
    }
}
