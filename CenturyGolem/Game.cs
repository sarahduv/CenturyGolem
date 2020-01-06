using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CenturyGolem
{
    class Game
    {
        private Table mTable = new Table();
        private List<Player> mPlayers = new List<Player>();

        public void Init(int numOfPlayers)
        {
            mTable.Init(numOfPlayers);
            for (int i = 0; i < numOfPlayers; ++i)
            {
                mPlayers.Add(new Player(i));
            }

            PrintState();
        }

        private void PrintState()
        {
            mTable.PrintState();
            foreach (var player in mPlayers)
            {
                Console.WriteLine();
                player.PrintState();
            }
        }
    }

}
