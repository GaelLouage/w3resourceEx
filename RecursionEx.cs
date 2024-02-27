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
    }
}
