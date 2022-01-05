
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1MegaEasy1.MyApps
{
    public  static class Experiments
    {
        public static void display()
        {

            Console.WriteLine(" Inside Display");
            int[] arr = new int[] { 12, 98, 45, 23, 67, 43, 48, -38, -7, 11 };
            int[] result = newsummationarray(arr, 60);
            foreach(int i in result)
            {
                Console.Write(i + "  " );
            }
            Console.WriteLine();
        }

        public static T[] Append<T>(this T[] array, T item)
        {
            if (array == null)
            {
                return new T[] { item };
            }

            T[] result = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i];
            }

            result[array.Length] = item;
            return result;
        }
        public static int[] newsummationarray(int[] array, int targetnumber)
        {
            int[] resultssets = new int[10];
            int[] arrayappend=  new int[1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                int firstnum = array[i];
                
                for (int j = i + 1; j < array.Length; j++)
                {
                    int secondnum = array[j];


                    if (firstnum + secondnum == targetnumber)
                    {

                         resultssets.Append(firstnum);
                        resultssets.Append(secondnum);
                       int[] newarr= new int[] { firstnum, secondnum };
                         arrayappend = newarr.Append(firstnum);
                        arrayappend = newarr.Append(secondnum);



                    }
                }
            }
            //return new int[0];
            return arrayappend;
        }
    }
}
