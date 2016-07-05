using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TicTacToe.TicTacToeGame;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new TicTacToeGame();

            Console.WriteLine("This is a TcTac game for 2 players. player 1 please begin...");
            game.Display();

            try
            {
                do
                {
                    Console.WriteLine("---------");
                    Console.WriteLine("Enter Row: ");
                    int row = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter Column: ");
                    int col = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("---------");

                    game.SetMove(row, col);
                    game.Move();
                    game.Display();

                } while (game.IsGameOver() == 0);


                if (game.IsGameOver() == 1)
                {
                    Console.WriteLine("Winner is " + game.currentPlayer());
                }
                else if (game.IsGameOver() == -1)
                {
                    Console.WriteLine("Game is over!");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
