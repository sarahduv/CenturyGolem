using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CenturyGolem
{
    class GolemCard
    {
        private int mPoints;
        private Dictionary<Gem, int> mGemReqs = new Dictionary<Gem, int>();

        public GolemCard(int points, Dictionary<Gem, int> reqs)
        {
            mPoints = points;
            mGemReqs = reqs;
        }

        public Dictionary<Gem, int> GemReqs
        {
            get { return mGemReqs; }
        }

        internal string GetDescription()
        {
            return Tools.GemString(mGemReqs) + " for " + mPoints + " points";
        }
    }

}
