using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CenturyGolem
{
    abstract class ActionCard
    {
        public Dictionary<Gem, int> PlacedGems = new Dictionary<Gem, int>();
        public Boolean Played = false;

        public ActionCard()
        {
            Tools.InitGems(PlacedGems);
        }


        public abstract string GetDescription();

        internal void PlaceGem(Gem gem)
        {
            PlacedGems[gem]++;
        }

        protected string GetPlacedGemsString()
        {
           if (Tools.TotalGemCount(PlacedGems) == 0)
           {
               return "";
           }

            return " (placed gems: " + Tools.GemString(PlacedGems) + ")";
        }
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
            return Tools.GemString(mGems) + GetPlacedGemsString();
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
            return "of " + mCount + GetPlacedGemsString();
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
            return Tools.GemString(mGemReqs) + " ==> " + Tools.GemString(mGems) + GetPlacedGemsString();
        }
    }

}
