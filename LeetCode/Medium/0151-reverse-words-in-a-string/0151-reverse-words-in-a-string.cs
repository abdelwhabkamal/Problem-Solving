public class Solution
{
    public string ReverseWords(string s)
    {
        StringBuilder result = new();

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ' ')
                continue;

            int j = i;
            while (j > 0 && s[j - 1] != ' ')
            {
                j--;
            }

            result.Append(s[j..(i + 1)]);

            bool lastSpace = false;
            int k = j - 1;
            while (k >= 0)
            {
                if (s[k] != ' ')
                {
                    lastSpace = true;
                    break;
                }

                k--;
            }

            if (lastSpace)
                result.Append(' ');

            i = j;
        }

        return result.ToString();
    }
}