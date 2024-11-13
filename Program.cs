using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace binary_searsh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ary = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 ,20,24,523,5252,65555,242424224};
            int x = 65555;
            foreach (int i in ary)
            
                Console.Write(i+" ");
            Console.WriteLine();
            int result = Binary_searsh(ary, x);
            if (result == -1)
                Console.WriteLine("not found");
            else Console.WriteLine("element found in index:  "+ result);

        }
        static int Binary_searsh(int[]ary,int x) 
        {
            int start =0,end=ary.Length-1,count=0; 
            while (start<=end)
            {
                count++;
                Console.WriteLine("count= "+count);
                int mid = start+(end-start)/2;
                if (ary[mid]==x)
                    return mid;
                if (x> ary[mid])
                    start = mid+1;
                else 
                    end = mid-1;
            }
            return -1;
        }

    }
}
