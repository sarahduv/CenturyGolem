using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CenturyGolem
{
    class Table
    {
        private ActionDeck mActionsDeck = new ActionDeck();
        private GolemDeck mGolemDeck = new GolemDeck();
        private List<ActionCard> mActionFaceUp = new List<ActionCard>();
        private List<GolemCard> mGolemFaceUp = new List<GolemCard>();
        private int mCopperCoins;
        private int mSilverCoins;

        public void Init(int numOfPlayers)
        {
            mActionFaceUp.Clear();
            mGolemFaceUp.Clear();
            mCopperCoins = numOfPlayers * 2;
            mSilverCoins = numOfPlayers * 2;
            mActionsDeck.Init();
            mGolemDeck.Init();
        }
    }
}
