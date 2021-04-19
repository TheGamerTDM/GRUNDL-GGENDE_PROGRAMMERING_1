using System;

namespace Quick_Sort
{

    class test
    {

        static void Main(string[] args)
        {
            var arr = new[] { 4, 2, 3, 2, 1, -1, 0, 10 };
            var sorted = QuickSort(arr, 0, arr.Length);

            foreach (var item in sorted)
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine();
        }
        
        public static int[] QuickSort(int[] arr, int start, int end)
        {
            if(start < end)
            {
                int pivot = Partion(arr, start, end);
                QuickSort(arr, start, pivot);
                QuickSort(arr, pivot + 1, end);
            }
            return arr;
        }

        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static int Partion(int[] arr, int start, int end)
        {
            int pivot = arr[start];
            int swapIndex = start;

            for(int i = start +1; i<end; i++)
            {
                if(arr[i]< pivot)
                {
                    swapIndex++;
                    Swap(arr, i, swapIndex);
                }
            }
            Swap(arr, start, swapIndex);
            return swapIndex;


        }

    }


}