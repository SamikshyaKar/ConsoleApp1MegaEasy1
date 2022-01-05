using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1MegaEasy1.MyApps
{
    public class SelectionSort
    {

        public  static Random rand= new Random();
        public static void SelectionIndexSorting()
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100);
            }
            Console.WriteLine("The Unsorted Array as Follows");         

            foreach (int i in arr)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();

            int startindex = 0;

            while (startindex < arr.Length-1)
            {
                int smallindex = startindex;

                for (int i = startindex+1; i < arr.Length;i++)
                {
                    if (arr[smallindex]>arr[i])
                    {
                        smallindex = i;
                    }
                }

                int temp= arr[smallindex];
                arr[smallindex]=arr[startindex];    
                arr[startindex]=temp;
                startindex++;


            }

            Console.WriteLine("The Sorted Selection Array as Follows");

            foreach (int i in arr)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
        }
    }
}
