using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Queue
{
    public abstract class AbstractQueue<T>
    {
        public abstract void Enqueue(T item);

        public abstract T Dequeue();

        public abstract T Peek();

        public abstract bool IsEmpty();

        public abstract int Size();
    }
}
