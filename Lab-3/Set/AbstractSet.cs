using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Set
{
    public abstract class AbstractSet<T>
    {
        public abstract void Add(T item);

        public abstract void Remove(T item);

        public abstract bool Contains(T item);

        public abstract void UnionWith(AbstractSet<T> other);

        public abstract void IntersectWith(AbstractSet<T> other);

        public abstract bool IsEmpty();

        public abstract int Size();
    }
}
