public class Solution {
    public int LongestConsecutive(int[] nums) {
    if (nums.Length == 0) return 0;
    
    HashSet<int> numSet = new(nums);
    
    int maxLength = 0;
    
    foreach (int num in numSet)
    {
        if (!numSet.Contains(num - 1))
        {
            int currentNum = num;
            int currentLength = 1;
            
            while (numSet.Contains(currentNum + 1))
            {
                currentNum++;
                currentLength++;
            }
            maxLength = Math.Max(maxLength, currentLength);
        }
    }
    
    return maxLength;
    }
}