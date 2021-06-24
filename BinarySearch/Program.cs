using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {

            var arr = new[] { 2, 3, 5, 7, 9, 12, 76, 100, 500 };
            Console.WriteLine(BinarySearch(arr, 7));

        }

        public static int BinarySearch(int [] arr, int key)
        {
            int left = 0;
            int right = arr.Length;
            while(left < right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == key)
                    return mid;

                if (arr[mid] > key)
                    right = mid;
                else
                    left = mid + 1;

            }
            return -1;
        }
        

    }
}
