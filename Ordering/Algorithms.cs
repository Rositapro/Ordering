using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering
{
    public static class Algorithms
    {

        public static void MergeSort(int[] array, int left, int right, Action<int[], string> displayCallback)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(array, left, middle, displayCallback);
                MergeSort(array, middle + 1, right, displayCallback);
                Merge(array, left, middle, right, displayCallback);
            }
        }

        private static void Merge(int[] array, int left, int middle, int right, Action<int[], string> displayCallback)
        {
            int[] leftArray = array[left..(middle + 1)];
            int[] rightArray = array[(middle + 1)..(right + 1)];
            int i = 0, j = 0, k = left;

            while (i < leftArray.Length && j < rightArray.Length)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k++] = leftArray[i++];
                }
                else
                {
                    array[k++] = rightArray[j++];
                }
                displayCallback(array, "Merge paso a paso");
            }

            while (i < leftArray.Length)
            {
                array[k++] = leftArray[i++];
                displayCallback(array, "Merge paso a paso");
            }

            while (j < rightArray.Length)
            {
                array[k++] = rightArray[j++];
                displayCallback(array, "Merge paso a paso");
            }
        }

        public static void MezclaDirecta(int[] array, Action<int[], string> displayCallback)
        {
            int n = array.Length;
            int[] temp = new int[n];
            for (int width = 1; width < n; width *= 2)
            {
                for (int i = 0; i < n; i += 2 * width)
                {
                    int left = i;
                    int middle = Math.Min(i + width, n);
                    int right = Math.Min(i + 2 * width, n);

                    int l = left, r = middle, k = left;

                    while (l < middle && r < right)
                    {
                        if (array[l] <= array[r])
                        {
                            temp[k++] = array[l++];
                        }
                        else
                        {
                            temp[k++] = array[r++];
                        }
                        displayCallback(temp, "Mezcla Directa paso a paso");
                    }

                    while (l < middle)
                    {
                        temp[k++] = array[l++];
                        displayCallback(temp, "Mezcla Directa paso a paso");
                    }

                    while (r < right)
                    {
                        temp[k++] = array[r++];
                        displayCallback(temp, "Mezcla Directa paso a paso");
                    }
                }
                Array.Copy(temp, array, n);
            }
        }

        public static void MezclaNatural(int[] array, Action<int[], string> displayCallback)
        {
            bool ordenado = false;
            int[] temp = new int[array.Length];

            while (!ordenado)
            {
                ordenado = true;
                int i = 0, k = 0;

                while (i < array.Length)
                {
                    int start = i;
                    while (i < array.Length - 1 && array[i] <= array[i + 1])
                        i++;
                    i++;

                    int j = i;
                    while (i < array.Length - 1 && array[i] <= array[i + 1])
                        i++;
                    i++;

                    MergeNatural(array, start, j, i, temp, displayCallback);

                    if (i < array.Length)
                        ordenado = false;
                }

                Array.Copy(temp, array, array.Length);
                displayCallback(array, "Mezcla Natural paso a paso");
            }
        }

        private static void MergeNatural(int[] array, int left, int middle, int right, int[] temp, Action<int[], string> displayCallback)
        {
            int i = left, j = middle, k = left;

            while (i < middle && j < right)
            {
                if (array[i] <= array[j])
                {
                    temp[k++] = array[i++];
                }
                else
                {
                    temp[k++] = array[j++];
                }
                displayCallback(temp, "Mezcla Natural paso a paso");
            }

            while (i < middle)
            {
                temp[k++] = array[i++];
                displayCallback(temp, "Mezcla Natural paso a paso");
            }

            while (j < right)
            {
                temp[k++] = array[j++];
                displayCallback(temp, "Mezcla Natural paso a paso");
            }
        }
    }
}
