﻿using System;
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
        //4. Write a program in C# Sharp to print individual characters of the string in reverse order. 
        public string SeparateStringWithoutSpacesInReverse(string text)
        {
            if (string.IsNullOrEmpty(text)) return "";
            return string.Join(" ", text.ToCharArray().Reverse());
        }
        //5. Write a program in C# Sharp to count the total number of words in a string. 
        public int GetTotalWordsIn(string text)
        {
            if(string.IsNullOrEmpty(text)) return 0;
            if(!text.Contains(" ")) return 1;
            return text.Split(' ').Length;
        }
    }
}
