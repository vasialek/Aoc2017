using AdventCode.Bll;
using AdventCode.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string[] lines = null;
            int result = 0;

            //// Day 01
            //input = File.ReadAllText("Data\\input01.txt");
            //Console.WriteLine(input);
            //Console.WriteLine("Step is {0}", input.Length / 2);
            //sum = new CaptchaBll().SumMatchingDigits(input, input.Length / 2);
            //Console.WriteLine("Sum is: {0}", sum);

            //// Day 02
            //lines = File.ReadAllLines("Data\\input02.txt");
            //result = 0;
            //var bll = new ChecksumBll();
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    Console.WriteLine(lines[i]);
            //    int cs = bll.CalculateChecksum(lines[i]);
            //    Console.WriteLine("Checksum: {0}", cs);
            //    result += cs;
            //}
            //Output(ConsoleColor.Green, "Checksum is: {0}", result);

            //// Day 03
            //var bll = new SpiralBll();
            //var ar2d = bll.GenerateSpiralMemory(325489);
            //string s = VisualHelper.DumpArray2d(ar2d, 6);
            //int result = bll.CalculateDistance(ar2d, 325489);
            //Output(ConsoleColor.Green, "Distance is: {0}", result);

            //// Day 04
            //result = 0;
            //lines = File.ReadAllLines("Data\\input04.txt");
            //var bll = new PasswordBll();
            //for (int i = 0; i < lines?.Length; i++)
            //{
            //    // Valid has not duplicates
            //    //if (bll.HasDuplicateWords(lines[i]) == false)
            //    //{
            //    //    result++;
            //    //}
            //    if (bll.HasAnagrams(lines[i]) == false)
            //    {
            //        result++;
            //    }

            //}
            //Output(ConsoleColor.Green, "Total valid passwords: {0}", result);
        }

        private static void Output(ConsoleColor color, string fmt, params object[] args)
        {
            var c = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(fmt, args);
            Console.ForegroundColor = c;
        }

    }
}
