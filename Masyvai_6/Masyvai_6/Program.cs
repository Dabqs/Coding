using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masyvai_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rowsArray = TableRowsInput();
            int colCount = DetermineNumberOfTableColumns(rowsArray);

            string[,] minesweeperTable = PopulateMineField(rowsArray, colCount);
            PrintOutTheTable(minesweeperTable);
        }
        static string CountMines()
        {

        }
        static string[,] MinesMapArray(string[,] minesweeperTable, int colCount, int rowsCount)
        {
            string[,] minesMapArray = new string[rowsCount,colCount];
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (minesweeperTable[i,j] == "*")
                    {
                        minesMapArray[i, j] = "#";
                    }
                    else
                    {
                        
                    }
                }

            }
        }
        static void PrintOutTheTable(string[,] minesweeperTable)
        {
            for (int i = 0; i < minesweeperTable.GetLength(0); i++)
            {
                for (int j = 0; j < minesweeperTable.GetLength(1); j++)
                {
                    Console.Write(minesweeperTable[i, j]);
                }
                Console.WriteLine();
            }
        }
        static string[] TableRowsInput()
        {
            string rowInput = string.Empty;
            string[] rowsArray = new string[1];
            for (int i = 0; true; i++)
            {
                Console.WriteLine("Enter a row to the table: dot (.) represents an empty field, asterix (*) stands for a mine. If you want to finish, press ESC.");
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    return rowsArray;
                }
                rowInput = Console.ReadLine();
                rowInput = RemoveInvalidChars(rowInput);
                Array.Resize(ref rowsArray, i + 1);
                rowsArray[i] = rowInput;
            }
        }
        static int DetermineNumberOfTableColumns(string[] rowsArray)
        {
            int shortestRow = int.MaxValue;
            foreach (string row in rowsArray)
            {
                if (row.Length < shortestRow)
                {
                    shortestRow = row.Length;
                }
            }
            return shortestRow;
        }
        static string[,] PopulateMineField(string[] rowsArray, int columnsCount)
        {
            string[,] minesweeperTable = new string[rowsArray.Length, columnsCount];

            for (int i = 0; i < rowsArray.Length; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    if (j < rowsArray[i].Length)
                    {
                        minesweeperTable[i, j] = rowsArray[i][j].ToString();
                    }
                    else
                    {
                        minesweeperTable[i, j] = ".";
                    }
                }
            }
            return minesweeperTable;
        }

        static string RemoveInvalidChars(string input)
        {
            string cleanedString = string.Empty;
            foreach (char symbol in input)
            {
                if (symbol != '.' && symbol != '*')
                {
                    continue;
                }
                cleanedString = cleanedString + symbol.ToString();
            }
            return cleanedString;
        }
    }
}

