using MyNameSpace;

namespace BasicClassConcepts
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            Console.WriteLine("This is string");


        }

        static void Main()
        {
            //Class1 o;  //o is a reference of type Class1
            //o = new Class1(); //new Class1() is an object of Class1. o refers to the object.
            Class1 o;
            o = new Class1();
            o.Display();
            o.Display("Abhijeet");

            // positional parameters
            Console.WriteLine(o.Add());
            Console.WriteLine(o.Add(5, 10));
            Console.WriteLine(o.Add(5, 12));
            Console.WriteLine(o.Add(5, 10, 30));

            // named parameters
            Console.WriteLine(o.Add(b:5, a:10));
            Console.WriteLine(o.Add(b:5, c:10, a:25));

            o.DoSomething();
        }
    }
}

namespace MyNameSpace
{
    public class Class1
    {
        public void Display()
        {
            Console.WriteLine("Class1 Called");
        }
        // func overloading
        public void Display(string name)
        {
            Console.WriteLine("Hello!! " + name);
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a=0, int b = 0, int c=0)
        {
            return a + b + c;
        }
        public void DoSomething()
        {
            int j = 12;
            int i = 100;
            Console.WriteLine("ds");
            // local func
            // local func can only be called from within the defining function
            // implicitly private 

            void DoSomething2()
            {
                // local func can access variable defined in the calling function
                Console.WriteLine(++i);

                void DoSomethingDifferent()
                {
                    Console.WriteLine(--i);
                }
                DoSomethingDifferent();
            }
            Console.WriteLine(i);
            DoSomething2();
        }
    }


    // to do - try to overload a local func (Not Possible)
    // try to have a local func inside another local func (Possible)
}