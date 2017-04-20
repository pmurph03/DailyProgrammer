using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DailyProgrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Jollyness jollyProgram = new Jollyness();
            jollyProgram.RunJollyProgram();
            Console.ReadLine();
        }

        static string ArrayValuesToString(int[] array)
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
                    if (absDifferences[difference-1] != 0)
                    { //if array position is already filled, then supplied array is not jolly by definition.
                        return "NOT JOLLY";
                    }
                    absDifferences[difference-1] = difference;
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
