using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.ValidSudoku
{
    public class Solution
    {
        public bool IsValidSudoku(char[][] board)
        {
            SudokuValidator sudokuValidator = new();

            // Loop row
            for (var row = 0; row < board.Length; row++)
            {
                // Loop col
                for (var col = 0; col < board.Length; col++)
                {
                    var value = GetBoardValue(row, col, board);

                    if (value == '.') continue;

                    if (!sudokuValidator.ValidateRow(row, value)
                        || !sudokuValidator.ValidateColumn(col, value)
                        || !sudokuValidator.ValidateBlock(row, col, value))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private char GetBoardValue(int row, int col, char[][] board)
        {
            return board[row][col];
        }
    }


    public class SudokuValidator
    {
        // Store the existingSet value
        private readonly HashSet<string> existingSet = new();

        public bool ValidateRow(int row, char value)
        {
            // ex : row-0-5, 代表第 0 行 5 已存在
            string key = $"row-{row}-{value}";

            if (existingSet.Contains(key))
            {
                return false;
            }

            existingSet.Add(key);

            return true;
        }

        public bool ValidateColumn(int col, char value)
        {
            // ex : col-0-5, 代表第 0 列 5 已存在
            string key = $"col-{col}-{value}";

            if (existingSet.Contains(key))
            {
                return false;
            }

            existingSet.Add(key);

            return true;
        }

        public bool ValidateBlock(int row, int col, char value)
        {
            int blockRow = row / 3;
            int blockCol = col / 3;

            // ex : block-0-0-5, 代表 (0,0) 區塊 5 已存在
            string key = $"block-{blockRow}-{blockCol}-{value}";

            if (existingSet.Contains(key))
            {
                return false;
            }

            existingSet.Add(key);

            return true;
        }
    }
}
