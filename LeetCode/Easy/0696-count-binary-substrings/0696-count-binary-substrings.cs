public class Solution
{
    public int CountBinarySubstrings(string InputString)
    {
        int p = 0;
        int c = 1;
        int t = 0;

        for (int i = 1; i < InputString.Length; i++)
        {
            if (InputString[i] == InputString[i - 1])
                c++;
            else
            {
                p = c;
                c = 1;
            }

            if (p >= c)
                t++;
        }

        return t;
    }
}