public class Solution {
    public char ProcessStr(string s, long k) {
            long length = 0;
            foreach (char c in s)
            {
                if (c == '*')
                    length = length > 0 ? length - 1 : 0;
                else if (c == '#')
                    length *= 2;
                else if (c != '%')
                    length++;
            }

            if (k >= length)
                return '.';

            char result = '.';

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '*')
                {
                    length++;
                }
                else if (s[i] == '#')
                {
                    length /= 2;
                    if (k >= length)
                        k -= length;
                }
                else if (s[i] == '%')
                {
                    k = length - k - 1;
                }
                else
                {
                    length--;
                    if (length == k)
                    {
                        result = s[i];
                        break;
                    }
                }
            }

            return result;
    }
}