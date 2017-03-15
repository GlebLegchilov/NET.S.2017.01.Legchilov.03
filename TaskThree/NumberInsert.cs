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
            if (indexOne > indexTwo)
                throw new Exception("Incorrect parameters");
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
        private static int InsertionMaster(int numberOne, int numberTwo, int indexOne, int indexTwo)
        {
            int[] numerOneBinary = GetBinaryRepresentation(numberOne);
            int[] numerTwoBinary = GetBinaryRepresentation(numberTwo);
            int j = 0;
            for (int i = indexOne; i <= indexTwo; i++)
            {
                numerOneBinary[i] = numerTwoBinary[j++];
            }
            return GetDecimalRepresentation(numerOneBinary);
        }


        /// <summary>
        /// Return binary representation of decimal number
        /// </summary>
        /// <param name="numberDecimel">Decimel number</param>
        /// <returns>Int's array</returns>
        private static int[] GetBinaryRepresentation(int numberDecimel)
        {
            int[] result = new int[32];
            if (numberDecimel < 0)
            {
                numberDecimel = numberDecimel * (-1);
                result[31] = 1;
            }
            int j = 0;
            while (numberDecimel > 0)
            {
                int m = numberDecimel % 2;
                numberDecimel = numberDecimel / 2;
                result[j++] = m;
            }
            return result;
        }


        /// <summary>
        /// Return decimal representation of binary number
        /// </summary>
        /// <param name="numberBinary">Int's array</param>
        /// <returns>Decimal number</returns>
        private static int GetDecimalRepresentation(int[] numberBinary)
        {
            int result = 0;
            for(int i = 30; i>=0; i--)
            {
                result = result + (int)Math.Pow((numberBinary[i]*2), i);
            }
            if (numberBinary[31] == 1)
                result = result * (-1);
            return result;
        }
        #endregion
    }

}
