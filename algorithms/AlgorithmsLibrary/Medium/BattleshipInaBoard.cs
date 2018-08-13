using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class BattleshipInaBoard
    {
        public int Main(char[,] board)
        {
            //Column check
            int columnCheck = 0;
            for(int i=0; i < board.GetLength(0) -1; i++)
            {
                for (int j = 0; j < board.GetLength(1) -1 ; j++)
                {
                    if (board[i,j] != board[i,j + 1] && board[i,j] != 'X') break;
                }

                columnCheck++;
            }

            //Row check
            int rowCheck = 0;
            for (int i = 0; i < board.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < board.GetLength(1) -1 ; j++)
                {
                    if (board[i, j] != board[i + 1, j] && board[i, j] != 'X') break;
                }

                rowCheck++;
            }

            //validate
            if (rowCheck > 0 || columnCheck > 0) return 0;

            return (rowCheck == 0)? columnCheck : rowCheck;
        }
    }
}
