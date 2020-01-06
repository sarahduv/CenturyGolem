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

        public Player(int index)
        {
            mIndex = index;
            initGems(index);

            mActions.Add(new UpgradeCard(2));
            mActions.Add(new GemCard(Tools.ToGems(2, 0, 0, 0)));
        }

        private void initGems(int index)
        {
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

        internal void PrintState()
        {
            Console.WriteLine("Player " + mIndex + ":");
            Console.WriteLine("Gems: " + Tools.GemString(mGems));
            Console.WriteLine("Coins: " + Tools.CoinString(mCoins));
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
