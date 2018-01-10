using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ClassArray<T> :  IEnumerator<T>, IEnumerable<T>, IComparable<ClassArray<T>>
    {
        private int currentIndex;
        public T Current
        {
            get
            {
                return places[places.Keys.ToList()[currentIndex]];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {

        }
        public bool MoveNext()
        {
            if (currentIndex + 1 >= places.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;
        }
        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(ClassArray<T> other)
        {
            if (this.Count() > other.Count())
            {
                return -1;
            }
            else if (this.Count() < other.Count())
            {
                return 1;
            }
            else
            {
                var thisKeys = this.places.Keys.ToList();
                var otherKeys = other.places.Keys.ToList();
                for (int i = 0; i < this.places.Count(); ++i)
                {
                    if (this.places[thisKeys[i]] is Wind_Musical_Instrument && other.places[otherKeys[i]] is Saxophone)
                    {
                        return 1;
                    }
                    if (this.places[thisKeys[i]] is Saxophone && other.places[otherKeys[i]] is Wind_Musical_Instrument)
                    {
                        return -1;
                    }
                    if (this.places[thisKeys[i]] is Wind_Musical_Instrument && other.places[thisKeys[i]] is Wind_Musical_Instrument)
                    {
                        return (this.places[thisKeys[i]] is Wind_Musical_Instrument).CompareTo(other.places[thisKeys[i]] is Wind_Musical_Instrument);
                    }
                    if (this.places[thisKeys[i]] is Saxophone && other.places[thisKeys[i]] is Saxophone)
                    {
                        return (this.places[thisKeys[i]] is Saxophone).CompareTo(other.places[thisKeys[i]] is Saxophone);
                    }
                }

            }
            return 0;

        }
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
            var isSaxophone = Saxophone is Saxophone;
            if (p.places.Count == p.countMax)
            {
                throw new MagazineOverFlowException();
            }
            int index = p.places.Count;
            for (int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    index = i;
                }
                if (Saxophone.GetType() == p.places[i].GetType())
                {
                    if (isSaxophone)
                    {
                        if ((Saxophone as Saxophone).Equals(p.places[i]))
                        {
                            throw new MagazineAlreadyHaveException();

                        }

                    }
                    else if ((Saxophone as Saxophone).Equals(p.places[i]))
                    {
                        throw new MagazineAlreadyHaveException();
                    }
                }
            }
            if (index != p.places.Count)
            {
                p.places.Add(index, Saxophone);
                return index;
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
            throw new MagazineIndexOutOfRangeException();
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
