
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1MegaEasy1.MyApps
{
    public class Insertion
    {
        public static void InsertionSort()
        {
            int[] arr = { 34, 87, 89, 12, 45, 67, 99, 93, 26 };
            Console.WriteLine("Before Unsorted");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            for (int i = 1; i < arr.Length; i++)
            {
                int j=i;
                while(j > 0 && arr[j] < arr[j-1] )
                {
                    int temp= arr[j];
                    arr[j]=arr[j-1];
                    arr[j-1]=temp;

                    j--;
                }
            }
            Console.WriteLine("After Insertion  sorted");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


        }

    }
}
