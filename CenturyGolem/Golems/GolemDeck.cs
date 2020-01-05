using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CenturyGolem
{
    class GolemDeck
    {
        private List<GolemCard> mCards = new List<GolemCard>();

        public void Init()
        {
            mCards.Clear();

            mCards.Add(new GolemCard(8, Tools.ToGems(2, 3, 0, 0)));
            mCards.Add(new GolemCard(16, Tools.ToGems(0, 2, 0, 3)));
            mCards.Add(new GolemCard(6, Tools.ToGems(2, 2, 0, 0)));

            mCards = mCards.OrderBy(a => Guid.NewGuid()).ToList();
        }
    }
}
