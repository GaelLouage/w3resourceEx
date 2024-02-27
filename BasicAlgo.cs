using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises2
{
    internal class BasicAlgo
    {
        /*8. Write a C# Sharp program to create a string which is 4 copies of the 2 front characters of a given string. If the given string length is less than 2 return the original string. */
        public string CopyFrontChars4Times(string text)
        {
            return text.Length < 2 ? text : string.Join("", Enumerable.Range(0, 4).Select(x => $"{text.Substring(0,2)}"));
        }
    }
}
