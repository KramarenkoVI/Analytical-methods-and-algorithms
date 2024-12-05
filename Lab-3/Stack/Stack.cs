using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Stack
{
    public class Stack<T> : AbstractStack<T>
    {
        private T[] _items;
        private int _count;
        private const int DefaultCapacity = 4;

        public Stack()
        {
            _items = new T[DefaultCapacity];
            _count = 0;
        }

        public override void Push(T item)
        {
            try
            {
                if (_count == _items.Length)
                {
                    Resize(_items.Length * 2);
                }
                _items[_count++] = item;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! [Push]: {ex.ToString()}");
            }
        }

        public override T Pop()
        {
            try
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Стек пуст.");

                T item = _items[--_count];
                _items[_count] = default;

                if (_count > 0 && _count == _items.Length / 4)
                {
                    Resize(_items.Length / 2);
                }

                return item;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.ToString());
                return default;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! [Pop]: {ex.ToString()}");
                return default;
            }
        }

        public override T Peek()
        {
            try
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Стек пуст.");
                return _items[_count - 1];
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.ToString());
                return default;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! [Peek]: {ex.ToString()}");
                return default;
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

        private void Resize(int newSize)
        {
            try
            {
                T[] newArray = new T[newSize];
                Array.Copy(_items, newArray, _count);
                _items = newArray;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! [Resize]: {ex.ToString()}");
            }
        }
    }
}
