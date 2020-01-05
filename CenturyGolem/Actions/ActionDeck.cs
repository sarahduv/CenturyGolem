using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturyGolem
{
    class ActionDeck
    {
        private List<ActionCard> mCards = new List<ActionCard>();

        public void Init()
        {
            mCards.Clear();

            mCards.Add(new TradeCard(Tools.ToGems(0, 0, 1, 0), Tools.ToGems(1, 2, 0, 0)));
            mCards.Add(new GemCard(Tools.ToGems(1, 1, 0, 0)));
            mCards.Add(new UpgradeCard(3));
        }
    }
}
