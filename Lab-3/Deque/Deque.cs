using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Deque
{
    public class Deque<T> : AbstractDeque<T>
    {
        private Node<T> _head;
        private Node<T> _tail;
        private int _count;

        public Deque()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }

        public override void AddFirst(T item)
        {
            try
            {
                Node<T> newNode = new Node<T>(item);

                if (IsEmpty())
                {
                    _head = _tail = newNode;
                }
                else
                {
                    newNode.Next = _head;
                    _head.Previous = newNode;
                    _head = newNode;
                }

                _count++;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! [AddFirst]: {ex.ToString()}");
            }
        }

        public override void AddLast(T item)
        {
            try
            {
                Node<T> newNode = new Node<T>(item);

                if (IsEmpty())
                {
                    _head = _tail = newNode;
                }
                else
                {
                    newNode.Previous = _tail;
                    _tail.Next = newNode;
                    _tail = newNode;
                }

                _count++;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! [AddLast]: {ex.ToString()}");
            }
        }

        public override T RemoveFirst()
        {
            try
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Дек пуст.");

                T value = _head.Value;
                _head = _head.Next;

                if (_head == null)
                {
                    _tail = null;
                }
                else
                {
                    _head.Previous = null;
                }

                _count--;
                return value;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.ToString());
                return default;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! [RemoveFirst]: {ex.ToString()}");
                return default;
            }
        }

        public override T RemoveLast()
        {
            try
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Дек пуст.");

                T value = _tail.Value;
                _tail = _tail.Previous;

                if (_tail == null)
                {
                    _head = null;
                }
                else
                {
                    _tail.Next = null;
                }

                _count--;
                return value;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.ToString());
                return default;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! [RemoveLast]: {ex.ToString()}");
                return default;
            }
        }

        public override T PeekFirst()
        {
            try
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Дек пуст.");

                return _head.Value;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.ToString());
                return default;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! [PeekFirst]: {ex.ToString()}");
                return default;
            }
        }

        public override T PeekLast()
        {
            try
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Дек пуст.");

                return _tail.Value;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.ToString());
                return default;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! [PeekLast]: {ex.ToString()}");
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
    }

    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }
    }
}
