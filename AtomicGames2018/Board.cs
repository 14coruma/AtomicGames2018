﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtomicGames2018
{
    class Board
    {
        public int myPlayersTurn;
        public bool myGameOver;
        public int myWinner;

        /// Empty constructor - creates a new game board
        public Board()
        {
            myPlayersTurn = 1;
            myGameOver = false;
            myWinner = 0;
        }

        /// Copy constructor - creates a copy of a game board
        public Board(Board b)
        {
            myPlayersTurn = b.myPlayersTurn;
            myGameOver = b.myGameOver;
            myWinner = b.myWinner;
        }

        /// Makes a move, returns legalMove()
        public bool makeMove(int pos)
        {
            return false;
        }

        /// Checks and returns if a move is legal
        public bool legalMove(int pos)
        {
            return false;
        }

        /// Checks for game over conditions,
        /// returns value of the winning player
        public int gameOver()
        {
            return 0;
        }
    }
}
