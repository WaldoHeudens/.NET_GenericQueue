using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueue
{
    internal class Rij<T>
    {
        List<T> lijst = new List<T>();

        public void InRij(T toeTeVoegen)
        {
            lijst.Add(toeTeVoegen);
        }

        public T UitRij()
        {
            if (lijst.Count == 0)
                throw new StackOverflowException();
            T even = lijst[0];
            lijst.RemoveAt(0);
            return even;
        }
    }
}
