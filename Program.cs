using System;

namespace MissingParanthesisFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var givenString = "Kis(hore(umaroae)jgv(e)rq))(v)j";
            Analyzer(FindMissingParan(givenString));
        }

        public static int FindMissingParan(string str)
        {
            int open = 0;
            int close = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == "(")
                    open++;
                if (str[i].ToString() == ")")
                    close++;
            }
            Console.WriteLine($"Open : {open} , Closed : {close}");
            return open - close;

        }

        public static void Analyzer(int value)
        {
            if (value > 0)
            {
                Console.WriteLine($"Missing Close Paranthesis {value}");
            }
            else if (value < 0)
            {
                Console.WriteLine($"Missing Open Paranthesis {value * - 1}");
            }
            else
            {
                Console.WriteLine("No Missing Paranthesis");
            }
        }
    }
}
