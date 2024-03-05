using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public dynamic FindNumberOfArrayAndSquareQuery(int[] numbers)
        {
            if (numbers is  null && numbers.Length < 1) return default;
            var result = from int x in numbers
                         let c = x * x
                         select new { Number = x, Square = c };
            return result;
        }
        public dynamic FindNumberOfArrayAndSquareMethod(int[] numbers)
        {
            if (numbers is null && numbers.Length < 1) return default;
          
            return numbers.Select(x => new {Number = x, Square = x * x });
        }
    }
}
