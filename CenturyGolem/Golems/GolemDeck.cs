using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CenturyGolem
{
    class GolemDeck : Deck<GolemCard>
    {
        public void Init()
        {
            mCards.Clear();

                       
            mCards.Add(new GolemCard(6, Tools.ToGems(2, 2, 0, 0)));
            mCards.Add(new GolemCard(7, Tools.ToGems(3, 2, 0, 0)));
            mCards.Add(new GolemCard(8, Tools.ToGems(2, 3, 0, 0)));
            mCards.Add(new GolemCard(8, Tools.ToGems(0, 4, 0, 0)));
            mCards.Add(new GolemCard(8, Tools.ToGems(2, 0, 2, 0)));
            mCards.Add(new GolemCard(9, Tools.ToGems(2, 1, 0, 1)));
            mCards.Add(new GolemCard(9, Tools.ToGems(3, 0, 2, 0)));
            mCards.Add(new GolemCard(10, Tools.ToGems(0, 5, 0, 0)));
            mCards.Add(new GolemCard(10, Tools.ToGems(2, 0, 0, 2)));
            mCards.Add(new GolemCard(10, Tools.ToGems(0, 2, 2, 0)));
            mCards.Add(new GolemCard(11, Tools.ToGems(2, 0, 3, 0)));
            mCards.Add(new GolemCard(11, Tools.ToGems(3, 0, 0, 2)));
            mCards.Add(new GolemCard(12, Tools.ToGems(0, 2, 0, 2)));
            mCards.Add(new GolemCard(12, Tools.ToGems(0, 2, 1, 1)));
            mCards.Add(new GolemCard(12, Tools.ToGems(0, 3, 2, 0)));
            mCards.Add(new GolemCard(12, Tools.ToGems(1, 1, 1, 1)));
            mCards.Add(new GolemCard(12, Tools.ToGems(0, 0, 4, 0)));
            mCards.Add(new GolemCard(12, Tools.ToGems(1, 0, 2, 1)));
            mCards.Add(new GolemCard(13, Tools.ToGems(0, 2, 3, 0)));
            mCards.Add(new GolemCard(13, Tools.ToGems(2, 2, 2, 0)));
            mCards.Add(new GolemCard(14, Tools.ToGems(0, 0, 2, 2)));
            mCards.Add(new GolemCard(14, Tools.ToGems(2, 0, 0, 3)));
            mCards.Add(new GolemCard(14, Tools.ToGems(3, 1, 1, 1)));
            mCards.Add(new GolemCard(14, Tools.ToGems(0, 0, 3, 2)));
            mCards.Add(new GolemCard(15, Tools.ToGems(0, 0, 4, 0)));
            mCards.Add(new GolemCard(15, Tools.ToGems(2, 2, 0, 2)));
            mCards.Add(new GolemCard(16, Tools.ToGems(0, 2, 0, 3)));
            mCards.Add(new GolemCard(16, Tools.ToGems(1, 3, 1, 1)));
            mCards.Add(new GolemCard(16, Tools.ToGems(0, 0, 0, 4)));
            mCards.Add(new GolemCard(17, Tools.ToGems(0, 0, 3, 2)));
            mCards.Add(new GolemCard(17, Tools.ToGems(2, 0, 2, 2)));
            mCards.Add(new GolemCard(18, Tools.ToGems(0, 2, 0, 3)));
            mCards.Add(new GolemCard(18, Tools.ToGems(1, 1, 3, 1)));
            mCards.Add(new GolemCard(19, Tools.ToGems(0, 2, 2, 2)));
            mCards.Add(new GolemCard(20, Tools.ToGems(0, 0, 0, 5)));
            mCards.Add(new GolemCard(20, Tools.ToGems(1, 1, 1, 3)));

            Shuffle();
        }
    }
}
