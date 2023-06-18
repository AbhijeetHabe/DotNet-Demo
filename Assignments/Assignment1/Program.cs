using System.Net;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee o1 = new Employee();
            Employee o2 = new Employee(1,"Amol",12500,10);
            Employee o3 = new Employee(1, "Amol", 12500);
            Employee o4 = new Employee(1, "Amol");
            Employee o5 = new Employee(1);

            //Console.WriteLine(o1.Name, o1.EmpNo, o1.DeptNo, o1.Basic);
            Console.WriteLine(o2.Name + " " + o2.EmpNo+ " " + o2.DeptNo + " " + o2.Basic);
            Console.WriteLine(o3.Name + " " + o3.EmpNo + " " + o3.DeptNo + " " + o3.Basic);
            Console.WriteLine(o4.Name + " " + o4.EmpNo + " " + o4.DeptNo + " " + o4.Basic);
            //Console.WriteLine(o5.Name, o5.EmpNo, o5.DeptNo, o5.Basic);
        }
    }
    class Employee
    {
        private string name;
        private int empNo;
        private decimal basic;
        private short deptNo;
        public string Name { get; set; } 
        public int EmpNo { get; set; }
        public decimal Basic { get; set; }
        public short DeptNo { get; set; }

        public Employee(int empNo, string name, decimal basic, short deptNo) 
        {
            this.EmpNo = empNo;
            this.Name = name;
            this.Basic = basic;
            this.DeptNo = deptNo;
        }
        public Employee(int empNo, string name, decimal basic)
        {
            this.EmpNo = empNo;
            this.Name = name;
            this.Basic = basic;
        }
        public Employee(int empNo, string name)
        {
            this.EmpNo = empNo;
            this.Name = name;
        }
        public Employee(int empNo)
        {
            this.EmpNo = empNo;
        }
        //public Employee() {}
        public void getNetSalary()
        {
            decimal sal = basic * 12 * (decimal)0.5;
            Console.WriteLine(sal);
        }
    }
}