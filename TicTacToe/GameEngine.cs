using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class GameEngine
    {
        public void StartGame(string[,] TicTacToeBoard)
        {
            var player1 = string.Empty;
            var player2 = string.Empty;

            InitializeBoard(TicTacToeBoard);

            ChoosePlayer(ref player1, ref player2);

            PlayGame(TicTacToeBoard, player1, player2);
        }

        private void ChoosePlayer(ref string player1, ref string player2)
        {
            Console.WriteLine("Player1, Do you want to be X or O?");
            while (true)
            {
                player1 = Console.ReadLine().ToUpper();

                if (player1.ToUpper().Equals("X") || player1.ToUpper().Equals("O")) break;
            }
            player2 = player1.ToUpper().Equals("X") ? "O" : "X";
        }

        private void InitializeBoard(string[,] ticTacToeBoard)
        {
            for (int i = 0; i < ticTacToeBoard.GetLength(0); i++)
            {
                for (int j = 0; j < ticTacToeBoard.GetLength(0); j++)
                {
                    ticTacToeBoard[i, j] = " ";
                }
            }
        }
}
