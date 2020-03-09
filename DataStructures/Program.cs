using DataStructures.Arrays;
using DataStructures.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problems.PrintSquares(1000000);

            //int[] arr = new int[7] { 3, 4, 2, 1, 5, 4, 9 };
            // SortingAlgos.MergeSort(arr, 0, arr.Length -1);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //}


            char[] str = "Mr John Smith ".ToCharArray();

            // Prints the replaced string 
            str = URLify.replaceSpaces(str);

            for (int i = 0; i < str.Length; i++)
                Console.Write(str[i]);

            Console.ReadKey();
        }
    }
}
