using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1MegaEasy1.MyApps
{
    public class SummationTwoNum
    {
        public static void SummationTwoSum()
        {
            int[] arr = new int[] { 23, 87, 11, -1, 5, 6, 4, 5, -13, 45 };
            Console.WriteLine("Please Enter a Targetnumber Preferably 10 ");
            int targetnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Summation ");
            for(int i=0; i<arr.Length-1; i++)
            {
                int firstnum=arr[i];
                for(int j=i+1; j<arr.Length; j++)
                {
                    int secondnum=arr[j];
                    if(firstnum+secondnum== targetnum)
                    {
                        Console.WriteLine(" Target number achieved");
                       int[] arrresut=  new int[] { firstnum, secondnum }; 

                        foreach (int num in arrresut)
                        {
                            Console.Write(num + "  ");
                        }
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine(" for newsummationarray ");
            int[] newarray = newsummationarray(new int[] { 78, 56, 23, 12, 67, 34, -6, -28, 38 }, 50);

            foreach (int num in newarray)
            {
                Console.Write(num + " ");
                
            }
            Console.WriteLine();
            int[] arr2 = new int[] { 78, 56, 23, 12, 67, 34, -6, -28, 38 };
            int[] newarray1 = newsummationarray(arr2, 50);
            foreach (int num in newarray1)
            {
                Console.Write(num + " ");

            }
            Console.WriteLine();
        }

        public static  int[] newsummationarray(int[] array, int targetnumber)
        {

            for (int i=0; i<array.Length-1; i++)
            {
                int firstnum= array[i];
                for (int j=i+1; j<array.Length; j++)
                {
                    int secondnum= array[j];

                   
                        if (firstnum + secondnum == targetnumber)
                        {
                            return new int[] { firstnum, secondnum };

                        }                     
                    

                }
            }
            return new int[0];
        }
        

    }
}
