using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LongestArithmeticProgression
{
    class Program
    {
        //Time: O(n2)
        //assume array is in sorted order        
        static int longestAP(int[] arr)
        {
            int n = arr.Length;
            if (n <= 2)
                return n;

            int llap = 2;

            int[,] lap = new int[n, n]; //lap[i, j] is AP with first two elements at i and j
            for (int i = 0; i < n; i++)
                lap[i, n - 1] = 2;  //last column is always 2

            for (int j = n - 2; j >= 1; j--)    //consider every element as 2nd element and iterate from last but 1 to 1st element
            {
                int i = j - 1;
                int k = j + 1;
                //Try to determine longest AP with 1st two elements at i and j.
                while (i >= 0 && k < n)
                {
                    if ((arr[i] + arr[k]) == (2 * arr[j]))
                    {
                        lap[i, j] = lap[j, k] + 1;
                        llap = Math.Max(llap, lap[i, j]);
                        i--;
                        k++;
                    }
                    else if ((arr[i] + arr[k]) < (2 * arr[j]))
                    {
                        k++;
                    }
                    else
                    {
                        lap[i, j] = 2;  //because AP of 2 elements is always 2.
                        i--;
                    }
                }

                while (i >= 0)
                {
                    lap[i, j] = 2;
                    i--;
                }
            }
            return llap;
        }

        //Check if there exists at least 3 elements that are in AP in the given arr
        static bool APThree(int[] arr)
        {
            int i, k;
            //fix middle element in AP and check the property
            for (int j = 1; j < arr.Length - 1; j++)
            {
                i = j - 1;
                k = j + 1;
                while (i >= 0 && k < arr.Length)
                {
                    if ((arr[i] + arr[k]) == (2*arr[j]))
                        return true;
                    if ((arr[i] + arr[k]) < (2*arr[j]))
                        k++;
                    else
                        i--;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            int[] arr = { 5, 10, 12, 15, 99 };
            Console.WriteLine("Longest AP = {0}", longestAP(arr));
            //Console.WriteLine(APThree(arr));
            Console.ReadLine();
        }
    }
}
