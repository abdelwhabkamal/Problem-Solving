public class Solution {
    public int MaxDigitRange(int[] nums) {
        int n = nums.Length;
        int[] d = new int[n];
        int m_d = 0;
        for(int i = 0; i < n; i++){
            int min = int.MaxValue;
            int max = 0;
            int diff = 0;
            int curr = nums[i];
            while(curr > 0){
                min = Math.Min(min , curr%10);
                max = Math.Max(max , curr%10);
                curr /= 10;
                diff = max - min;
            }
            m_d = Math.Max(m_d , diff);
            d[i] = diff;
        }
        int res = 0;
        for(int i = 0; i < n; i++){
            if(d[i] == m_d) res += nums[i];
        }
        return res;
    }
}