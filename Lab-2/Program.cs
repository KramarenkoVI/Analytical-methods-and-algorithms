#define Debug //(Only Debug) ДЛЯ ПРОВЕРКИ РАССКОМЕНТИРОВАТЬ НЕОБХОДИМЫЕ ВЫЗОВЫ
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab_2
{
    internal class Program
    {
        private static bool MergeSortInputInfo {  get; set; }
        private static bool MergeSortOutputInfo { get; set; }
        private static int MergeSortSteps { get; set; }

        private static bool QuickSortInputInfo { get; set; }
        private static bool QuickSortOutputInfo { get; set; }
        private static int QuickSortSteps { get; set; }

        static void Main(string[] args)
        {
            //Настройка консоли
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;

            Program lab = new Program();

            //Создание массивов ( вместимостью от 100 до 1000 с шагом 100)
            #region Random Data
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
            #endregion

            #region Partial Sort Data
            int[] arr100partial = lab.PartialSortedArrayCreate(100);
            int[] arr200partial = lab.PartialSortedArrayCreate(200);
            int[] arr300partial = lab.PartialSortedArrayCreate(300);
            int[] arr400partial = lab.PartialSortedArrayCreate(400);
            int[] arr500partial = lab.PartialSortedArrayCreate(500);
            int[] arr600partial = lab.PartialSortedArrayCreate(600);
            int[] arr700partial = lab.PartialSortedArrayCreate(700);
            int[] arr800partial = lab.PartialSortedArrayCreate(800);
            int[] arr900partial = lab.PartialSortedArrayCreate(900);
            int[] arr1000partial = lab.PartialSortedArrayCreate(1000);
            #endregion

            #region Reverse Sort Data
            int[] arr100reverse = lab.ReverseArrayCreate(100);
            int[] arr200reverse = lab.ReverseArrayCreate(200);
            int[] arr300reverse = lab.ReverseArrayCreate(300);
            int[] arr400reverse = lab.ReverseArrayCreate(400);
            int[] arr500reverse = lab.ReverseArrayCreate(500);
            int[] arr600reverse = lab.ReverseArrayCreate(600);
            int[] arr700reverse = lab.ReverseArrayCreate(700);
            int[] arr800reverse = lab.ReverseArrayCreate(800);
            int[] arr900reverse = lab.ReverseArrayCreate(900);
            int[] arr1000reverse = lab.ReverseArrayCreate(1000);
            #endregion

            MergeSortInputInfo = MergeSortOutputInfo = QuickSortInputInfo = QuickSortOutputInfo = false;
            MergeSortSteps = QuickSortSteps = 0;

            #region Call Methods
            //lab.BubbleSort(arr100);
            //lab.BubbleSort(arr100reverse);
            //lab.BubbleSort(arr100partial);
            //lab.BubbleSort(arr200);
            //lab.BubbleSort(arr200reverse);
            //lab.BubbleSort(arr200partial);
            //lab.BubbleSort(arr300);
            //lab.BubbleSort(arr300reverse);
            //lab.BubbleSort(arr300partial);
            //lab.BubbleSort(arr400);
            //lab.BubbleSort(arr400reverse);
            //lab.BubbleSort(arr400partial);
            //lab.BubbleSort(arr500);
            //lab.BubbleSort(arr500reverse);
            //lab.BubbleSort(arr500partial);
            //lab.BubbleSort(arr600);
            //lab.BubbleSort(arr600reverse);
            //lab.BubbleSort(arr600partial);
            //lab.BubbleSort(arr700);
            //lab.BubbleSort(arr700reverse);
            //lab.BubbleSort(arr700partial);
            //lab.BubbleSort(arr800);
            //lab.BubbleSort(arr800reverse);
            //lab.BubbleSort(arr800partial);
            //lab.BubbleSort(arr900);
            //lab.BubbleSort(arr900reverse);
            //lab.BubbleSort(arr900partial);
            //lab.BubbleSort(arr1000);
            //lab.BubbleSort(arr1000reverse);
            //lab.BubbleSort(arr1000partial);

            //lab.SelectionSort(arr100);
            //lab.SelectionSort(arr100reverse);
            //lab.SelectionSort(arr100partial);
            //lab.SelectionSort(arr200);
            //lab.SelectionSort(arr200reverse);
            //lab.SelectionSort(arr200partial);
            //lab.SelectionSort(arr300);
            //lab.SelectionSort(arr300reverse);
            //lab.SelectionSort(arr300partial);
            //lab.SelectionSort(arr400);
            //lab.SelectionSort(arr400reverse);
            //lab.SelectionSort(arr400partial);
            //lab.SelectionSort(arr500);
            //lab.SelectionSort(arr500reverse);
            //lab.SelectionSort(arr500partial);
            //lab.SelectionSort(arr600);
            //lab.SelectionSort(arr600reverse);
            //lab.SelectionSort(arr600partial);
            //lab.SelectionSort(arr700);
            //lab.SelectionSort(arr700reverse);
            //lab.SelectionSort(arr700partial);
            //lab.SelectionSort(arr800);
            //lab.SelectionSort(arr800reverse);
            //lab.SelectionSort(arr800partial);
            //lab.SelectionSort(arr900);
            //lab.SelectionSort(arr900reverse);
            //lab.SelectionSort(arr900partial);
            //lab.SelectionSort(arr1000);
            //lab.SelectionSort(arr1000reverse);
            //lab.SelectionSort(arr1000partial);

            //lab.QuickSort(arr100, 0, arr100.Length - 1);
            //Console.WriteLine("Sorted arr100: " + string.Join(" ", arr100));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr100reverse, 0, arr100reverse.Length - 1);
            //Console.WriteLine("Sorted arr100reverse: " + string.Join(" ", arr100reverse));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr100partial, 0, arr100partial.Length - 1);
            //Console.WriteLine("Sorted arr100partial: " + string.Join(" ", arr100partial));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr200, 0, arr200.Length - 1);
            //Console.WriteLine("Sorted arr200: " + string.Join(" ", arr200));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr200reverse, 0, arr200reverse.Length - 1);
            //Console.WriteLine("Sorted arr200reverse: " + string.Join(" ", arr200reverse));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr200partial, 0, arr200partial.Length - 1);
            //Console.WriteLine("Sorted arr200partial: " + string.Join(" ", arr200partial));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr300, 0, arr300.Length - 1);
            //Console.WriteLine("Sorted arr300: " + string.Join(" ", arr300));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr300reverse, 0, arr300reverse.Length - 1);
            //Console.WriteLine("Sorted arr300reverse: " + string.Join(" ", arr300reverse));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr300partial, 0, arr300partial.Length - 1);
            //Console.WriteLine("Sorted arr300partial: " + string.Join(" ", arr300partial));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr400, 0, arr400.Length - 1);
            //Console.WriteLine("Sorted arr400: " + string.Join(" ", arr400));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr400reverse, 0, arr400reverse.Length - 1);
            //Console.WriteLine("Sorted arr400reverse: " + string.Join(" ", arr400reverse));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr400partial, 0, arr400partial.Length - 1);
            //Console.WriteLine("Sorted arr400partial: " + string.Join(" ", arr400partial));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr500, 0, arr500.Length - 1);
            //Console.WriteLine("Sorted arr500: " + string.Join(" ", arr500));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr500reverse, 0, arr500reverse.Length - 1);
            //Console.WriteLine("Sorted arr500reverse: " + string.Join(" ", arr500reverse));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr500partial, 0, arr500partial.Length - 1);
            //Console.WriteLine("Sorted arr500partial: " + string.Join(" ", arr500partial));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr600, 0, arr600.Length - 1);
            //Console.WriteLine("Sorted arr600: " + string.Join(" ", arr600));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr600reverse, 0, arr600reverse.Length - 1);
            //Console.WriteLine("Sorted arr600reverse: " + string.Join(" ", arr600reverse));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr600partial, 0, arr600partial.Length - 1);
            //Console.WriteLine("Sorted arr600partial: " + string.Join(" ", arr600partial));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr700, 0, arr700.Length - 1);
            //Console.WriteLine("Sorted arr700: " + string.Join(" ", arr700));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr700reverse, 0, arr700reverse.Length - 1);
            //Console.WriteLine("Sorted arr700reverse: " + string.Join(" ", arr700reverse));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr700partial, 0, arr700partial.Length - 1);
            //Console.WriteLine("Sorted arr700partial: " + string.Join(" ", arr700partial));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr800, 0, arr800.Length - 1);
            //Console.WriteLine("Sorted arr800: " + string.Join(" ", arr800));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr800reverse, 0, arr800reverse.Length - 1);
            //Console.WriteLine("Sorted arr800reverse: " + string.Join(" ", arr800reverse));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr800partial, 0, arr800partial.Length - 1);
            //Console.WriteLine("Sorted arr800partial: " + string.Join(" ", arr800partial));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr900, 0, arr900.Length - 1);
            //Console.WriteLine("Sorted arr900: " + string.Join(" ", arr900));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr900reverse, 0, arr900reverse.Length - 1);
            //Console.WriteLine("Sorted arr900reverse: " + string.Join(" ", arr900reverse));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr900partial, 0, arr900partial.Length - 1);
            //Console.WriteLine("Sorted arr900partial: " + string.Join(" ", arr900partial));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr1000, 0, arr1000.Length - 1);
            //Console.WriteLine("Sorted arr1000: " + string.Join(" ", arr1000));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr1000reverse, 0, arr1000reverse.Length - 1);
            //Console.WriteLine("Sorted arr1000reverse: " + string.Join(" ", arr1000reverse));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;

            //lab.QuickSort(arr1000partial, 0, arr1000partial.Length - 1);
            //Console.WriteLine("Sorted arr1000partial: " + string.Join(" ", arr1000partial));
            //QuickSortInputInfo = QuickSortOutputInfo = false;
            //QuickSortSteps = 0;


            //lab.InsertionSort(arr100);
            //lab.InsertionSort(arr100reverse);
            //lab.InsertionSort(arr100partial);
            //lab.InsertionSort(arr200);
            //lab.InsertionSort(arr200reverse);
            //lab.InsertionSort(arr200partial);
            //lab.InsertionSort(arr300);
            //lab.InsertionSort(arr300reverse);
            //lab.InsertionSort(arr300partial);
            //lab.InsertionSort(arr400);
            //lab.InsertionSort(arr400reverse);
            //lab.InsertionSort(arr400partial);
            //lab.InsertionSort(arr500);
            //lab.InsertionSort(arr500reverse);
            //lab.InsertionSort(arr500partial);
            //lab.InsertionSort(arr600);
            //lab.InsertionSort(arr600reverse);
            //lab.InsertionSort(arr600partial);
            //lab.InsertionSort(arr700);
            //lab.InsertionSort(arr700reverse);
            //lab.InsertionSort(arr700partial);
            //lab.InsertionSort(arr800);
            //lab.InsertionSort(arr800reverse);
            //lab.InsertionSort(arr800partial);
            //lab.InsertionSort(arr900);
            //lab.InsertionSort(arr900reverse);
            //lab.InsertionSort(arr900partial);
            //lab.InsertionSort(arr1000);
            //lab.InsertionSort(arr1000reverse);
            //lab.InsertionSort(arr1000partial);

            //lab.MergeSort(arr100, 0, arr100.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr100: " + string.Join(" ", arr100));

            //lab.MergeSort(arr100reverse, 0, arr100reverse.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr100reverse: " + string.Join(" ", arr100reverse));

            //lab.MergeSort(arr100partial, 0, arr100partial.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr100partial: " + string.Join(" ", arr100partial));

            //lab.MergeSort(arr200, 0, arr200.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr200: " + string.Join(" ", arr200));

            //lab.MergeSort(arr200reverse, 0, arr200reverse.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr200reverse: " + string.Join(" ", arr200reverse));

            //lab.MergeSort(arr200partial, 0, arr200partial.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr200partial: " + string.Join(" ", arr200partial));

            //lab.MergeSort(arr300, 0, arr300.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr300: " + string.Join(" ", arr300));

            //lab.MergeSort(arr300reverse, 0, arr300reverse.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr300reverse: " + string.Join(" ", arr300reverse));

            //lab.MergeSort(arr300partial, 0, arr300partial.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr300partial: " + string.Join(" ", arr300partial));

            //lab.MergeSort(arr400, 0, arr400.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr400: " + string.Join(" ", arr400));

            //lab.MergeSort(arr400reverse, 0, arr400reverse.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr400reverse: " + string.Join(" ", arr400reverse));

            //lab.MergeSort(arr400partial, 0, arr400partial.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr400partial: " + string.Join(" ", arr400partial));

            //lab.MergeSort(arr500, 0, arr500.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr500: " + string.Join(" ", arr500));

            //lab.MergeSort(arr500reverse, 0, arr500reverse.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr500reverse: " + string.Join(" ", arr500reverse));

            //lab.MergeSort(arr500partial, 0, arr500partial.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr500partial: " + string.Join(" ", arr500partial));

            //lab.MergeSort(arr600, 0, arr600.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr600: " + string.Join(" ", arr600));

            //lab.MergeSort(arr600reverse, 0, arr600reverse.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr600reverse: " + string.Join(" ", arr600reverse));

            //lab.MergeSort(arr600partial, 0, arr600partial.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr600partial: " + string.Join(" ", arr600partial));

            //lab.MergeSort(arr700, 0, arr700.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr700: " + string.Join(" ", arr700));

            //lab.MergeSort(arr700reverse, 0, arr700reverse.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr700reverse: " + string.Join(" ", arr700reverse));

            //lab.MergeSort(arr700partial, 0, arr700partial.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr700partial: " + string.Join(" ", arr700partial));

            //lab.MergeSort(arr800, 0, arr800.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr800: " + string.Join(" ", arr800));

            //lab.MergeSort(arr800reverse, 0, arr800reverse.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr800reverse: " + string.Join(" ", arr800reverse));

            //lab.MergeSort(arr800partial, 0, arr800partial.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr800partial: " + string.Join(" ", arr800partial));

            //lab.MergeSort(arr900, 0, arr900.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr900: " + string.Join(" ", arr900));

            //lab.MergeSort(arr900reverse, 0, arr900reverse.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr900reverse: " + string.Join(" ", arr900reverse));

            //lab.MergeSort(arr900partial, 0, arr900partial.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr900partial: " + string.Join(" ", arr900partial));

            //lab.MergeSort(arr1000, 0, arr1000.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr1000: " + string.Join(" ", arr1000));

            //lab.MergeSort(arr1000reverse, 0, arr1000reverse.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr1000reverse: " + string.Join(" ", arr1000reverse));

            //lab.MergeSort(arr1000partial, 0, arr1000partial.Length - 1);
            //MergeSortInputInfo = MergeSortOutputInfo = false;
            //MergeSortSteps = 0;
            //Console.WriteLine("Sorted arr1000partial: " + string.Join(" ", arr1000partial));

            #endregion
        }

        #region Sort Methods
        private void BubbleSort(int[] array)
        {
            try
            {
                Console.WriteLine("\n--BubbleSort--\n");
                int[] tmp = array;
                int steps = 0;
#if Debug
                Console.WriteLine("\nUnsorted array: ");
                string arrayStr = string.Empty;
                for (int i = 0; i < tmp.Length; i++)
                {
                    arrayStr += $"{tmp[i]} | ";
                }

                Console.WriteLine(arrayStr);
#endif

                bool swapped;
                for (int i = 0; i < tmp.Length - 1; i++)
                {
                    swapped = false;
                    for (int j = 0; j < tmp.Length - i - 1; j++)
                    {
                        if (tmp[j] > tmp[j + 1])
                        {
                            int temp = tmp[j];
                            tmp[j] = tmp[j + 1];
                            tmp[j + 1] = temp;
                            swapped = true;
                        }
                        steps++;
                    }
                    if (!swapped) // Если не было обменов, выходим из цикла
                        break;
                }
#if Debug
                Console.WriteLine("\nSorted array: ");
                arrayStr = string.Empty;
                for (int i = 0; i < tmp.Length; i++)
                {
                    arrayStr += $"{tmp[i]} | ";
                }

                Console.WriteLine(arrayStr);
#endif
                Console.WriteLine($"\n Steps: {steps}\n");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"\nERROR! {ex.Message}\n\n{ex.StackTrace}");
            }
        }

        private void SelectionSort(int[] array)
        {
            try
            {
                Console.WriteLine("\n--SelectionSort--\n");
                int[] tmp = array;
                int steps = 0;
#if Debug
                Console.WriteLine("\nUnsorted array: ");
                string arrayStr = string.Empty;
                for (int i = 0; i < tmp.Length; i++)
                {
                    arrayStr += $"{tmp[i]} | ";
                }

                Console.WriteLine(arrayStr);
#endif

                for (int i = 0; i < tmp.Length - 1; i++)
                {
                    int minIndex = i;
                    for (int j = i + 1; j < tmp.Length; j++)
                    {
                        if (tmp[j] < tmp[minIndex])
                        {
                            minIndex = j;
                        }

                        steps++;
                    }

                    if (minIndex != i)
                    {
                        int temp = tmp[minIndex];
                        tmp[minIndex] = tmp[i];
                        tmp[i] = temp;
                    }
                }
#if Debug
                Console.WriteLine("\nSorted array: ");
                arrayStr = string.Empty;
                for (int i = 0; i < tmp.Length; i++)
                {
                    arrayStr += $"{tmp[i]} | ";
                }

                Console.WriteLine(arrayStr);
#endif
                Console.WriteLine($"\n Steps: {steps}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nERROR! {ex.Message}\n\n{ex.StackTrace}");
            }
        }

        private void InsertionSort(int[] array)
        {
            try
            {
                Console.WriteLine("\n--InsertionSort--\n");
                int[] tmp = array;
                int steps = 0;
#if Debug
                Console.WriteLine("\nUnsorted array: ");
                string arrayStr = string.Empty;
                for (int i = 0; i < tmp.Length; i++)
                {
                    arrayStr += $"{tmp[i]} | ";
                }

                Console.WriteLine(arrayStr);
#endif

                for (int i = 1; i < tmp.Length; i++)
                {
                    int key = tmp[i];
                    int j = i - 1;

                    while (j >= 0 && tmp[j] > key)
                    {
                        tmp[j + 1] = tmp[j];
                        j--;

                        steps++;
                    }

                    tmp[j + 1] = key;
                }
#if Debug
                Console.WriteLine("\nSorted array: ");
                arrayStr = string.Empty;
                for (int i = 0; i < tmp.Length; i++)
                {
                    arrayStr += $"{tmp[i]} | ";
                }

                Console.WriteLine(arrayStr);
#endif
                Console.WriteLine($"\n Steps: {steps}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nERROR! {ex.Message}\n\n{ex.StackTrace}");
            }
        }

        private void MergeSort(int[] array, int left, int right)
        {
            try
            {
//#if Debug
//                string arrayStr = string.Empty;
//                if (!MergeSortInputInfo)
//                {
//                    Console.WriteLine("\n--MergeSort--\n");
//                    MergeSortSteps = 0;
//                    Console.WriteLine("\nUnsorted array: ");
//                    for (int i = 0; i < array.Length; i++)
//                    {
//                        arrayStr += $"{array[i]} | ";
//                    }

//                    Console.WriteLine(arrayStr);
//                    MergeSortInputInfo = true;
//                }
//#endif

                if (left < right)
                {
                    MergeSortSteps++;

                    int middle = (left + right) / 2;

                    MergeSort(array, left, middle);
                    MergeSort(array, middle + 1, right);

                    Merge(array, left, middle, right);
                }
                if (!MergeSortOutputInfo)
                {
//#if Debug
//                    Console.WriteLine("\nSorted array: ");
//                    arrayStr = string.Empty;
//                    for (int i = 0; i < array.Length; i++)
//                    {
//                        arrayStr += $"{array[i]} | ";
//                    }

//                    Console.WriteLine(arrayStr);
//#endif

                    Console.WriteLine($"\n Steps: {MergeSortSteps}\n");
                    MergeSortOutputInfo = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nERROR! {ex.Message}\n\n{ex.StackTrace}");
            }
        }

        private void QuickSort(int[] array, int left, int right)
        {
            try
            {
                int[] tmp = array;
                string arrayStr = string.Empty;
#if Debug
                //if (!QuickSortInputInfo)
                //{
                //    Console.WriteLine("\n--QuickSort--\n");
                //    QuickSortSteps = 0;
                //    Console.WriteLine("\nUnsorted array: ");
                //    for (int i = 0; i < tmp.Length; i++)
                //    {
                //        arrayStr += $"{tmp[i]} | ";
                //    }

                //    Console.WriteLine(arrayStr);
                //    QuickSortInputInfo = true;
                //}
#endif

                if (left < right)
                {
                    QuickSortSteps++;
                    int pivotIndex = Partition(tmp, left, right);
                    QuickSort(tmp, left, pivotIndex - 1);
                    QuickSort(tmp, pivotIndex + 1, right);
                }

                if (!QuickSortOutputInfo)
                {
#if Debug
                    //Console.WriteLine("\nSorted array: ");
                    //arrayStr = string.Empty;
                    //for (int i = 0; i < tmp.Length; i++)
                    //{
                    //    arrayStr += $"{tmp[i]} | ";
                    //}

                    //Console.WriteLine(arrayStr);
#endif

                    Console.WriteLine($"\n Steps: {QuickSortSteps}\n");
                    QuickSortOutputInfo = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nERROR! {ex.Message}\n\n{ex.StackTrace}");
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

        private int[] PartialSortedArrayCreate(int length) //75%
        {
            int[] data = ArrayCreate(length);

            int lengthToSort = (int)(data.Length * 0.75);

            Array.Sort(data, 0, lengthToSort);

            return data;
        }

        private int[] ReverseArrayCreate(int length)
        {
            int[] data = ArrayCreate(length);
            Array.Sort(data);
            Array.Reverse(data);

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


        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        private void Merge(int[] array, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = array[left + i];
            for (int j = 0; j < n2; j++)
                rightArray[j] = array[middle + 1 + j];

            int iLeft = 0, iRight = 0;
            int k = left;

            while (iLeft < n1 && iRight < n2)
            {
                if (leftArray[iLeft] <= rightArray[iRight])
                {
                    array[k] = leftArray[iLeft];
                    iLeft++;
                }
                else
                {
                    array[k] = rightArray[iRight];
                    iRight++;
                }
                k++;
            }

            while (iLeft < n1)
            {
                array[k] = leftArray[iLeft];
                iLeft++;
                k++;
            }

            while (iRight < n2)
            {
                array[k] = rightArray[iRight];
                iRight++;
                k++;
            }
        }
        #endregion
    }
}
