using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CenturyGolem
{
    class ActionDeck : Deck<ActionCard>
    {
        public void Init()
        {
            mCards.Clear();

            mCards.Add(new UpgradeCard(3));

            mCards.Add(new GemCard(Tools.ToGems(0, 0, 1, 0)));
            mCards.Add(new GemCard(Tools.ToGems(0, 0, 0, 1)));
            mCards.Add(new GemCard(Tools.ToGems(1, 1, 0, 0)));
            mCards.Add(new GemCard(Tools.ToGems(0, 2, 0, 0)));
            mCards.Add(new GemCard(Tools.ToGems(1, 0, 1, 0)));
            mCards.Add(new GemCard(Tools.ToGems(3, 0, 0, 0)));
            mCards.Add(new GemCard(Tools.ToGems(2, 1, 0, 0)));
            mCards.Add(new GemCard(Tools.ToGems(4, 0, 0, 0)));

            mCards.Add(new TradeCard(Tools.ToGems(0, 0, 1, 0), Tools.ToGems(0, 2, 0, 0)));
            mCards.Add(new TradeCard(Tools.ToGems(0, 0, 0, 1), Tools.ToGems(0, 0, 2, 0)));
            mCards.Add(new TradeCard(Tools.ToGems(0, 1, 0, 0), Tools.ToGems(3, 0, 0, 0)));
            mCards.Add(new TradeCard(Tools.ToGems(0, 0, 1, 0), Tools.ToGems(1, 2, 0, 0)));
            mCards.Add(new TradeCard(Tools.ToGems(0, 0, 0, 1), Tools.ToGems(0, 0, 3, 0)));
            mCards.Add(new TradeCard(Tools.ToGems(0, 0, 0, 1), Tools.ToGems(1, 1, 1, 0)));
            mCards.Add(new TradeCard(Tools.ToGems(0, 0, 0, 1), Tools.ToGems(2, 2, 0, 0)));
            mCards.Add(new TradeCard(Tools.ToGems(0, 0, 0, 1), Tools.ToGems(3, 0, 1, 0)));
            mCards.Add(new TradeCard(Tools.ToGems(0, 0, 1, 0), Tools.ToGems(4, 1, 0, 0)));
            mCards.Add(new TradeCard(Tools.ToGems(2, 0, 0, 0), Tools.ToGems(0, 0, 1, 0)));
            mCards.Add(new TradeCard(Tools.ToGems(1, 1, 0, 0), Tools.ToGems(0, 0, 0, 1)));
            mCards.Add(new TradeCard(Tools.ToGems(0, 2, 0, 0), Tools.ToGems(0, 0, 2, 0)));
            mCards.Add(new TradeCard(Tools.ToGems(0, 0, 2, 0), Tools.ToGems(0, 0, 0, 2)));
            mCards.Add(new TradeCard(Tools.ToGems(2, 0, 0, 0), Tools.ToGems(0, 2, 0, 0)));
            mCards.Add(new TradeCard(Tools.ToGems(0, 0, 2, 0), Tools.ToGems(0, 2, 0, 1)));
            mCards.Add(new TradeCard(Tools.ToGems(0, 2, 0, 0), Tools.ToGems(2, 0, 0, 1)));
            mCards.Add(new TradeCard(Tools.ToGems(0, 0, 2, 0), Tools.ToGems(2, 1, 0, 1)));
            mCards.Add(new TradeCard(Tools.ToGems(0, 2, 0, 0), Tools.ToGems(3, 0, 1, 0)));
            mCards.Add(new TradeCard(Tools.ToGems(0, 0, 0, 2), Tools.ToGems(1, 1, 3, 0)));
            mCards.Add(new TradeCard(Tools.ToGems(0, 0, 2, 0), Tools.ToGems(2, 3, 0, 0)));
            mCards.Add(new TradeCard(Tools.ToGems(0, 0, 0, 2), Tools.ToGems(0, 3, 2, 0)));
            mCards.Add(new TradeCard(Tools.ToGems(0, 0, 3, 0), Tools.ToGems(0, 0, 0, 1)));
            mCards.Add(new TradeCard(Tools.ToGems(2, 0, 1, 0), Tools.ToGems(0, 0, 0, 2)));
            mCards.Add(new TradeCard(Tools.ToGems(3, 0, 0, 0), Tools.ToGems(0, 1, 1, 0)));
            mCards.Add(new TradeCard(Tools.ToGems(0, 3, 0, 0), Tools.ToGems(0, 0, 0, 2)));
            mCards.Add(new TradeCard(Tools.ToGems(0, 0, 3, 0), Tools.ToGems(0, 0, 0, 3)));
            mCards.Add(new TradeCard(Tools.ToGems(0, 3, 0, 0), Tools.ToGems(1, 0, 1, 1)));
            mCards.Add(new TradeCard(Tools.ToGems(3, 0, 0, 0), Tools.ToGems(0, 3, 0, 0)));
            mCards.Add(new TradeCard(Tools.ToGems(0, 3, 0, 0), Tools.ToGems(0, 0, 3, 0)));
            mCards.Add(new TradeCard(Tools.ToGems(0, 3, 0, 0), Tools.ToGems(2, 0, 2, 0)));
            mCards.Add(new TradeCard(Tools.ToGems(4, 0, 0, 0), Tools.ToGems(0, 0, 2, 0)));
            mCards.Add(new TradeCard(Tools.ToGems(4, 0, 0, 0), Tools.ToGems(0, 0, 1, 1)));
            mCards.Add(new TradeCard(Tools.ToGems(5, 0, 0, 0), Tools.ToGems(0, 0, 0, 2)));
            mCards.Add(new TradeCard(Tools.ToGems(5, 0, 0, 0), Tools.ToGems(0, 0, 3, 0)));



            Shuffle();
        }
    }
}
