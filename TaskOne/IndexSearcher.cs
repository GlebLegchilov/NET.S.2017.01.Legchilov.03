using System;
using System.Linq;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("TaskOneTest")]
namespace TaskOne
{
    /// <summary>
    /// Class search some special index
    /// </summary>
    public static class IndexSearcher
    {
            #region Interface
        /// <summary>
        /// Search some special index
        /// </summary>
        /// <param name="array">Number's array</param>
        /// <returns>Index</returns>
        public static int Search(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }
            if (array.Length >1000)
            {
                throw new ArgumentOutOfRangeException();
            }
            return SearchMaster(array);
        }
        #endregion

            #region Logic 
        /// <summary>
        /// Search some special index
        /// </summary>
        /// <param name="array">Number's array</param>
        /// <returns>Index</returns>
        internal static int SearchMaster(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array.Take(i).ToArray().Sum() == array.Skip(i+1).ToArray().Sum())
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion  

    }
}
