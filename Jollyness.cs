using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DailyProgrammer
{
    /// <summary>
    /// Desc: A sequence of n>0 ints is called a jolly jumper if the abs values of the differences
    /// between the successive elements take on all possible values through n-1 (which may include negative numbers)
    /// IE. 1, 4, 2, 3 is jolly jumper because n = 4, and the differences between the elements through n-1 is
    /// 1->4 = 3, 4->2=2 2->3 = 1. ie 3,2,1 respectively.
    /// The definition implies any sequence of a single integer is a jolly jumper.
    /// write a program to determine wheter each of a number of sequences is a jolly jumper.
    /// </summary>
    /// 
    /// input description:
    /// given a row of numbers, first number tells you the number of ints to calculate over (n)
    /// followed by n integers to calculate the differences.
    /// example: 4 1 4 2 3, n=4, n integers = 1, 4,2,3
    /// output should indicate if it is a jolly or not.
    class Jollyness
    {
        /// <summary>
        /// Runs the jollyness program.
        /// </summary>
        public void RunJollyProgram()
        {
            int[] jolly1 = new int[4] { 1, 4, 2, 3 };
            int[] jolly2 = new int[5] { 1, 4, 2, -1, 6 };
            int[] jolly3 = new int[4] { 19, 22, 24, 21 };
            int[] jolly4 = new int[4] { 19, 22, 24, 20 };
            int[] jolly5 = new int[4] { 2, -1, 0, 2 };
            Console.WriteLine(ArrayValuesToString(jolly1) + IsIntArrayJolly(jolly1));
            Console.WriteLine(ArrayValuesToString(jolly2) + IsIntArrayJolly(jolly2));
            Console.WriteLine(ArrayValuesToString(jolly3) + IsIntArrayJolly(jolly3));
            Console.WriteLine(ArrayValuesToString(jolly4) + IsIntArrayJolly(jolly4));
            Console.WriteLine(ArrayValuesToString(jolly5) + IsIntArrayJolly(jolly5));
        }

        /// <summary>
        /// Converts integer array to a nicely spaced string of ints.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private string ArrayValuesToString(int[] array)
        {
            string arrayAsString = "";
            for (int i = 0; i < array.Length; i++)
            {
                arrayAsString += array[i] + " ";
            }
            return arrayAsString;
        }

        /// <summary>
        /// Calculates if supplied integer array is jolly or not.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static string IsIntArrayJolly(int[] array)
        {
            int[] absDifferences = new int[array.Length - 1];
            for (int i = 1; i < array.Length; i++)
            {
                int difference = array[i] - array[i - 1];
                if (difference < 0)
                {
                    difference *= -1;
                }
                if (difference <= (array.Length - 1))
                {
                    if (absDifferences[difference - 1] != 0)
                    { //if array position is already filled, then supplied array is not jolly by definition.
                        return "NOT JOLLY";
                    }
                    absDifferences[difference - 1] = difference;
                }
                else
                { //if absolute difference is greater than n-1, then supplied array is not jolly.
                    return "NOT JOLLY";
                }
            }
            //absDifference array is already sorted from 1 to n-1.
            //thus int array must be jolly.
            return "JOLLY";
        }
    }
}
