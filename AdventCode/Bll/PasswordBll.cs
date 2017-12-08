using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCode.Bll
{
    public class PasswordBll
    {
        public bool IsAnagram(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            if (s1 == s2)
            {
                return true;
            }

            // Length of both are equals
            char[] ca1 = s1.ToCharArray()
                .OrderBy(x => x).ToArray();
            char[] ca2 = s2.ToCharArray()
                .OrderBy(x => x).ToArray();

            for (int i = 0; i < ca1.Length; i++)
            {
                if (ca1[i] != ca2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public bool HasAnagrams(string sentence)
        {
            string[] words = sentence.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words?.Length; i++)
            {
                // From next word only
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (IsAnagram(words[i], words[j]))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool HasDuplicateWords(string sentence)
        {
            bool has = false;
            string[] words = sentence.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words?.Length; i++)
            {
                if (words.Count(x => x == words[i]) > 1)
                {
                    return true;
                }
            }

            return has;
        }
    }
}
