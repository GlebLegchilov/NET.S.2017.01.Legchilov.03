using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace TaskTwo
{
    /// <summary>
    /// Class sort two unsorted string
    /// </summary>
    public static class ArraysSort
    {
        /// <summary>
        /// Mask for regular expression
        /// </summary>
        const string pattern = @"^[a-z]*$";

            #region Interface 
        /// <summary>
        /// Sort two unsorted string
        /// </summary>
        /// <param name="strOne">First unsorted string</param>
        /// <param name="strTwo">Second unsorted string</param>
        /// <returns>New string</returns>
        public static string Longest(string strOne, string strTwo)
        {
            if ((Regex.IsMatch(strOne, pattern, RegexOptions.None)) && (Regex.IsMatch(strTwo, pattern, RegexOptions.None)))
            {
                return ConcatStr(strOne, strTwo);
            }
            else
            {
                throw new Exception("Incorrect parameters");
            }      
        }
        #endregion

            #region Logic 
        /// <summary>
        /// Sort two unsorted string
        /// </summary>
        /// <param name="strOne">First unsorted string</param>
        /// <param name="strTwo">Second unsorted string</param>
        /// <returns>New string</returns>
        private static string ConcatStr(string strOne, string strTwo)
        {
            String newStr =  String.Concat(strOne, strTwo);
            newStr =  string.Concat(newStr.OrderBy(x => x).ToArray());

            string finalStr = "";
            char symbol = ' ';
            foreach (char item in newStr)
            {
                if (symbol != item)
                {
                    symbol = item;
                    finalStr = finalStr + item;
                }
            }
            return finalStr;
        }
        #endregion
    }
}
