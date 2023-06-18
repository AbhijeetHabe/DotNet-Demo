namespace Assigment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee o1 = new Employee();
            Employee o2 = new Employee("Amol", 12500, 10);
            Employee o3 = new Employee("Amol", 12500);
            Employee o4 = new Employee("Amol");
            Employee o5 = new Employee();

            //Console.WriteLine(o1.Name, o1.EmpNo, o1.DeptNo, o1.Basic);
            Console.WriteLine(o2.Name + " " + o2.EmpNo + " " + o2.DeptNo + " " + o2.Basic);
            Console.WriteLine(o3.Name + " " + o3.EmpNo + " " + o3.DeptNo + " " + o3.Basic);
            Console.WriteLine(o4.Name + " " + o4.EmpNo + " " + o4.DeptNo + " " + o4.Basic);
            Console.WriteLine(o5.Name + " " + o5.EmpNo + " " + o5.DeptNo + " " + o5.Basic);
        }

        class Employee
        {
            private string name;
            private int empNo;
            private decimal basic;
            private short deptNo;
            private static int lastEmp;
            public string Name 
            { 
                get
                {
                    return name;
                } 
                set
                {
                    if (value == null)
                    {
                        Console.WriteLine("Invalid Name");
                    }
                    else
                    {
                        name = value;
                    }
                }
            }
            public int EmpNo 
            { 
                get { return empNo; }
            }
            public decimal Basic 
            {
                get 
                {
                    return basic;
                }
                set
                {
                    if (value > 11000)
                    {
                        basic = value;
                    }
                    else
                    {
                        Console.WriteLine("Basic must be greater than 11000");
                    }
                }
            }
            public short DeptNo
            {
                get
                {
                    return deptNo;
                }
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Invalid dept number");
                    }
                    else
                    {
                        deptNo = value;
                    }
                }
            }

            public Employee(string Name="No name", decimal Basic=12000, short DeptNo=10)
            {
                this.empNo = ++lastEmp;
                this.Name = Name;
                this.Basic = Basic;
                this.DeptNo = DeptNo;
            }
            
            public void getNetSalary()
            {
                decimal sal = basic * 12 * (decimal)0.5;
                Console.WriteLine(sal);
            }
        }
    }
}