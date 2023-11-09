using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3TaskSolution_Sq019
{
    internal static class Q3
    {
        public static List<string> states = new List<string>
        {
            "Abia","Adamawa","Akwa-Ibom","Anambra","Bauchi","Bayelsa",
            "Benue","Borno","Cross-River","Delta","Ebonyi","Edo",
            "Ekiti","Enugu","Gombe","Imo","Jigawa","Kaduna",
            "Kano","Kastina","Kebbi","Kogi","Kwara","Lagos",
            "Nasarawa","Niger","Ogun","Ondo","Osun","Oyo",
            "Plateau","Rivers","Sokoto","Taraba","Yobe","Zamfara",
        };
        public static List<char> alphabets = new List<char>
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 
            'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
            'U', 'V', 'W', 'X', 'Y', 'Z'
        };

        public static void PrintResult()
        {
            var GroupJoined = alphabets.GroupJoin(states, a => a, s => s.ToUpper()[0], (a, s) => new
            {
                key = a,
                states = s
            });

            foreach(var g in GroupJoined)
            {
                Console.WriteLine();
                if(g.states != null && g.states.Count() > 0)
                {
                    Console.WriteLine($"Group {g.key} - {g.states.Count()}\n");
                    foreach (var s in g.states)
                    {
                        Console.WriteLine(s);
                    }
                }
                else
                {
                    Console.WriteLine($"Group {g.key} - 0\n");
                    Console.WriteLine("None");
                }
                Console.WriteLine();

            }

        }
    }
}
