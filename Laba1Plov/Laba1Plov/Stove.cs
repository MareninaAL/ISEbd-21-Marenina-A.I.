using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Plov
{
    class Stove
    {

        private bool state_stove;
        private Pan pan;


        public bool State
        {
            set  { state_stove = value; }
            get { return state_stove; }
        }

        public Pan Pan { set { pan = value; } get { return pan; } }

        public void Cooking()
        {
              pan.Cook();
        }
     

    }
}
