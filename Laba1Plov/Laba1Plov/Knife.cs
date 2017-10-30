using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Plov
{
    class Knife
    {

        public void Сut_onion(Onion o)
        {
            if (o.Has_Сut) o.Has_Сut = false;

        }

        public void Сut_carrot(Carrot c)
        {
            if (c.Has_Сut) c.Has_Сut = false;

        }

        public void Cut_meat(Meat m)
        {
            if (m.Has_Сut) m.Has_Сut = false;

        }
    }
}
