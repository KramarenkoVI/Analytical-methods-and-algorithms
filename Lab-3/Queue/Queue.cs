using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Queue
{
    public class Queue<T> : AbstractQueue<T>
    {
        private Node<T> _head;
        private Node<T> _tail;
        private int _count;

        public Queue()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }

        public override void Enqueue(T item)
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
                    _tail.Next = newNode;
                    _tail = newNode;
                }

                _count++;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! [Enqueue]: {ex.ToString()}");
            }
        }

        public override T Dequeue()
        {
            try
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Очередь пуста.");

                T value = _head.Value;
                _head = _head.Next;

                if (_head == null)
                {
                    _tail = null;
                }

                _count--;
                return value;
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.ToString());
                return default;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! [Dequeue]: {ex.ToString()}");
                return default;
            }
        }

        public override T Peek()
        {
            try
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Очередь пуста.");

                return _head.Value;
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
    }

    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }
}
