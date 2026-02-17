public class Solution {
    public IList<string> ReadBinaryWatch(int turnedOn)
    {
        if (turnedOn >= 9)
        {
            return [];
        }

        var res = new List<string>();
        for (var h = 0; h < 12; h++)
        {
            for (var m = 0; m < 60; m++)
            {
                if (BitOperations.PopCount((uint)h) + BitOperations.PopCount((uint)m) == turnedOn)
                {
                    res.Add(h.ToString() + ':' + m.ToString("00"));
                }
            }
        }

        return res;
    }
}