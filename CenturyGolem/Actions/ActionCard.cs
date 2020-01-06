using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CenturyGolem
{
    abstract class ActionCard
    {
        private Dictionary<Gem, int> mPlacedGems = new Dictionary<Gem, int>();
        private Boolean mPlayed = false;

        public abstract string GetDescription();
    }

    class GemCard : ActionCard
    {
        private Dictionary<Gem, int> mGems = new Dictionary<Gem, int>();

        public GemCard(Dictionary<Gem, int> gems)
        {
            mGems = gems;
        }
        public override string GetDescription()
        {
            return Tools.GemString(mGems);
        }
    }

    class UpgradeCard : ActionCard
    {
        private int mCount; 

        public UpgradeCard(int count)
        {
            mCount = count;
        }

        public override string GetDescription()
        {
            return " of " + mCount;
        }
    }

    class TradeCard : ActionCard
    {
        private Dictionary<Gem, int> mGemReqs = new Dictionary<Gem, int>();
        private Dictionary<Gem, int> mGems = new Dictionary<Gem, int>();

        public TradeCard(Dictionary<Gem, int> reqs, Dictionary<Gem, int> gems)
        {
            mGemReqs = reqs;
            mGems = gems;
        }

        public override string GetDescription()
        {
            return Tools.GemString(mGemReqs) + " ==> " + Tools.GemString(mGems);
        }
    }

}
