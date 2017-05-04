using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer
{
    /// <summary>
    /// Given a sorted list of distinct integers, write a function that determines weather there are two ints in the list that add up to 0.
    /// ie: -14335 and 14335 is true because -14335+14335 = 0
    /// also return true if 0 appears in the list
    /// </summary>
    class SubsetSum
    {
        public void RunSubsetSum()
        {
            int[] set1 = new int[3] { 1, 2, 3 };
            int[] set2 = new int[6] { -5, -3, -1, 2, 4, 6 };
            int[] set3 = new int[0];
            int[] set4 = new int[2] {-1,1};
            int[] set5 = new int[6] {-97364, -71561, -69336, 19675, 71561, 97863};
            int[] set6 = new int[6] {-53974,-39140,-36561,-23935,-15680,0};

            Console.WriteLine(ArrayValuesToString(set1) + DoesIntArrayContainSubsetSumOfZero(set1));
            Console.WriteLine(ArrayValuesToString(set2) + DoesIntArrayContainSubsetSumOfZero(set2));
            Console.WriteLine(ArrayValuesToString(set3) + DoesIntArrayContainSubsetSumOfZero(set3));
            Console.WriteLine(ArrayValuesToString(set4) + DoesIntArrayContainSubsetSumOfZero(set4));
            Console.WriteLine(ArrayValuesToString(set5) + DoesIntArrayContainSubsetSumOfZero(set5));
            Console.WriteLine(ArrayValuesToString(set6) + DoesIntArrayContainSubsetSumOfZero(set6));

            set1 = new int[4] {0, 1, 2, 3 };
            set2 = new int[7] {0, -5, -3, -1, 2, 4, 6 };
            set3 = new int[1] {0};
            set4 = new int[3] {0, -1, 1 };
            set5 = new int[7] {0, -97364, -71561, -69336, 19675, 71561, 97863 };
            set6 = new int[7] {0, -53974, -39140, -36561, -23935, -15680, 0 };

            Console.WriteLine("FasterSolution:");
            SetArrayNegativeToPositiveLocation(set1);
            SetArrayNegativeToPositiveLocation(set2);
            SetArrayNegativeToPositiveLocation(set3);
            SetArrayNegativeToPositiveLocation(set4);
            SetArrayNegativeToPositiveLocation(set5);
            SetArrayNegativeToPositiveLocation(set6);
            Console.WriteLine(ArrayValuesToString(set1) + DoesIndexedSubsetContainZeroSum(set1));
            Console.WriteLine(ArrayValuesToString(set2) + DoesIndexedSubsetContainZeroSum(set2));
            Console.WriteLine(ArrayValuesToString(set3) + DoesIndexedSubsetContainZeroSum(set3));
            Console.WriteLine(ArrayValuesToString(set4) + DoesIndexedSubsetContainZeroSum(set4));
            Console.WriteLine(ArrayValuesToString(set5) + DoesIndexedSubsetContainZeroSum(set5));
            Console.WriteLine(ArrayValuesToString(set6) + DoesIndexedSubsetContainZeroSum(set6));
        }

        /// <summary>
        /// simple solution
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns></returns>
        bool DoesIntArrayContainSubsetSumOfZero(int[] intArray)
        {
            int length = intArray.Length;
            for (int i = 0; i < length; ++i)
            {
                if (intArray[i] == 0)
                {
                    return true;
                }
                for (int j = i + 1; j < length; ++j)
                {
                    if (intArray[i] + intArray[j] == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Sets intArray[0] to index in array where negative value becomes positive
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns></returns>
        int[] SetArrayNegativeToPositiveLocation (int[] intArray)
        {
            for (int i = 1; i < intArray.Length-1; ++i)
            {
                if (intArray[i] < 0 && intArray[i+1] >= 0)
                {
                    intArray[0] = i+1;
                    return intArray;
                }
            }
            intArray[0] = -1;
            return intArray;
        }

        bool DoesIndexedSubsetContainZeroSum(int[] array)
        {
            if (array[0] < 0 )
            {
                return false;
            }
            else if (array[0] == 0)
            {
                return true;
            }
            for (int i = 0; i < array[0]; ++i)
            {
                for (int j = array.Length-1; j >= array[0]; --j)
                {
                    if (array[i] + array[j] == 0)
                    {
                        return true;
                    }
                    else if (array[j] == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Converts integer array to a nicely spaced string of ints.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private string ArrayValuesToString(int[] array)
        {
            string arrayAsString = "ArrayLength:" + array.Length + " array:";
            for (int i = 0; i < array.Length; i++)
            {
                arrayAsString += array[i] + " ";
            }
            return arrayAsString;
        }
    }
}
