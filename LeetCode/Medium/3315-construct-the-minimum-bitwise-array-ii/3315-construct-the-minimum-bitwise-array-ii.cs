public class Solution {
    public int[] MinBitwiseArray(IList<int> nums) {
        var result = new int[nums.Count];
        for(int i = 0; i < nums.Count; i++)
        {
            var mPow = (int)Math.Floor(Math.Log2(nums[i])); //get the position of the highest bit 0 indexed, 7 --> 2, 11 -> 3 etc
            for(int j = mPow; j >= 0; j--) //start unsetting the highest bit position until the lowest.
            {
                var v = nums[i] - (int)Math.Pow(2, j); //calculate the value of the current hightest bit 7 --> 4, 11 -> 8, 17 -> 16
                if(((v + 1 ) | v) == nums[i]) //check if its valid
                {
                    result[i] = v;
                    break;
                }
            }
            if(result[i] == 0)
                result[i] =  ((nums[i] - 1) | nums[i]) == nums[i] ? nums[i] - 1 : -1; //if everything fails check itself and - 1, if this fails its edge case -1
        }
        return result;
    }
}