using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structurydanychprojekt2
{
    public class PriorityQueue<T>
    {
        private QueueElement<T> head = new QueueElement<T>();
        private QueueElement<T> tail;
        public int Count { get; set; }
        public PriorityQueue()
        {
            this.Count = 0;
        }

        public void Push(T Value, int Prio)
        {
            QueueElement<T> NewElement = new QueueElement<T>(Value, Prio);
            QueueElement<T> R = new QueueElement<T>();
            if(head == null)
            {
                head = NewElement;
                tail = NewElement;
            }
            else if(head.Prio < Prio)
            {
                NewElement.Next = head;
                head = NewElement;
            }
            else
            {
                    R = head;
                    while(R.Next != null && R.Next.Prio >= Prio)
                    {
                        R = R.Next;
                    }
                    NewElement.Next = R.Next;
                    R.Next = NewElement;
                    if (NewElement.Next == null)
                        tail = NewElement;
            }
            Count++;
        }

        public void RemoveFirst()
        {
            QueueElement<T> NewElement = new QueueElement<T>();
            if (head == null)
                return;
            NewElement = head;
            head = head.Next;
            if (head == null)
                tail = head;
            NewElement = null;
        }
        
        public T FindMin()
        {
            QueueElement<T> NewElement = new QueueElement<T>();
            QueueElement<T> TempElement = new QueueElement<T>();
            NewElement = head;
            TempElement = head.Next;
            while(TempElement.Next != null)
            {
                if (TempElement.Prio < NewElement.Prio)
                    NewElement = TempElement;
                TempElement = TempElement.Next;
            }
            return NewElement.Value;
        }
        public void removeMin()
        {
            QueueElement<T> NewElement = new QueueElement<T>();
            QueueElement<T> TempElement = new QueueElement<T>();
            NewElement = head;
            TempElement = head.Next;
            while (TempElement.Next != null)
            {
                if (TempElement.Prio < NewElement.Prio)
                    NewElement = TempElement;
                TempElement = TempElement.Next;
                //TempElement = null;
            }
            TempElement = head;
            while (true)
            {
                if (TempElement.Next == NewElement)
                {
                    TempElement.Next = NewElement.Next;
                    NewElement = null;
                    break;
                }
                TempElement = TempElement.Next;
                    //NewElement = null;
            }
            //TempElement = null;
            Count--;
        }
        public void Print()
        {
            QueueElement<T> P;
            P = head;
            while(P.Next != null)
            {
                Console.WriteLine("{0}",P.Value);
                P = P.Next;
            }
        }
        public bool IsEmpty()
        {
            if (head == null)
                return true;
            return false;
        }

        public T Get(int Numberofposition)
        {
            QueueElement<T> TempElement = new QueueElement<T>();
            TempElement = head;
            for (int i = 0; i < Numberofposition; i++)
            {
                TempElement = TempElement.Next;
                //tmp++;
            }
            return TempElement.Value;
        }
    }
}
