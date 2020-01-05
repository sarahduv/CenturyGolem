using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturyGolem
{
    class ActionCard
    {
        private Dictionary<Gem, int> mPlacedGems = new Dictionary<Gem, int>();
        private Boolean mPlayed = false;
    }

    class GemCard : ActionCard
    {
        private Dictionary<Gem, int> mGems = new Dictionary<Gem, int>();

        public GemCard(Dictionary<Gem, int> gems)
        {
            mGems = gems;
        }
    }

    class UpgradeCard : ActionCard
    {
        private int mCount; 

        public UpgradeCard(int count)
        {
            mCount = count;
        }
    }

    class TradeCard : ActionCard
    {
        private Dictionary<Gem, int> mGemReq = new Dictionary<Gem, int>();
        private Dictionary<Gem, int> mGems = new Dictionary<Gem, int>();

        public TradeCard(Dictionary<Gem, int> reqs, Dictionary<Gem, int> gems)
        {
            mGemReq = reqs;
            mGems = gems;
        }
    }

}
