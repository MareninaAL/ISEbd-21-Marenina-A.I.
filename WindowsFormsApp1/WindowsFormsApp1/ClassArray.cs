using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ClassArray<T> where T : IInstrument
    {
        private Dictionary<int, T> places;
        private int countMax;
        private T defaultValue;

        public ClassArray(int size, T defVal)
        {
            defaultValue = defVal;
            places = new Dictionary<int, T>();
            countMax = size;
        }

        public static int operator +(ClassArray<T> p, T Saxophone)
        {
            if (p.places.Count == p.countMax)
            {
                return -1;
            }
            for (int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p.places.Add(i, Saxophone);
                    return i;
                }
            }
            p.places.Add(p.places.Count, Saxophone);
            return p.places.Count - 1;
        }

        public static T operator -(ClassArray<T> p, int index)
        {
            if (p.places.ContainsKey(index))
            {
                T Saxophone = p.places[index];
                p.places.Remove(index);
                return Saxophone;
            }
            return p.defaultValue;

           
           
         
        }


        private bool CheckFreePlace(int index)
        {
           
            return !places.ContainsKey(index);
        }
        public T this[int ind]
        {
            get
            {
                if (places.ContainsKey(ind))
                {
                    return places[ind];
                }
                return defaultValue;
            }
        }
    }
}
