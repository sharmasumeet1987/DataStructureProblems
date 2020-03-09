using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sorting
{
    class SortingAlgos
    {
        public static void MergeSort(int[] arr, int l, int r)
        {
            if (l<r)
            {
                int m = l + (r - l) / 2;
                MergeSort(arr, l, m);
                MergeSort(arr, m + 1, r);
                Merge(arr, l, m, r);
            }
        }
        public static void Merge(int[] arr,int l, int m,   int r)
        {
            int l1 = m - l + 1;
            int l2 = r - m;
            int[] left = new int[l1];
            int[] right = new int[l2];
            for (int a = 0; a < l1; a++)
            {
                left[a] = arr[l + a];
            }
            for (int b = 0; b < l2; b++)
            {
                right[b] = arr[m + 1 + b];
            }
            int i = 0, j = 0;
            int k = l;
            while (i < l1 && j < l2)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }
            // Copy the remaining from both left and right arrays
            while (i< l1)
            {
                arr[k] = left[i];
                i++;
                k++;
            }
            while (j < l2)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
