using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structurydanychprojekt2
{
    public class Lista<T>
    {
            private Element<T> head;
            public Lista()
            {
                head = null;
            }
            public int Count()
            {
                int tmp = 0;
                Element<T> iterator = head;
                while (iterator != null)
                {
                    iterator = iterator.Next;
                    tmp++;
                }
                return tmp;
            }
            public void AddToFront(T number)
            {
                var newelement = new Element<T>(number);
                newelement.Next = head;
                head = newelement;
            }
            public void AddToEnd(T number)
            {
                var newelement = new Element<T>(number);
                if (Count() == 0)
                {
                    head = newelement;
                }
                else
                {
                    Element<T> iterator = head;
                    while (iterator.Next != null)
                    {
                        iterator = iterator.Next;
                    }
                    iterator.Next = newelement;
                }
            }
            public void AddBefore(T number, int numberofexistingelement)
            {
                if (Count() == 1)
                {
                    AddToFront(number);
                }
                else if (Count() == 0)
                {
                    AddToEnd(number);
                }
                else
                {
                    if (numberofexistingelement > Count())
                        return;
                    Element<T> newelement = new Element<T>(number);
                    Element<T> iterator = head;
                    for (int i = 0; i < numberofexistingelement - 2; i++)
                    {
                        iterator = iterator.Next;
                    }
                    newelement.Next = iterator.Next;
                    iterator.Next = newelement;
                }

            }
            public void AddAfter(T number, int numberofexistingelement)
            {
                if (Count() == 1)
                {
                    AddToEnd(number);
                }
                else if (Count() == 0)
                {
                    AddToEnd(number);
                }
                else
                {
                    if (numberofexistingelement > Count())
                        return;
                    Element<T> newelement = new Element<T>(number);
                    Element<T> iterator = head;
                    for (int i = 0; i < numberofexistingelement - 1; i++)
                    {
                        iterator = iterator.Next;
                    }
                    newelement.Next = iterator.Next;
                    iterator.Next = newelement;
                }
            }
            public void PrintList()
            {
                Element<T> iterator = head;
                while (iterator != null)
                {
                    Console.WriteLine(iterator.Value);
                    iterator = iterator.Next;
                }
            }
            public void DeleteFromFront()
            {
                if (Count() == 0)
                    return;
                head = head.Next;
            }
            public void DeleteFromEnd()
            {
                if (Count() == 0)
                    return;
                else if (Count() == 1)
                {
                    head = null;
                }
                else
                {
                    Element<T> iterator = head;
                    while (iterator.Next.Next != null)
                    {
                        iterator = iterator.Next;
                    }
                    iterator.Next = null;
                }
            }
            public void Delete(int numberofexistingelement)
            {
                if (Count() == 0)
                    return;
                if (Count() == 1)
                {
                    DeleteFromEnd();
                    return;

                }
                Element<T> iterator = head;
                for (int i = 0; i < numberofexistingelement - 2; i++)
                {
                    iterator = iterator.Next;
                }
                iterator.Next = iterator.Next.Next;
            }
            public bool isEmpty()
            {
                if (Count() == 0)
                    return true;
                else
                    return false;
            }

            public T Get(int Numberofposition)
            {
                //int tmp = -1;
                Element<T> iterator = head;
                for(int i = 0; i < Numberofposition; i++)
                {
                    iterator = iterator.Next;
                    //tmp++;
                } 
                return iterator.Value;
            }
        public void Set(int Numberofposition, T Value)
        {
            //int tmp = -1;
            Element<T> iterator = head;
            for (int i = 0; i < Numberofposition; i++)
            {
                iterator = iterator.Next;
                //tmp++;
            }
            iterator.Value = Value;
        }

        public int Name { get; set; }
        public T Next { get; set; }
        
    }
}
