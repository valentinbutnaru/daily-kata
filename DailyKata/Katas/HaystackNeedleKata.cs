using System;
using System.Collections.Generic;

namespace DailyKata
{
    public class HaystackNeedleKata
    {
        public static string FindNeedle(object[] haystack)
        {
            if (haystack == null)
            {
                throw new ArgumentNullException(nameof(haystack));
            }
            List<int> index = new List<int>();
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == null)
                {
                    continue;
                }
                if (haystack[i].ToString() == "needle")
                {
                    index.Add(i);
                }

            }
            if (index.Count != 0)
            {
                string result = "found the needle at position";
                foreach (var r in index)
                {
                    result += " " + r;
                }
                return result;
            }
            return "needle not found";
        }
    }
}
