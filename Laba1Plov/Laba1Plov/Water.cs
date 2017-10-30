using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Plov
{
    class Water
    {
        private bool add = false;
        public bool GetAdd { set { add = value; } get { return add; } }

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
