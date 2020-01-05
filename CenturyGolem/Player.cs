using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturyGolem
{
    class Player
    {
        private Dictionary<Gem, int> mGems = new Dictionary<Gem, int>();
        private Dictionary<Coin, int> mCoins = new Dictionary<Coin, int>();
        private List<GolemCard> mGolems = new List<GolemCard>();
        private List<ActionCard> mActions = new List<ActionCard>();
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
