using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CenturyGolem
{
    public class Deck<T>
    {
        protected List<T> mCards = new List<T>();

        public int Count()
        {
            return mCards.Count;
        }

        protected void Shuffle()
        {
            mCards = mCards.OrderBy(a => Guid.NewGuid()).ToList();
        }

        public T GetNextCard()
        {
            if (mCards.Count == 0)
            {
                return default(T);
            }

            var next = mCards[0];
            mCards.RemoveAt(0);
            return next;
        }
    }
}
