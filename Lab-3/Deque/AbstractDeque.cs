using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Deque
{
    public abstract class AbstractDeque<T>
    {
        public abstract void AddFirst(T item);

        public abstract void AddLast(T item);

        public abstract T RemoveFirst();

        public abstract T RemoveLast();

        public abstract T PeekFirst();

        public abstract T PeekLast();

        public abstract bool IsEmpty();

        public abstract int Size();
    }
}
