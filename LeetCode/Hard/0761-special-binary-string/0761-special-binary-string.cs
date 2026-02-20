public class Solution
{
    public string MakeLargestSpecial(string s)
    {
        List<string> specials = new List<string>();    
        int count = 0;      
        int start = 0;     

        for (int i = 0; i < s.Length; i++)
        {
            count += (s[i] == '1') ? 1 : -1;

            if (count == 0)
            {
                string inner = s.Substring(start + 1, i - start - 1);

                string processed = "1" + MakeLargestSpecial(inner) + "0";

                specials.Add(processed);                           

                start = i + 1;                                  
            }
        }

        specials.Sort((a, b) => string.Compare(b, a));

        StringBuilder result = new StringBuilder();
        foreach (string str in specials)
        {
            result.Append(str);
        }

        return result.ToString();
    }
}