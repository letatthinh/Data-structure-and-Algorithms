using System;

namespace ConsoleApp1
{
    class Program
    {

        private static int[] Merge(int[] array, int startIndex, int middleIndex, int endIndex)
        {
            // array[start index ... middle index]
            int subArray1Length = (middleIndex - startIndex) / 1 + 1;

            // array[(middle index + 1) ... end index]
            int subArray2Length = (endIndex - (middleIndex + 1)) / 1 + 1;
            /* Note:
               + Số số hạng = (số cuối – số đầu) / đơn vị khoảng cách + 1
            */

            int[] subArray1 = new int[subArray1Length];
            int[] subArray2 = new int[subArray2Length];

            for (int index = 0; index < subArray1.Length; index++)
            {
                subArray1[index] = array[startIndex + index];
                /* Note:
                   + Start index is not always 0, depends on the position of the sub-array.
                */
            }

            for (int index = 0; index < subArray2.Length; index++)
            {
                subArray2[index] = array[(middleIndex + 1) + index];
                /* Note:
                   + Sub-array 2 always start with middle index + 1
                */
            }

            int subArray1Index = 0;
            int subArray2Index = 0;
            int arrayIndex = startIndex;

            while (subArray1Index < subArray1.Length && subArray2Index < subArray2.Length)
            {
                if (subArray1[subArray1Index] < subArray2[subArray2Index])
                {
                    array[arrayIndex] = subArray1[subArray1Index];
                    subArray1Index++;
                }
                else
                {
                    array[arrayIndex] = subArray2[subArray2Index];
                    subArray2Index++;
                }
                arrayIndex++;
            }

            // when we run out of elements in either sub-array 1 or sub-array 2,
            // pick up the remaining elements and put in array[array index]
            while (subArray1Index < subArray1.Length)
            {
                array[arrayIndex] = subArray1[subArray1Index];
                subArray1Index++;
                arrayIndex++;
            }

            while (subArray2Index < subArray2.Length)
            {
                array[arrayIndex] = subArray2[subArray2Index];
                subArray2Index++;
                arrayIndex++;
            }

            return array;
        }

        public static void MergeSort(int[] array, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                return;
            }

            int middleIndex = (startIndex + endIndex) / 2;
            /* Note:
               + Trung bình cộng = (số đầu + số cuối) / 2
            */

            MergeSort(array, startIndex, middleIndex);
            MergeSort(array, middleIndex + 1, endIndex);
            Merge(array, startIndex, middleIndex, endIndex);
        }

        static void Main(string[] args)
        {
            int[] array = { 4, 3, 7, 5, 1, 8, 6, 10, 9, 2 };
            MergeSort(array, 0, (array.Length - 1));

            foreach(int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}
