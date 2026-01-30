public class Solution {
    public long MinimumCost(string source, string target, string[] original, string[] changed, int[] cost) {
        Dictionary<string, List<(string, int)>> d = new ();
        for(int i=0; i<original.Length; i++)
        {
            if (!d.ContainsKey(original[i]))
            {
                d[original[i]] = new List<(string, int)>();
            }
            int costValue = -1;
            int index = 0;
            foreach(var x in d[original[i]])
            {
                if (x.Item1 == changed[i])
                {
                    costValue = x.Item2;
                    break;
                }
                index++;
            }
            if (costValue != -1) 
            {
                cost[i] = Math.Min(cost[i], costValue);
                d[original[i]].RemoveAt(index);
            }
            d[original[i]].Add((changed[i], cost[i]));
        }
        Dictionary<string, Dictionary<string, long>> mcost = new ();
        for(int i=0; i<original.Length; i++)
        {
            MinCost(original[i], d, mcost);
        }
        List<string> sources = mcost.Keys.ToList();
        sources.Sort((a, b) => b.Length.CompareTo(a.Length));
        Dictionary<int, Dictionary<string, long>> dp = new ();
        return FindCost(0, source, target, mcost, dp, sources);
    }

    private long FindCost(int i, string original, string target, Dictionary<string, Dictionary<string, long>> mcost, Dictionary<int, Dictionary<string, long>> dp, List<string> sources)
    {
        if (i == original.Length)
        {
           return 0;
        }
        if (!dp.ContainsKey(i))
        {
            dp[i] = new Dictionary<string, long>();
        }
        if (dp[i].ContainsKey(original))
        {
            return dp[i][original];
        }
        
        long totalCost = Int64.MaxValue;
        foreach(string s in sources) 
        {
            if (Matches(original, s, i))
            {
                //Console.WriteLine($"{original} : {s}");
                string targetSubstring = target.Substring(i, s.Length);
                if (mcost[s].ContainsKey(targetSubstring) && !targetSubstring.Equals(s))
                {
                    long c1 = mcost[s][targetSubstring];
                    //string replacedString = Replace(original, targetSubstring, i);
                    long c2 = FindCost(i+targetSubstring.Length, original, target, mcost, dp, sources);
                    if (c2 != -1)
                    {
                        totalCost = Math.Min(totalCost, (c1+c2));
                    }
                }
            }
        }
        if (original[i] == target[i]) 
        {
            long c3 = FindCost(i+1, original, target, mcost, dp, sources);
            if (c3 != -1)
            {
                totalCost = Math.Min(totalCost, c3);
            }
        }
        if (totalCost == Int64.MaxValue)
        {
            dp[i][original] = -1;
            return -1;
        }
        dp[i][original] = totalCost;
        return totalCost;
    }

    private string Replace(string org, string target, int i)
    {
        StringBuilder sb = new ();
        for(int j=0; j<org.Length; j++)
        {
            if (j < i || j >= (i + target.Length))
            {
                sb.Append(org[j]);
            } else {
                sb.Append(target[j-i]);
            }
        }
        return sb.ToString();
    }

    private bool Matches(string org, string s, int i)
    {
        for(int x=0; x<s.Length; x++)
        {
            if (i == org.Length || org[i] != s[x])
            {
                return false;
            }
            i++;
        }
        return true;
    }

    private void MinCost(string s, Dictionary<string, List<(string, int)>> d, Dictionary<string, Dictionary<string, long>> mcost)
    {
        Queue<(string, long)> q = new ();
        q.Enqueue((s, 0));
        while(q.Count > 0)
        {
            (string x, long t) = q.Dequeue();
            if (d.ContainsKey(x))
            {
                List<(string, int)> l = d[x];
                foreach(var p in l)
                {
                    string s1 = p.Item1;
                    long totalCost = t + p.Item2;
                    if (!mcost.ContainsKey(s) || !mcost[s].ContainsKey(s1) || mcost[s][s1] > totalCost)
                    {
                        if (!mcost.ContainsKey(s))
                        {
                            mcost[s] = new Dictionary<string, long>();
                        }
                        mcost[s][s1] = totalCost;
                        q.Enqueue((s1, totalCost));
                    }
                }
            }
        }
    }
}