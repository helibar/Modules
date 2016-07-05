using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToeGame
    {
        int _row;
        int _col;
        Cell[,] _board = new Cell[3, 3];
        bool _player1 = true;

        public enum Cell
        {
            empty,
            X,
            O
        }

        public void Display()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_board[i, j].ToString() == "empty")
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write(" " + _board[i, j].ToString() + " ");
                    }

                }

                Console.WriteLine();
            }
        }

        public void SetMove(int row, int col)
        {
            _row = row;
            _col = col;
        }

        public string currentPlayer()
        {
            if (_player1)
            {
                return "Player 2";
            }
            return "Player 1";
        }

        public void Move()
        {
            if (isMoveLigal(_row, _col))
            {
                if (_player1)
                {
                    _board[_row, _col] = Cell.X;
                    _player1 = false;
                }
                else //player2
                {
                    _board[_row, _col] = Cell.O;
                    _player1 = true;
                }
            }

        }


        public bool isMoveLigal(int row, int col)
        {
            if (_board[row, col].ToString() == "empty")
            {
                return true;
            }
            Console.WriteLine("Ilegal move.");
            return false;
        }

        public int IsGameOver()
        {
            //Check is someone wins

            //Rows check
            //Winning For First Row
            if (_board[0, 0] == _board[0, 1] && _board[0, 1] == _board[0, 2] && (_board[0, 0] == Cell.X || _board[0, 0] == Cell.O))
            {
                return 1;
            }
            //Winning For Second Row   
            else if (_board[1, 0] == _board[1, 1] && _board[1, 1] == _board[1, 2] && (_board[1, 0] == Cell.X || _board[1, 0] == Cell.O))
            {
                return 1;
            }
            //Winning For Third Row   
            else if (_board[2, 0] == _board[2, 1] && _board[2, 1] == _board[2, 2] && (_board[2, 0] == Cell.X || _board[2, 0] == Cell.O))
            {
                return 1;
            }

            //Columns Check
            //Winning For First Col   
            else if (_board[0, 0] == _board[1, 0] && _board[1, 0] == _board[2, 0] && (_board[0, 0] == Cell.X || _board[0, 0] == Cell.O))
            {
                return 1;
            }
            //Winning For Second Col
            else if (_board[0, 1] == _board[1, 1] && _board[1, 1] == _board[2, 1] && (_board[0, 1] == Cell.X || _board[0, 1] == Cell.O))
            {
                return 1;
            }
            //Winning For Third Col   
            else if (_board[0, 2] == _board[1, 2] && _board[1, 2] == _board[2, 2] && (_board[0, 2] == Cell.X || _board[0, 2] == Cell.O))
            {
                return 1;
            }

            //Diagonal check
            else if (_board[0, 0] == _board[1, 1] && _board[1, 1] == _board[2, 2] && (_board[0, 0] == Cell.X || _board[0, 0] == Cell.O))
            {
                return 1;
            } 
            else if (_board[0, 2] == _board[1, 1] && _board[1, 1] == _board[2, 0] && (_board[0, 2] == Cell.X || _board[0, 2] == Cell.O))
            {
                return 1;
            }

            //Check Draw
            else if (_board[0, 0] != Cell.empty && _board[0, 1] != Cell.empty && _board[0, 2] != Cell.empty && _board[1, 0] != Cell.empty && _board[1, 1] != Cell.empty && _board[1, 2] != Cell.empty && _board[2, 0] != Cell.empty && _board[2, 1] != Cell.empty && _board[2, 2] != Cell.empty)
            {
                return -1;
            }
            else //Game is not over
            {
                return 0;
            }
        }

    }
}
