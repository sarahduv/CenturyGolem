using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CenturyGolem
{
    class Table
    {
        private const int FaceUpActionCount = 1; //6;
        private const int FaceUpGolemCount = 1; // 5;

        private ActionDeck mActionDeck = new ActionDeck();
        private GolemDeck mGolemDeck = new GolemDeck();
        private List<ActionCard> mActionFaceUp = new List<ActionCard>();
        private List<GolemCard> mGolemFaceUp = new List<GolemCard>();
        private int mCopperCoins;
        private int mSilverCoins;

        internal void PrintState()
        {
            Console.WriteLine("Table State:");
            Console.WriteLine("  Golem deck cards: {0}   Action deck cards: {1}", mGolemDeck.Count(), mActionDeck.Count());
            Console.WriteLine("  Copper coins: {0}   Silver coins: {1}", mCopperCoins, mSilverCoins);
            Console.WriteLine("  Actions Facing Up:");
            foreach (var action in mActionFaceUp)
            {
                Console.WriteLine("    {0} {1} ",
                  action.GetType().Name,
                  action.GetDescription()
                );
            }
            Console.WriteLine("  Golems Facing Up:");
            foreach (var golem in mGolemFaceUp)
            {
                Console.WriteLine("    {0}", golem.GetDescription());
            }
        }

        public void Init(int numOfPlayers)
        {
            mActionFaceUp.Clear();
            mGolemFaceUp.Clear();
            mCopperCoins = numOfPlayers * 2;
            mSilverCoins = numOfPlayers * 2;
            mActionDeck.Init();
            mGolemDeck.Init();

            for (int i = 0; i < FaceUpActionCount; ++i) 
            { 
                mActionFaceUp.Add(mActionDeck.GetNextCard());
            }

            for (int i = 0; i < FaceUpGolemCount; ++i)
            {
                mGolemFaceUp.Add(mGolemDeck.GetNextCard());
            }
        }
    }
}
