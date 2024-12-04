#define Presentation //(Debug or Presentation)

using System.Reflection;
using System.Runtime.CompilerServices;

namespace Lab_1
{
    internal class Program
    {
        private static bool binarySearchInfo { get; set; } = false;
        private static int binarySearchSteps { get; set; } = 0;
        private static int _target = 69;
        static void Main(string[] args)
        {
            //Настройка консоли
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;

            Program lab = new Program();

            binarySearchInfo = false;
            binarySearchSteps = 0;

            //Создание массивов ( вместимостью от 100 до 1000 с шагом 100)
            int[] arr100 = lab.ArrayCreate(100);
            int[] arr200 = lab.ArrayCreate(200);
            int[] arr300 = lab.ArrayCreate(300);
            int[] arr400 = lab.ArrayCreate(400);
            int[] arr500 = lab.ArrayCreate(500);
            int[] arr600 = lab.ArrayCreate(600);
            int[] arr700 = lab.ArrayCreate(700);
            int[] arr800 = lab.ArrayCreate(800);
            int[] arr900 = lab.ArrayCreate(900);
            int[] arr1000 = lab.ArrayCreate(1000);

            Console.WriteLine("\n--LINEAR SEARCH x100--");
            Console.WriteLine(lab.LinearSearch(arr100, _target));
            Console.WriteLine("\n--BINARY SEARCH x100--");
            Console.WriteLine(lab.BinarySearch(arr100, _target, 0, arr100.Length-1));
            Console.WriteLine("\n--INTERPOLATION SEARCH x100--");
            Console.WriteLine(lab.InterpolationSearch(arr100, _target));

            Console.WriteLine("\n--LINEAR SEARCH x200--");
            Console.WriteLine(lab.LinearSearch(arr200, _target));
            Console.WriteLine("\n--BINARY SEARCH x200--");
            Console.WriteLine(lab.BinarySearch(arr200, _target, 0, arr200.Length - 1));
            Console.WriteLine("\n--INTERPOLATION SEARCH x200--");
            Console.WriteLine(lab.InterpolationSearch(arr200, _target));

            Console.WriteLine("\n--LINEAR SEARCH x300--");
            Console.WriteLine(lab.LinearSearch(arr300, _target));
            Console.WriteLine("\n--BINARY SEARCH x300--");
            Console.WriteLine(lab.BinarySearch(arr300, _target, 0, arr300.Length - 1));
            Console.WriteLine("\n--INTERPOLATION SEARCH x300--");
            Console.WriteLine(lab.InterpolationSearch(arr300, _target));

            Console.WriteLine("\n--LINEAR SEARCH x400--");
            Console.WriteLine(lab.LinearSearch(arr400, _target));
            Console.WriteLine("\n--BINARY SEARCH x400--");
            Console.WriteLine(lab.BinarySearch(arr400, _target, 0, arr400.Length - 1));
            Console.WriteLine("\n--INTERPOLATION SEARCH x400--");
            Console.WriteLine(lab.InterpolationSearch(arr400, _target));

            Console.WriteLine("\n--LINEAR SEARCH x500--");
            Console.WriteLine(lab.LinearSearch(arr500, _target));
            Console.WriteLine("\n--BINARY SEARCH x500--");
            Console.WriteLine(lab.BinarySearch(arr500, _target, 0, arr500.Length - 1));
            Console.WriteLine("\n--INTERPOLATION SEARCH x500--");
            Console.WriteLine(lab.InterpolationSearch(arr500, _target));

            Console.WriteLine("\n--LINEAR SEARCH x600--");
            Console.WriteLine(lab.LinearSearch(arr600, _target));
            Console.WriteLine("\n--BINARY SEARCH x600--");
            Console.WriteLine(lab.BinarySearch(arr600, _target, 0, arr600.Length - 1));
            Console.WriteLine("\n--INTERPOLATION SEARCH x600--");
            Console.WriteLine(lab.InterpolationSearch(arr600, _target));

            Console.WriteLine("\n--LINEAR SEARCH x700--");
            Console.WriteLine(lab.LinearSearch(arr700, _target));
            Console.WriteLine("\n--BINARY SEARCH x700--");
            Console.WriteLine(lab.BinarySearch(arr700, _target, 0, arr700.Length - 1));
            Console.WriteLine("\n--INTERPOLATION SEARCH x700--");
            Console.WriteLine(lab.InterpolationSearch(arr700, _target));

            Console.WriteLine("\n--LINEAR SEARCH x800--");
            Console.WriteLine(lab.LinearSearch(arr800, _target));
            Console.WriteLine("\n--BINARY SEARCH x800--");
            Console.WriteLine(lab.BinarySearch(arr800, _target, 0, arr800.Length - 1));
            Console.WriteLine("\n--INTERPOLATION SEARCH x800--");
            Console.WriteLine(lab.InterpolationSearch(arr800, _target));

            Console.WriteLine("\n--LINEAR SEARCH x900--");
            Console.WriteLine(lab.LinearSearch(arr900, _target));
            Console.WriteLine("\n--BINARY SEARCH x900--");
            Console.WriteLine(lab.BinarySearch(arr900, _target, 0, arr900.Length - 1));
            Console.WriteLine("\n--INTERPOLATION SEARCH x900--");
            Console.WriteLine(lab.InterpolationSearch(arr900, _target));

            Console.WriteLine("\n--LINEAR SEARCH x1000--");
            Console.WriteLine(lab.LinearSearch(arr1000, _target));
            Console.WriteLine("\n--BINARY SEARCH x1000--");
            Console.WriteLine(lab.BinarySearch(arr1000, _target, 0, arr1000.Length - 1));
            Console.WriteLine("\n--INTERPOLATION SEARCH x1000--");
            Console.WriteLine(lab.InterpolationSearch(arr1000, _target));

        }
        #region Search Methods
        private string LinearSearch(int[] data, int target)
        {
            try
            {
                int steps = 0;
#if Debug
                Console.WriteLine("\nUnsorted array: ");
                string array = string.Empty;
                for (int i=0; i<data.Length; i++)
                {
                    array += $"{data[i]} | ";
                }

                Console.WriteLine(array);
#endif

                for (int i = 0; i < data.Length; i++)
                {
                    steps++;

                    if (data[i] == target)
                        return $"\nLinear Search - Target found!\nPosition:{i}\nSteps: {steps}";
                }
                return $"\nLinear Search[404] Target not found!\nSteps: {steps}";
            }
            catch (Exception ex)
            {
                return $"\nERROR in Linear Search! {ex.Message}\n\n{ex.StackTrace}";
            }
        }

