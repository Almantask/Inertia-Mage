using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertiaMage.SpellEditor.Core
{
    //****
    // Homework: create an array of chars.
    // Print each elment of a row
    // Seperate rows with an empty line
    // First line should be a full line of first symbol of that line
    // Last line should be a full line of last symbol of that line
    // The center symbol of the matrix shoud be empty
    // Middle line should be empty
    //****
    public static class ArrayTest
    {
        public static void Test2dArray()
        {
            Console.WriteLine("---2d array test---");
            int[][] seats = new int[5][];
            seats[0] = new int[3];
            seats[1] = new int[3];
            seats[2] = new int[3];
            seats[3] = new int[3];
            seats[4] = new int[9];

            for (var rowIndex = 0; rowIndex < seats.Length ; rowIndex++)
            {
                var row = seats[rowIndex];
                for (var colIndex = 0; colIndex < row.Length; colIndex++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }
            Console.WriteLine("---2d array test---");
        }

        public static void JaggedArray()
        {
            Console.WriteLine("---Jagged array test---");
            int[,] seats = new int[5,5];

            for (var rowIndex = 0; rowIndex < seats.GetLength(0); rowIndex++)
            {
                for (var colIndex = 0; colIndex < seats.GetLength(1); colIndex++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.WriteLine("---Jagged array test---");
        }

    }
}
