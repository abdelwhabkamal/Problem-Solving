public class Solution {
    public int LongestConsecutive(int[] nums) {
    HashSet<int> numSet = new(nums);
    int maxLength = 0;
    
    foreach (int num in numSet)
    {
        if (!numSet.Contains(num - 1))
        {
            int currentLength = 1;
            while (numSet.Contains(num + currentLength))
            {
                currentLength++;
            }
            maxLength = Math.Max(maxLength, currentLength);
        }
    }
    return maxLength;
    }
}