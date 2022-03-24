using System;

namespace InsertionSort
{
    class program
    {
        static void Main(string[] args)
        {
            int[] sortarray = new int[5] { 23, 22, 9, 45, 67 };
            int n = 5, flag, i, j, value;
            Console.WriteLine("Before sorting");
            for (i = 0; i < sortarray.Length; i++)
            {
                Console.Write(sortarray[i] + " ");
            }

            for (i = 0; i < n; i++)
            {
                value = sortarray[i];
                flag = 0;

                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (value < sortarray[j])
                    {
                        sortarray[j + 1] = sortarray[j];
                        j--;
                        sortarray[j + 1] = value;
                    }

                    flag = 1;

                }
            }

            Console.WriteLine("After sorting");
            for (i = 0; i < n; i++)
            {
                Console.Write(sortarray[i] + " ");
            }

        }
    }
}