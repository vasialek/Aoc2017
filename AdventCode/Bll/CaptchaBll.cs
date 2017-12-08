using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCode.Bll
{
    public class CaptchaBll
    {
        public int SumMatchingDigits(string s, int step = 1)
        {
            var matching = GetMatchingDigits(s, step);

            return matching?.Count > 0 ? matching.Sum() : 0;
        }

        public IList<int> GetMatchingDigits(string s, int step = 1)
        {
            return GetMatchingDigits(s.ToCharArray().Select(x => (int)x - (int)'0').ToArray(), step);
        }

        public IList<int> GetMatchingDigits(int[] digits, int step)
        {
            var matching = new List<int>();

            for (int i = 0; i < digits.Length; i++)
            {
                //int nextDigit = i == digits.Length - 1 ? digits[0] : digits[i + 1];
                int pos = i + step;
                int nextDigit = pos >= digits.Length ? digits[pos - digits.Length] : digits[pos];
                if (digits[i] == nextDigit)
                {
                    matching.Add(digits[i]);
                }
            }

            return matching;
        }
    }
}
