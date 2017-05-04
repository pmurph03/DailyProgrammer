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
            

            //Jollyness jollyProgram = new Jollyness();
            //jollyProgram.RunJollyProgram();
            //Console.ReadLine();
            SubsetSum subsetProgram = new SubsetSum();
            subsetProgram.RunSubsetSum();
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

        
    }
}
