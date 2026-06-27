public class Solution {
    public int MaximumLength(int[] nums) {
        Dictionary<long,int> freq = new();
        foreach(int num in nums){
            if(!freq.ContainsKey(num)) freq[num] = 0;
            freq[num]++;
        }

        int res = 1;

        if(freq.ContainsKey(1)){
            int ones = freq[1];
            if(ones % 2 == 0) ones--; 
            res = Math.Max(res, ones);
        }

        foreach(var kvp in freq){
            long x = kvp.Key;
            if(x == 1) continue;

            int cur = 0;
            if(kvp.Value >= 2){
                cur += 2;
                long j = x * x;
                while(freq.ContainsKey(j)){
                    if(freq[j] >= 2){
                        cur += 2;
                    } else if(freq[j] == 1){
                        cur += 1;
                        break;
                    } else break;
                    j *= j;
                }
                if(cur % 2 == 0) cur--; 
                res = Math.Max(res, cur);
            }
        }
        return res;
    }
}
