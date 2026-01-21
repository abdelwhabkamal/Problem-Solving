public class Solution {
    public int[] MinBitwiseArray(IList<int> nums) {
    int[] res = new int[nums.Count];
    for(int i = 0; i < nums.Count; i++)
    {
        if (nums[i] == 2)
        {
            res[i] = -1;
            continue;
        }

        int temp = nums[i];
        int pow = -1;
        while(temp > 0 && (temp & 1) == 1)
        {
            temp >>= 1;
            pow++;
        }
        res[i] = nums[i] - (int)Math.Pow(2, pow);
    }
    return res;
    }
}