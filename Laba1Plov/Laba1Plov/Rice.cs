using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Plov
{
    class Rice
    {

        private bool dirty = true;
        public bool Dirty { set { dirty = value; } get { return dirty; } }

        private int ready;
        public int Ready { get { return ready; } }

        public void Cook()
        {
            if (Ready < 10)
            {
                ready++;

            }
        }
    }
}
