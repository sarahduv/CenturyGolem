using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        internal static void InitGems(Dictionary<Gem, int> gems)
        {
            gems[Gem.Yellow] = 0;
            gems[Gem.Green] = 0;
            gems[Gem.Blue] = 0;
            gems[Gem.Pink] = 0;
        }

        public static string CoinString(Dictionary<Coin, int> coins)
        {
            string str = "";

            int count;
            if (coins.TryGetValue(Coin.Copper, out count) && count > 0)
                str += count + "C";
            else if (coins.TryGetValue(Coin.Silver, out count) && count > 0)
                str += count + "S";

            return str;
        }

        public static string GemString(Dictionary<Gem, int> gems)
        {
            string str = "";

            int count;
            if (gems.TryGetValue(Gem.Yellow, out count) && count > 0)
                str += count + "Y";
            if (gems.TryGetValue(Gem.Green, out count) && count > 0)
                str += count + "G";
            if (gems.TryGetValue(Gem.Blue, out count) && count > 0)
                str += count + "B";
            if (gems.TryGetValue(Gem.Pink, out count) && count > 0)
                str += count + "P";

            return str;
        }

        internal static int TotalGemCount(Dictionary<Gem, int> gems)
        {
            int num = 0;
            foreach (var gemCount in gems.Values)
            {
                num += gemCount;
            }
            return num;
        }

        internal static void AbsorbGems(Dictionary<Gem, int> target, Dictionary<Gem, int> source)
        {
            target[Gem.Yellow] += source[Gem.Yellow];
            target[Gem.Green] += source[Gem.Green];
            target[Gem.Blue] += source[Gem.Blue];
            target[Gem.Pink] += source[Gem.Pink];
        }
    }
}
