using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Plov
{
    class Pan
    { 
        private Onion[] onion;
        private Meat[] meat;
        private Carrot[] carrot;
        private Rice[] rice;
        //  private Water[] water;
        private Water  water;
        private Salt salt;
        private Oil oil;

        public void Init_Onion (int countOnion)
        {
            onion = new Onion[countOnion];
        }

        public void Init_Meat(int countMeat)
        {
            meat = new Meat[countMeat];
        }

        public void Init_Rice(int countRice)
        {
            rice = new Rice[countRice];
        }

        public void Init_Carrot(int countCarrot)
        {
            carrot = new Carrot[countCarrot];
        }

     

        public void AddOnion (Onion o)
        {
            for (int i = 0; i < onion.Length; i++)
            {
                if (onion[i] == null)
                {
                    onion[i] = o;
                    return;
                }
            }
        }

        public void AddCarrot(Carrot c)
        {
            for (int i = 0; i < carrot.Length; i++)
            {
                if (carrot[i] == null)
                {
                    carrot[i] = c;
                    return;
                }
            }
        }

        public void AddMeat(Meat m)
        {
            for (int i = 0; i < meat.Length; i++)
            {
                if (meat[i] == null)
                {
                    meat[i] = m;
                    return;
                }
            }
        }

        public void AddRice(Rice r)
        {
            for (int i = 0; i <rice.Length; i++)
            {
                if (rice[i] == null)
                {
                   rice[i] = r;
                    return;
                }
            }
        }

        public void AddWater(Water w)
        {
        
            water = w;
        }

        public void AddSalt(Salt s)
        {
            salt = s;
        }

        public void AddOil(Oil o)
        {
            oil = o;
        }

        public bool Check1 ()
        {
            if (meat== null)
            {
                return false;
            }
           if (meat.Length==0) {
                return false;
            }

            if (onion == null)
            {
                return false;
            }
            if (onion.Length == 0)
            {
                return false;
            }


            for (int m = 0; m < meat.Length; ++m)
            {
                if (meat[m] == null)
                    return false;
            }

            for (int o = 0; o < onion.Length; ++o)
            {
                if (onion[o] == null)
                    return false;
            }

            if (salt == null)
                return false;

            if (oil == null)
                return false;

            return true; 

        }

        public bool Check2 ()
        {

            if (water == null)
                return false;

            for (int r = 0; r < rice.Length; ++r)
            {
                if (rice[r] == null)
                    return false;
            }

            //if (salt == null)
            //    return false;

            //if (oil == null)
            //    return false;

            return true;
        }

        public void Cook()
        {
            if (Check2())
            {
                for (int r = 0; r < rice.Length; r++)
                {
                    rice[r].Cook();
                }

            }
            else
            {
                return;
            }
            if (Check1())
            {
                for (int m = 0; m < meat.Length; m++)
                {
                    meat[m].Cook();
                }
                for (int c = 0; c < carrot.Length; c++)
                {
                    carrot[c].Cook();
                }
                for (int o = 0; o < onion.Length; o++)
                {
                    onion[o].Cook();
                }
            }
            else
            {

                return;
            }
          
        }


    }
}
