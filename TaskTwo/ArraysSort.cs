using System;
using System.Linq;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("TaskTwoTest")]
namespace TaskTwo
{
    /// <summary>
    /// Class sort two unsorted string
    /// </summary>
    public static class ArraysSort
    {
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

            if ((strOne.All(u => u >= 'a' && u <= 'z')) && (strTwo.All(u => u >= 'a' && u <= 'z')))
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
        internal static string ConcatStr(string strOne, string strTwo)
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
