using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturyGolem
{
    class Tools
    {
        public static Dictionary<Gem, int> ToGems(int yellow, int green, int blue, int pink)
        {
            return new Dictionary<Gem, int>()
            {
                {Gem.Yellow, yellow },
                {Gem.Green, green },
                {Gem.Blue, blue },
                {Gem.Pink, pink }
            };
        }
    }
}
