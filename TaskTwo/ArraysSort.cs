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
        /// Sort and concat two string
        /// </summary>
        /// <param name="strOne">First unsorted string</param>
        /// <param name="strTwo">Second unsorted string</param>
        /// <returns>New string</returns>
        public static string Longest(string strOne, string strTwo)
        {
            if ((strOne == null) || (strTwo == null))
                throw new ArgumentNullException();

            if ((Regex.IsMatch(strOne, pattern, RegexOptions.None)) && (Regex.IsMatch(strTwo, pattern, RegexOptions.None)))
            {
                return ConcatStr(strOne, strTwo);
            }
            else
            {
                throw new ArgumentException();
            }      
        }
        #endregion

            #region Logic 
        /// <summary>
        /// Sort and concat two string
        /// </summary>
        /// <param name="strOne">First unsorted string</param>
        /// <param name="strTwo">Second unsorted string</param>
        /// <returns>New string</returns>
        public static string ConcatStr(string strOne, string strTwo)
        {
            var result = Enumerable.Distinct((string.Concat(strOne, strTwo)).OrderBy(x => x)).ToArray();
            string strRes = string.Empty;
            foreach (char item in result)
                strRes += item;
            return strRes;
        }
        #endregion
    }
}
