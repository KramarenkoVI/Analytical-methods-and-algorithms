using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class HeapSort
    {
        public void HeapSorting<T>(T[] array) where T : IComparable<T>
        {
            try
            {
                int n = array.Length;

                for (int i = n / 2 - 1; i >= 0; i--)
                {
                    Heapify(array, n, i);
                }

                for (int i = n - 1; i > 0; i--)
                {
                    Swap(array, 0, i);

                    Heapify(array, i, 0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Heapify<T>(T[] array, int n, int i) where T : IComparable<T>
        {
            try
            {
                int largest = i;
                int left = 2 * i + 1;
                int right = 2 * i + 2;

                if (left < n && array[left].CompareTo(array[largest]) > 0)
                {
                    largest = left;
                }

                if (right < n && array[right].CompareTo(array[largest]) > 0)
                {
                    largest = right;
                }

                if (largest != i)
                {
                    Swap(array, i, largest);

                    Heapify(array, n, largest);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        private void Swap<T>(T[] array, int i, int j)
        {
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
