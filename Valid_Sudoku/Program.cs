﻿using System;
using System.Collections.Generic;

namespace Valid_Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] board =
            {
                new char[] {'1', '3', '.', '.', '7', '.', '.', '.', '4'},
                new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
            };
            Console.WriteLine(1/3 + " pppp " + 2/3);
            Console.WriteLine(IsValidSudoku(board));
        }

        public static bool IsValidSudoku(char[][] board)
        {
            HashSet<string> map = new HashSet<string>();
            
            for (int row = 0; row < board.Length; row++)
            {
                for (int column = 0; column < board.Length; column++)
                {
                    char number = board[row][column];
                    if (number == '.')
                    {
                        continue;
                    }

                    if (!map.Add($"{number} at row {row}") || 
                        !map.Add($"{number} at column {column}") || 
                        !map.Add($"{number} at subbox {row / 3} {column / 3} "))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}