using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LasVega.Entity
{
    public class Battle
    {
        public Player CurrentPlayer { get; private set; }
        public Opponent CurrentOpponent { get; private set; }

        public Battle(Player player, Opponent opponent)
        {
            CurrentPlayer = player;
            CurrentOpponent = opponent;
        }


    }
}
