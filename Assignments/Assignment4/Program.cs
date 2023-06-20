namespace Assignment4
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.Write("Enter the number of batches: "); int numBatches = int.Parse(Console.ReadLine()); int[][] marks = new int[numBatches][];

            for (int i = 0; i < numBatches; i++)
            {
                Console.Write("Enter the number of students in batch " + (i + 1) + ":  ");

                int numStudents = int.Parse(Console.ReadLine()); marks[i] = new int[numStudents];

                for (int j = 0; j < numStudents; j++)
                {
                    Console.Write("Enter mark for student " + (j + 1) + " in batch "+ (i + 1) + ": ");
                    marks[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The marks are:"); for (int i = 0; i < numBatches; i++)
            {
                Console.Write("Batch " + (i + 1) + ": "); for (int j = 0; j < marks[i].Length; j++)
                {
                    Console.Write(marks[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }

}