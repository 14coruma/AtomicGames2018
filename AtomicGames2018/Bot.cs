using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtomicGames2018
{
    class Bot
    {
        Stopwatch stopwatch = new Stopwatch(); // Used for timing moves

        /// Find best move given a game Board object and time limit
        public int getMove(Board board, int timeLimit)
        {
            // Begin timing
            stopwatch.Reset();
            stopwatch.Start();

            // Iterate search depth until out of time...
            // ...or depth too far (meaning bot sees endgame)
            int depth = 0;
            int lastMove = -1;
            int move = -1;
            while (stopwatch.ElapsedMilliseconds < timeLimit && depth <= 100)
            {
                lastMove = move;
                move = alphabeta(board, depth, int.MinValue, int.MaxValue).item1;
                depth++;
            }

            return lastMove; // move may contain an uneducated decision
        }

        /// Alpha-beta algorithm
        public Tuple<int, int> alphabeta(Board board, int depth, int a, int b)
        {

        }
    }
}
