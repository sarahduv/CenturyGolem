using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CenturyGolem
{
    class GolemCard
    {
        private int mPoints;
        private Dictionary<Gem, int> mGemReq = new Dictionary<Gem, int>();

        public GolemCard(int points, Dictionary<Gem, int> reqs)
        {
            mPoints = points;
            mGemReq = reqs;
        }
    }

}
