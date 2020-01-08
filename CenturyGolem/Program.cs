using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CenturyGolem
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            game.Init(2);
            while (!game.IsOver)
            {
                game.NextMove();
            }
        }
    }
}
