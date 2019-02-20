using System;

namespace PadawansTask6
{
    public static class NumberFinder
    {
        public static int? NextBiggerThan(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException();
            }

            if (number < 12 || number == int.MaxValue)
            {
                return null;
            }

            string nums = number.ToString();
            char[] num = nums.ToCharArray();
            string result;

            for (int i = number + 1; ; i++)
            {
                result = i.ToString();
                char[] res = result.ToCharArray();
                if (res.Length > num.Length)
                {
                    return null;
                }
                Array.Sort(res);
                Array.Sort(num);
                string finRes = new string(res);
                string finNum = new string(num);
                if (finRes.Equals(finNum)) return i;
                else continue;
            }
        }
    }
}
