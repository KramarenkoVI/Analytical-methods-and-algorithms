using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Set
{
    public class Set<T> : AbstractSet<T>
    {
        private T[] _items;
        private int _count;

        public Set()
        {
            _items = new T[4];
            _count = 0;
        }

        public override void Add(T item)
        {
            try
            {
                if (Contains(item)) return;

                if (_count == _items.Length)
                    ResizeArray(_items.Length * 2);

                _items[_count++] = item;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! [Set_Add]: {ex.ToString()}");
            }
        }

        public override void Remove(T item)
        {
            try
            {
                int index = IndexOf(item);
                if (index == -1) return;

                for (int i = index; i < _count - 1; i++)
                    _items[i] = _items[i + 1];

                _count--;

                if (_count > 0 && _count == _items.Length / 4)
                    ResizeArray(_items.Length / 2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! [Set_Remove]: {ex.ToString()}");
            }
        }

        public override bool Contains(T item)
        {
            return IndexOf(item) != -1;
        }

        public override void UnionWith(AbstractSet<T> other)
        {
            try
            {
                for (int i = 0; i < other.Size(); i++)
                {
                    T item = ElementAt(i);
                    Add(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! [UnionWith]: {ex.ToString()}");
            }
        }

        public override void IntersectWith(AbstractSet<T> other)
        {
            try
            {
                for (int i = 0; i < _count; i++)
                {
                    if (!other.Contains(_items[i]))
                    {
                        Remove(_items[i]);
                        i--;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! [IntersectWith]: {ex.ToString()}");
            }
        }

        public override bool IsEmpty()
        {
            return _count == 0;
        }

        public override int Size()
        {
            return _count;
        }

        #region Helpers
        public T ElementAt(int index)
        {
            try
            {
                if (index < 0 || index >= _count)
                    throw new IndexOutOfRangeException("Индекс вне диапазона.");
                return _items[index];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return default;
            }
        }

        private int IndexOf(T item)
        {
            try
            {
                for (int i = 0; i < _count; i++)
                {
                    if (Equals(_items[i], item))
                        return i;
                }
                return -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return -1;
            }
        }

        private void ResizeArray(int newSize)
        {
            T[] newArray = new T[newSize];
            Array.Copy(_items, newArray, _count);
            _items = newArray;
        }
        #endregion
    }
}
