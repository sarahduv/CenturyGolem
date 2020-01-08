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
        private int mCurrentPlayer = 0;
        private bool mGameOver = false;

        internal void NextMove()
        {
            var player = mPlayers[mCurrentPlayer];

            List<GameAction> gameActions = new List<GameAction>();
            gameActions.Add(new GameAction("Quit game", () => { this.mGameOver = true; }));

            PrintState(gameActions);

            Console.WriteLine();
            Console.WriteLine("Actions you can take:");
            for (int i = 0; i < gameActions.Count; ++i)
            {
                Console.WriteLine(" [{0}] {1}", i, gameActions[i].Description);
            }

            bool validChoice = false;
            while (!validChoice)
            {
                int userChoice;
                if (int.TryParse(Console.ReadLine(), out userChoice) && userChoice >= 0 && userChoice < gameActions.Count)
                {
                    // then we have a valid choice for an action to play
                    validChoice = true;
                    gameActions[userChoice].Action();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid choice selected. Try again");
                }
            }

            mCurrentPlayer = (mCurrentPlayer + 1) % mPlayers.Count;
        }

        public bool IsOver { get { return mGameOver; } }

        public void Init(int numOfPlayers)
        {
            mGameOver = false;
            mCurrentPlayer = 0;

            mTable.Init(numOfPlayers);
            for (int i = 0; i < numOfPlayers; ++i)
            {
                mPlayers.Add(new Player(i, mTable));
            }
        }

        private void PrintState(List<GameAction> gameActions)
        {
            mTable.PrintState(gameActions);
            foreach (var player in mPlayers)
            {
                Console.WriteLine();
                player.PrintState(gameActions);
            }

            // Only for the current player, collect what it can do
            mPlayers[mCurrentPlayer].CollectActions(gameActions);
        }
    }

}
