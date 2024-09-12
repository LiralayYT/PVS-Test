using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp2
{

    internal class Program
    {

        internal static int BubbleSort(int[] arr)
        {



            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + ", ");

            return 0;

        }

        // - QUICKSORT

        //метод для обмена элементов массива
        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        //метод возвращающий индекс опорного элемента
        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        //быстрая сортировка
        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        internal static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }



        static void Main(string[] args)
        {

            Console.Write("Введите размерность массива = ");
            var len = Convert.ToInt32(Console.ReadLine());
            var a = new int[len];
            Console.Write("Введите элементы массива =  \n");
            for (var i = 0; i < a.Length; ++i)
            {
                Console.Write("a[{0}] = ", i);

                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Stopwatch BS = new Stopwatch();
            Stopwatch QS = new Stopwatch();


            BS.Start();
            Console.Write("Упорядоченный массив, BubbleSort: "); BubbleSort(a);
            BS.Stop();

            QS.Start();
            Console.WriteLine("\nУпорядоченный массив, QuickSort: {0}", string.Join(", ", QuickSort(a)));
            QS.Stop();



            Console.WriteLine(BS.ElapsedTicks + " тиков процессора заняла пузырьковая сортировка\n");
            Console.WriteLine(QS.ElapsedTicks + " тиков процессора заняла быстрая сортировка\n");

            // - BubbleSort будет быстрее при сортировке массивов небольшого размера засчёт меньшего кол-ва вычислений

            Console.ReadLine();
        }
    }
}
