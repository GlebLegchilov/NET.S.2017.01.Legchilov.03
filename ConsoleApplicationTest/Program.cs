using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplicationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TaskThree.NumberInsertion.Insertion(0, 15, 30, 30));
            Console.WriteLine(TaskTwo.ArraysSort.Longest("xyaabbbccccdefww", "xxxxyyyyabklmopq"));
            Console.WriteLine(TaskOne.IndexSearcher.Search(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
            Console.ReadKey();
        }

    }
}
