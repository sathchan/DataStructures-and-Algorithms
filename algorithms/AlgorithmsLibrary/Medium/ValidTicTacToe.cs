using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class ValidTicTacToe
    {
        public bool Main(int[,] board, int boardMatrix)
        {
            //Row check
            for (int i = 0; i < board.GetLength(0); i++)
            {
                int rowsum = 0;
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    rowsum += board[i, j];
                }

                if (Math.Abs(rowsum) == boardMatrix) return false;
            }

            //Column check
            for (int j = 0; j < board.GetLength(1); j++)
            {
                int colsum = 0;
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    colsum += board[i, j];
                }

                if (Math.Abs(colsum) == boardMatrix) return false;
            }

            //Diagonal check
            int diagsum = 0;
            for (int i = 0, j = 0; i < board.GetLength(0) && j < board.GetLength(1); i++, j++)
            {
                diagsum += board[i, j];
                if (Math.Abs(diagsum) == boardMatrix) return false;
            }

            //AntiDiagonal check
            int antisum = 0;
            for (int i = 0, j = board.GetLength(1) - 1; j >= 0 && i < board.GetLength(0); i++, j--)
            {
                antisum += board[i, j];
                if (Math.Abs(antisum) == boardMatrix) return false;
            }

            //entire board filled check
            int boardCompletion = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 0) break;
                }

                boardCompletion++;
            }

            if (boardCompletion == boardMatrix) return false;

            return true;
        }


        public bool TicTacToe(String[] board)
        {
            int turns = 0;
            bool xwin = false;
            bool owin = false;
            int[] rows = new int[3];
            int[] cols = new int[3];
            int diag = 0;
            int antidiag = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i][j] == 'X')
                    {
                        turns++; rows[i]++; cols[j]++;
                        if (i == j) diag++;
                        if (i + j == 2) antidiag++;
                    }
                    else if (board[i][j] == 'O')
                    {
                        turns--; rows[i]--; cols[j]--;
                        if (i == j) diag--;
                        if (i + j == 2) antidiag--;
                    }
                }
            }

            xwin = rows[0] == 3 || rows[1] == 3 || rows[2] == 3 ||
                   cols[0] == 3 || cols[1] == 3 || cols[2] == 3 ||
                   diag == 3 || antidiag == 3;
            owin = rows[0] == -3 || rows[1] == -3 || rows[2] == -3 ||
                   cols[0] == -3 || cols[1] == -3 || cols[2] == -3 ||
                   diag == -3 || antidiag == -3;

            if (xwin && turns == 0 || owin && turns == 1)
            {
                return false;
            }
            return (turns == 0 || turns == 1) && (!xwin || !owin);
        }
    }
}
