using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCode.Bll
{
    public class ChecksumBll
    {
        public int CalculateChecksum(string digits)
        {
            return CalculateChecksum(TsvToNumbers(digits));
        }

        public int CalculateChecksum(int[] digits)
        {
            var t = GetMinMax(digits);

            return t.Item2 - t.Item1;
        }

        public Tuple<int, int> GetMinMax(string s)
        {
            //return GetMinMax(s.ToCharArray().Select(x => (int)x - (int)'0').ToArray());
            return GetMinMax(TsvToNumbers(s));
        }

        public Tuple<int, int> GetMinMax(int[] digits)
        {
            return new Tuple<int, int>(digits.Min(), digits.Max());
        }

        public int[] TsvToNumbers(string s)
        {
            string[] ar = s.Split("\t".ToCharArray());
            return ar.Select(x => Convert.ToInt32(x)).ToArray();
        }
    }
}
