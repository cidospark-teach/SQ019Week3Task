using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3TaskSolution_Sq019
{
    internal static class Q1
    {
        /*
         Write a CSharp program to split a collection of the 36 states in Nigeria into 
        some nth number of groups. (Requirement: Must use group here)
         */

        public static List<string> states = new List<string>
        {
            "Abia","Adamawa","Akwa-Ibom","Anambra","Bauchi","Bayelsa",
            "Benue","Borno","Cross-River","Delta","Ebonyi","Edo",
            "Ekiti","Enugu","Gombe","Imo","Jigawa","Kaduna",
            "Kano","Kastina","Kebbi","Kogi","Kwara","Lagos",
            "Nasarawa","Niger","Ogun","Ondo","Osun","Oyo",
            "Plateau","Rivers","Sokoto","Taraba","Yobe","Zamfara",
        };

        public static void PrintResult(int groupSize)
        {
            var grouped = from index in Enumerable.Range(0, states.Count())
                            group states[index] by index / groupSize;

            foreach (var perGroup in grouped)
            {
                Console.WriteLine(string.Join(", ", perGroup.ToArray()));
                Console.WriteLine();
            }
        }
    }
}
