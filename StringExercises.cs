using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises2
{
    internal class StringExercises
    {
        /* Write a C# Sharp program to separate individual characters from a string. */
        public string SeparateStringWithSpaces(string text)
        {
            if (string.IsNullOrEmpty(text)) return "";
            return string.Join(" ", text.Select(x => $"{x}"));
        }
    }
}
