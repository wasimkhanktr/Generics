using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Maximum<T>
    {
        public T FindMax(T a, T b, T c)
        {
            if (Comparer<T>.Default.Compare(a, b) > 0 && Comparer<T>.Default.Compare(a, c) > 0)
                return a;
            else if (Comparer<T>.Default.Compare(b, c) > 0 && Comparer<T>.Default.Compare(b, c) > 0)
                return b;
            else
                return c;
        }

    }
}