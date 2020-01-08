using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CenturyGolem
{
    class GameAction
    {
        public string Description;
        public Action Action;

        public GameAction(string desc, Action act)
        {
            this.Description = desc;
            this.Action = act;
        }
    }
}
