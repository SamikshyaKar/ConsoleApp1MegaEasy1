using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1MegaEasy1.MyApps
{
    public class BubbleSort
    {
        public static void Bubblesort()
        {
            Console.WriteLine(" Welcome to bubble Sort");
            int[] arr = new int[] { 12, 89, 54, 98, 67, 32, 15 };
            Console.WriteLine("Before Unsorted");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0;j<arr.Length-1-i;j++)
                {
                    if(arr[j]>arr[j+1])
                    {
                        int temp= arr[j];
                        arr[j]=arr[j+1];
                        arr[j + 1] = temp;
                    }
                }
            }


            Console.WriteLine("After Bubble Sorting");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
    }
}
