using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises2
{
    internal class LinqExercises
    {
        public int[]? NumbersBetween1And11(int[] numbers)
        {
            if (numbers.Length < 1) return null;

            return numbers.Where(x => x <= 11 && x >= 1).ToArray();
        }
    }
}
