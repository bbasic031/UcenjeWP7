using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class CircularMatrix
    {
        public static void Generate()
        {
            string another = "";
            int rows = 0, columns = 0;
            int[,] matrix;
            string startingPosition = "";
            string orientation = "";
            string firstMove = "";
            do
            {
                Console.WriteLine("Number of rows: ");
                try
                {
                    rows = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please write a number!");
                }

                Console.WriteLine("Number of columns: ");
                try
                {
                    columns = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please write a number!");
                }

                matrix = new int[rows, columns];

                Console.WriteLine("Where would you like your matrix to start? (write top left, top right, bottom left, bottom right, or middle)");
                try
                {
                    startingPosition = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Please write one of the given answers");
                }


                Console.WriteLine("What orientation would you like the matrix to move in? (write clockwise, or counterclockwise)");
                try
                {
                    orientation = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Please write one of the given answers");
                }
                if (startingPosition == "middle")
                {
                    Console.WriteLine("What side would you like the matrix to start on? (write left, right, up, or down)");
                    try
                    {
                        firstMove = Console.ReadLine();
                    }
                    catch
                    {
                        Console.WriteLine("Please write one of the given answers");
                    }
                }



                Console.WriteLine("Would you like to create a new matrix? (write NE if not)");
                try
                {
                    another = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Please write an answer!");
                }
            } while (another != "NE");
        }

        static int[,] CreateMatrix(int rows, int columns, string startingPosition, string orientation)
        {
            int[,] matrix = new int[rows, columns];
            if (startingPosition == "top left")
            {
                matrix[0, 0] = 1;
            }
            else if (startingPosition == "top right")
            {
                matrix[0, columns] = 1;
            }
            else if (startingPosition == "top left")
            {
                matrix[rows, 0] = 1;
            }
            else if (startingPosition == "bottom right")
            {
                matrix[rows, columns] = 1;
            }
            else
            {
                matrix[rows / 2, columns / 2] = 1;
            }
            if (orientation == "clockwise"&&startingPosition!="middle")
            {
                for (int i = 0; i < rows; i++)
                {

                }

            }
        }
    }
}