        private string BinarySearch(int[] data, int target, int firstElement, int lastElement)
        {
            try
            {
#if Debug
                if (!binarySearchInfo)
                {
                    Console.WriteLine("\nUnsorted array: ");
                    string uArray = string.Empty;
                    string sArray = string.Empty;
                    for (int i = 0; i < data.Length; i++)
                    {
                        uArray += $"{data[i]} | ";
                    }
                    Console.WriteLine(uArray);
                    QuickSort(data, 0, data.Length-1);

                    Console.WriteLine("\nSorted array: ");
                    for (int i = 0; i < data.Length; i++)
                    {
                        sArray += $"{data[i]} | ";
                    }
                    Console.WriteLine(sArray);
                    binarySearchInfo = true;
                }
#endif

#if Presentation
                QuickSort(data, 0, data.Length - 1);
#endif

                binarySearchSteps++;

                if (firstElement > lastElement)
                    return $"\nBinary Search[404] Target not found!\nSteps: {binarySearchSteps}";

                int middle = (firstElement + lastElement) / 2;
                int middleElement = data[middle];

                if (middleElement == target)
                    return $"\nBinary Search - Target found!\nPosition:{data[middle]}\nSteps: {binarySearchSteps}";
                else
                {
                    if (middleElement > target)
                        return BinarySearch(data, target, firstElement, middle - 1);
                    else
                        return BinarySearch(data, target, middle + 1, lastElement);
                }
            }
            catch (Exception ex)
            {
                return $"ERROR in Binary Search! {ex.Message}\n\n{ex.StackTrace}";
            }
        }

        private string InterpolationSearch(int[] data, int target)
        {
            try
            {
                int steps = 0;
#if Debug
                string uArray = string.Empty;
                string sArray = string.Empty;
                Console.WriteLine("\nUnsorted array: ");
                for (int i = 0; i < data.Length; i++)
                {
                    uArray += $"{data[i]} | ";
                }

                Console.WriteLine(uArray);
                QuickSort(data, 0, data.Length - 1);

                Console.WriteLine("\nSorted array: ");
                for (int i = 0; i < data.Length; i++)
                {
                    sArray += ($"{data[i]} | ");
                }
                Console.WriteLine(sArray);
#endif

#if Presentation
                QuickSort(data, 0, data.Length - 1);
#endif


                int startIndex = 0;
                int FihishIndex = data.Length - 1;

                while (startIndex <= FihishIndex && target >= data[startIndex] && target <= data[FihishIndex])
                {
                    steps++;
                    if (startIndex == FihishIndex)
                    {
                        if (data[startIndex] == target) 
                            return $"Interpolation Search - Target found!\nPosition:{data[startIndex]}\nSteps: {steps}";

                        return $"Interpolation Search[404] Target not found!\nSteps: {steps}";
                    }

                    //Формула интерполяционного поиска
                    int pos = startIndex + ((target - data[startIndex]) * (FihishIndex - startIndex)) / (data[FihishIndex] - data[startIndex]);
                    if (data[pos] == target)
                        return $"Interpolation Search - Target found!\nPosition:{pos}\nSteps: {steps}";

                    if (data[pos] < target)
                        startIndex = pos + 1;
                    else
                        FihishIndex = pos - 1;
                }

                return $"Interpolation Search[404] Target not found!\nSteps: {steps}";
            }
            catch (Exception ex)
            {
                return $"ERROR in Interpolation Search! {ex.Message}\n\n{ex.StackTrace}";
            }
        }
#endregion

        #region Sort Methods
        private void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);
                QuickSort(array, left, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, right);
            }
        }
        #endregion

        #region Helpers
        private int[] ArrayCreate(int length)
        {
            int[] data = new int[length];

            Random random = new Random();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(data.Length);
            }

            return data;
        }

        private int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, right);
            return i + 1;
        }

        private void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        #endregion
    }
}
