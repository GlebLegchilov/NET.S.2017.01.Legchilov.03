using System;
using System.Linq;

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
        public static int SearchMaster(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (Sum(array.Take(i).ToArray()) == Sum(array.Skip(i+1).ToArray()))
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Find sum of array's numbers
        /// </summary>
        /// <param name="array">Number's array</param>
        /// <returns>Sum</returns>
        private static int Sum(int[] array)
        {
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            return sum;
        }
        #endregion  

    }
}
