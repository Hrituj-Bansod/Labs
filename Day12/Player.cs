using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12
{
    internal record Player
    {
        public string Name { get; init; }
        public int Score { get; init; }
        public int Level { get; init; }

        // Constructor
        public Player(string name, int score, int level)
        {
            Name = name;
            Score = score;
            Level = level;
        }
    }

}
