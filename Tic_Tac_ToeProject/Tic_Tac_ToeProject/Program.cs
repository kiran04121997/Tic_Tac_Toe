using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_ToeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic_Tac_Toe_Game");
            TicTacToeGame obj = new TicTacToeGame();
            obj.gameBoard();
            obj.abillityToInput();
            obj.showGameBoard();

            Console.ReadLine();
        }
    }
}
