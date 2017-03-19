using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskThree
{
    /// <summary>
    /// Class insert one number to another
    /// </summary>
    public static class NumberInsertion
    {

            #region Interface 
        /// <summary>
        /// Insert one number to another
        /// </summary>
        /// <param name="numberOne">First number</param>
        /// <param name="numberTwo">Second number</param>
        /// <param name="indexOne">First index</param>
        /// <param name="indexTwo">Second index</param>
        /// <returns>New number</returns>
        public static int Insertion(int numberOne, int numberTwo, int indexOne, int indexTwo)
        {
            
            if ((indexOne < 0) || (indexOne > 30) || (indexTwo < 0) || (indexTwo > 30))
                throw new ArgumentOutOfRangeException();
            if (indexOne > indexTwo)
                throw new ArgumentException();
            return InsertionMaster(numberOne, numberTwo, indexOne, indexTwo);
        }
        #endregion

            #region Logic 
        /// <summary>
        /// Insert one number to another
        /// </summary>
        /// <param name="numberOne">First number</param>
        /// <param name="numberTwo">Second number</param>
        /// <param name="indexOne">First index</param>
        /// <param name="indexTwo">Second index</param>
        /// <returns>New number</returns>
        public static int InsertionMaster(int numberOne, int numberTwo, int indexOne, int indexTwo)
        {
            uint uNumberOne = (uint)numberOne;
            uint uNumberTwo = (uint)numberTwo;
            uint mask = UInt32.MaxValue;
            mask <<= 32 - (indexTwo - indexOne + 1);
            mask >>= 32 - (indexTwo + 1);
            uNumberTwo <<= indexOne;
            uNumberTwo &= mask;
            uNumberOne &= ~mask;
            return (int)(uNumberOne | uNumberTwo);
        }
        #endregion
    }

}
