using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> _heap;

        public PriorityQueue()
        {
            _heap = new List<T>();
        }

        public void Enqueue(T item)
        {
            try
            {
                _heap.Add(item);
                HeapifyUp(_heap.Count - 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public T Dequeue()
        {
            try
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Очередь пуста.");

                T root = _heap[0];
                _heap[0] = _heap[_heap.Count - 1];
                _heap.RemoveAt(_heap.Count - 1);
                HeapifyDown(0);
                return root;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return default;
            }
        }

        public T Peek()
        {
            try
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Очередь пуста.");

                return _heap[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return default;
            }
        }

        public bool IsEmpty()
        {
            return _heap.Count == 0;
        }

        public int Count
        {
            get { return _heap.Count; }
        }

        private void HeapifyUp(int index)
        {
            try
            {
                while (index > 0)
                {
                    int parentIndex = (index - 1) / 2;
                    if (_heap[index].CompareTo(_heap[parentIndex]) <= 0)
                        break;

                    Swap(index, parentIndex);
                    index = parentIndex;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void HeapifyDown(int index)
        {
            try
            {
                while (index < _heap.Count)
                {
                    int leftChild = 2 * index + 1;
                    int rightChild = 2 * index + 2;
                    int largest = index;

                    if (leftChild < _heap.Count && _heap[leftChild].CompareTo(_heap[largest]) > 0)
                    {
                        largest = leftChild;
                    }

                    if (rightChild < _heap.Count && _heap[rightChild].CompareTo(_heap[largest]) > 0)
                    {
                        largest = rightChild;
                    }

                    if (largest == index)
                        break;

                    Swap(index, largest);
                    index = largest;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Swap(int i, int j)
        {
            T temp = _heap[i];
            _heap[i] = _heap[j];
            _heap[j] = temp;
        }
    }
}
