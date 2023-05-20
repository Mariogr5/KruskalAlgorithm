using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structurydanychprojekt2
{
    internal class QueueElement<T>
    {
        public QueueElement()
        {
            Next = null;
        }
        public QueueElement(T x, int prio)
        {
            this.Value = x;
            this.Next = null;
            this.Prio = prio;
        }
        public T Value { get; set; }
        public QueueElement<T> Next { get; set; }
        public int Prio { get; set; }
    }
}
