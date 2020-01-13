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
        public Dictionary<Gem, int> GemsToAbsorb = new Dictionary<Gem, int>();

        public GemCard(Dictionary<Gem, int> gems)
        {
            GemsToAbsorb = gems;
        }
        public override string GetDescription()
        {
            return Tools.GemString(GemsToAbsorb) + GetPlacedGemsString();
        }
    }

    class UpgradeCard : ActionCard
    {
        public int UpgradeCount; 

        public UpgradeCard(int count)
        {
            UpgradeCount = count;
        }

        public override string GetDescription()
        {
            return "of " + UpgradeCount + GetPlacedGemsString();
        }
    }

    class TradeCard : ActionCard
    {
        public Dictionary<Gem, int> GemReqs = new Dictionary<Gem, int>();
        public Dictionary<Gem, int> GemsToAbsorb = new Dictionary<Gem, int>();

        public TradeCard(Dictionary<Gem, int> reqs, Dictionary<Gem, int> gems)
        {
            GemReqs = reqs;
            GemsToAbsorb = gems;
        }

        public override string GetDescription()
        {
            return Tools.GemString(GemReqs) + " ==> " + Tools.GemString(GemsToAbsorb) + GetPlacedGemsString();
        }
    }

}
