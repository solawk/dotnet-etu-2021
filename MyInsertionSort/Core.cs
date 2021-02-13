using System;

namespace MyInsertionSort
{
    class Core
    {
        private static int[] InsertionSort(int[] values)
        {
            for (int i = 1; i < values.Length; i++)
            {
                int targetValue = values[i];
                int comparedValueIndex = i - 1;

                while (comparedValueIndex >= 0 && values[comparedValueIndex] > targetValue)
                {
                    values[comparedValueIndex + 1] = values[comparedValueIndex];
                    comparedValueIndex--;
                }

                values[comparedValueIndex + 1] = targetValue;
            }

            return values;
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            const int arraySize = 30;

            int[] values = new int[arraySize];

            Console.Write("Array: [ ");
            for (int i = 0; i < arraySize; i++)
            {
                values[i] = rand.Next(arraySize);
                Console.Write(values[i] + " ");
            }
            Console.WriteLine("]");

            values = InsertionSort(values);

            Console.Write("Sorted array: [ ");
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write(values[i] + " ");
            }
            Console.WriteLine("]");

            Console.ReadKey();
        }
    }
}
