using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void InsertionSort(int[] array)
        {
            // begin with the 2nd element
            for (int currentIndex = 1; currentIndex < array.Length; currentIndex++)
            {
                int currentElement = array[currentIndex];
                int previousIndex = currentIndex - 1;
                // Insert this element into the sorted sequence array[0 ... j - 1]
                while (previousIndex >= 0 && array[previousIndex] > currentElement)
                {
                    array[previousIndex + 1] = array[previousIndex];
                    previousIndex = previousIndex - 1;
                }
                // previousIndex + 1: get back to the correct element's position
                array[previousIndex + 1] = currentElement;
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 4, 3, 7, 5, 1, 8, 6, 10, 9, 2 };
            InsertionSort(array);

            foreach(int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}
