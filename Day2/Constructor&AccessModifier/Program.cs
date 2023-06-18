using System.Runtime.Serialization;
using System.Security.Cryptography;

namespace Constructor_AccessModifier
{
    internal class Program
    {
        static void Main1()
        {
            Class1 o = new Class1();
            Console.WriteLine(o.P1 + " " + o.P2 + " " + o.P3);
        }
    }

    public class Class1
    {
        public Class1()
        {
            Console.WriteLine("No param cons called");
            P1 = 10;
            P2 = 20;
            P3 = 30;
        }
        public Class1(int p1, int p2, int p3)
        {
            Console.WriteLine("Param cons called");
            this.P1 = p1;
            this.P2 = p2;
            this.P3 = p3;
        }
        public Class1(int p1, int p2)
        {
            Console.WriteLine("Param cons called");
            this.P1 = p1;
            this.P2 = p2;
            this.P3 = 450;
        }
        public Class1(int p1)
        {
            Console.WriteLine("Param cons called");
            this.P1 = p1;
            this.P2 = 220;
            this.P3 = 330;
        }

        public int P1 { get; set; }
        public int P2 { get; set; }
        public int P3 { get; set; }
    }
}

namespace ConstructorAndObjectInitializer
{
    internal class Program
    {
        static void Main()
        {
            Class1 o = new Class1();
            Console.WriteLine(o.P1);

            Class1 o2 = new Class1();
            o2.P1 = 10;
            o2.P2 = 20;
            o2.P3 = 30;
            Console.WriteLine(o2.P1);
            Console.WriteLine(o2.P2);
            Console.WriteLine(o2.P3);

            // Object initializer
            Class1 o3 = new Class1() { P1 = 10, P2 = 20, P3 = 30};
            Class1 o4 = new Class1{ P1 = 10, P2 = 20,P3 = 30}; 
        }
    }
    public class Class1
    {
        public int P1 { get; set; }
        public int P2 { get; set; }
        public int P3 { get; set; }
    }
}