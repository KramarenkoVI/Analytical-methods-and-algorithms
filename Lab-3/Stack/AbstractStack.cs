using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Stack
{
    public abstract class AbstractStack<T>
    {
        public abstract void Push(T item);

        public abstract T Pop();

        public abstract T Peek();

        public abstract bool IsEmpty();

        public abstract int Size();
    }
}
