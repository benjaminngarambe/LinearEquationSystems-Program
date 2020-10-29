using System;

namespace LinearEquationSystems_Program
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Type linear equations in augmented matrix notation: a1 a2... aN  d,\n where a1..N are coefficients and D is constant");
            //setting up the array to store the elements of the matrix
            Console.WriteLine("Enter the number of rows your matrix");
            int Row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of colums your matrix");
            int Col = Convert.ToInt32(Console.ReadLine());
            int i, j;
            int[,] arr1 = new int[10, 10];
            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < Row; i++)
            {
                for (j = 0; j < Col; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("The matrix is :\n");
            for (i = 0; i < Row; i++)
            {
                for (j = 0; j < Col; j++)
                    Console.Write("{0}  ", arr1[i, j]);
                Console.Write("\n");
            }
            MainProgram();
            void MainProgram()
            {
                LoopOfMainProgram();
            }
            void LoopOfMainProgram()
            {
                while (true)
                {
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Do you want to calculate another Equation? \n Type 'yes' or 'no'");
                    string answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        Console.Clear();
                        MainProgram();
                        break;
                    }
                    else if (answer == "no")
                    {
                        Environment.Exit(0);
                        break;
                    }
                    else Console.WriteLine("Wrong answer\n the number of equations is not equal to the number of variables ");
                }
            }
        }
    }
}