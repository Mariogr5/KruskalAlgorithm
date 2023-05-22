using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structurydanychprojekt2
{
    internal class Element<T>
    {
        public Element()
        {
            Next = null;
        }
        public Element(T x)
        {
            this.Value = x;
            this.Next = null;
        }
        public T Value;
        public Element<T> Next;
    }
}
