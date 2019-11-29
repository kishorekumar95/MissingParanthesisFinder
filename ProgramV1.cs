using System;
using System.Collections.Generic;
using System.Linq;

namespace MissingParanthesisFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var givenString = "Kis(hore(umaro(ae)jgv(e()rqv()j(";

            var query = givenString.GroupBy(r => r).Where(s => s.Key == 40 || s.Key == 41)
                           .Select(s => new
                           {
                               Count = s.Count(),
                           }).ToList();

            Analyzer(query[0].Count - query[1].Count);
        }


        public static void Analyzer(int value)
        {
            if (value > 0)
            {
                Console.WriteLine($"Missing Close Paranthesis {value}");
            }
            else if (value < 0)
            {
                Console.WriteLine($"Missing Open Paranthesis {value * -1}");
            }
            else
            {
                Console.WriteLine("No Missing Paranthesis");
            }
        }
    }
}
