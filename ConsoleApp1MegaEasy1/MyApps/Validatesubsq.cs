using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1MegaEasy1.MyApps
{

    public class Validatesubsq
    {
        public static void ValidSq()
        {
            List<int> myarray = new List<int>()
            { 22,8,9,12,56,23};
            List<int> Sequesnce = new List<int>()
            {8,9,23 };

            int arrindex = 0;
            int seqindex = 0;
            Console.WriteLine(Sequesnce.Count + "*");
            while (arrindex<myarray.Count && seqindex< Sequesnce.Count)
            {
                if (myarray[arrindex]==Sequesnce[seqindex])
                {
                    seqindex++;
                }
                arrindex++;
            }
            Console.WriteLine(seqindex + " " + Sequesnce.Count);

            Console.WriteLine(seqindex==Sequesnce.Count ? "ValidSequesnce": "InvalidSequesnce");
 
        }

        public static void ValidSq2()
        {
            List<int> listarray = new List<int>()
            { 12,87,23,67,90,34,56,89};
            List<int> listsequence = new List<int>() { 23, 90, 56 };

            int seqindex = 0;
            foreach (int val in listarray)
            {
                if (seqindex == listsequence.Count)
                {
                    Console.WriteLine("Valid ");
                    break;
                }
                if(listsequence[seqindex]==val)
                {
                    seqindex++;
                }
            }

            Console.WriteLine(seqindex==listsequence.Count ? "Valid Sequesnce": "Invalid Sequence ");

        }
        
    }
}
