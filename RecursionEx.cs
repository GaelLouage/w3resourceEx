using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises2
{
    internal class RecursionEx
    {

        public void PrintFirstNaturalNumbers(int num)
        {
            if (num > 10) return;

            Console.WriteLine(num);
            PrintFirstNaturalNumbers(num + 1);
        }

        public void PrintNumbersFromNTo1(int n)
        {
            if (n < 1) return;
            Console.WriteLine(n);
          
            PrintNumbersFromNTo1(n-1);
        }
        //3. Write a program in C# Sharp to find the sum of the first n natural numbers using recursion. 
        public int PrintSumOfFirstNaturalNumbers(int n,ref int res)
        {
            if(n < 1) return 0;
            res += n;
           
            return  PrintSumOfFirstNaturalNumbers(n - 1,ref res);
        }
    }
}
