using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CenturyGolem
{
    class Player
    {
        private Dictionary<Gem, int> mGems = new Dictionary<Gem, int>();
        private Dictionary<Coin, int> mCoins = new Dictionary<Coin, int>();
        private List<GolemCard> mGolems = new List<GolemCard>();
        private List<ActionCard> mActions = new List<ActionCard>();
        private int mIndex;
        private Table mTable;

        public Player(int index, Table table)
        {
            mIndex = index;
            mTable = table;
            initGems(index);

            mActions.Add(new UpgradeCard(2));
            mActions.Add(new GemCard(Tools.ToGems(2, 0, 0, 0)));
        }

        private void initGems(int index)
        {
            Tools.InitGems(mGems);
            if (index == 0)
            {
                mGems[Gem.Yellow] = 3;
            }
            else if (index < 3)
            {
                mGems[Gem.Yellow] = 4;
            }
            else
            {
                mGems[Gem.Yellow] = 3;
                mGems[Gem.Green] = 1;
            }
        }

        internal void PrintState(List<GameAction> gameActions)
        {
            Console.Write("Player: " + mIndex + ", ");
            Console.Write("Gems: " + Tools.GemString(mGems) + ", ");
            Console.Write("Coins: " + Tools.CoinString(mCoins) + ", ");
            Console.WriteLine("Player actions:");
            foreach (var action in mActions)
            {
                Console.WriteLine("  {0} {1} ",
                  action.GetType().Name,
                  action.GetDescription()
                );
            }
            Console.WriteLine("Player Golems:");
            foreach (var golem in mGolems)
            {
                Console.WriteLine("  {0}", golem.GetDescription());
            }
        }

        internal void CollectActions(List<GameAction> gameActions)
        {
            gameActions.Add(new GameAction("Refresh ("+UsedActionCards+" used)", ActionRefresh));

            var actionCardsICanPickUp = 1 + TotalGemCount;
            for (int cost = 0; cost < actionCardsICanPickUp && cost < mTable.ActionsFaceUp.Count; ++cost)
            {
                var card = mTable.ActionsFaceUp[cost];
                gameActions.Add(new GameAction(
                    "Pickup card: " + card.GetDescription() + (cost > 0
                        ? " (costs "+ cost +" gems)"
                        : ""
                    ), 
                    () => { TakeCard(card); }
                ));
            }
        }

        private void TakeCard(ActionCard takenCard)
        {
            foreach (var tableCard in mTable.ActionsFaceUp)
            {
                if (tableCard == takenCard)
                {
                    break;
                } else
                {
                    // place gems
                    tableCard.PlaceGem(PopCheapestGem());
                }
            }

            mTable.ActionsFaceUp.Remove(takenCard);
            mTable.PlaceNewActionCard();

            // Absorb all the gems that were on the card
            Tools.AbsorbGems(mGems, takenCard.PlacedGems);

            // Put 0 in all the color of PlacedGems
            Tools.InitGems(takenCard.PlacedGems);

           
            mActions.Add(takenCard);
        }

        public Gem PopCheapestGem()
        {
            var colorOrder = new Gem[] { Gem.Yellow, Gem.Green, Gem.Blue, Gem.Pink };

            foreach (Gem color in colorOrder)
            {
                if (mGems[color] > 0)
                {
                    mGems[color]--;
                    return color;
                }
            }

            return Gem.None;
        }

        public int TotalGemCount
        {
            get
            {
                return Tools.TotalGemCount(mGems);
            }
        }

        public int UsedActionCards
        {
            get
            {
                int num = 0;
                foreach (var card in mActions)
                {
                    if (card.Played) num++;   
                }
                return num;
            }
        }

        private void ActionRefresh()
        {
            foreach (var card in mActions)
            {
                card.Played = false;
            }
        }
    }

    public enum Gem
    {
        None,
        Yellow,
        Green,
        Blue,
        Pink
    }

    public enum Coin
    {
        None,
        Copper,
        Silver
    }
}
