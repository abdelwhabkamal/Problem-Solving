public class Solution
{
    public int PivotIndex(int[] nums)
    {
        int leftSum = 0, pivotIndex;
        int rightSum = 0;
        for (int i = nums.Length - 1; i >= 0; i--)
            rightSum += nums[i];
        for (pivotIndex = 0; pivotIndex < nums.Length; pivotIndex++)
        {
            if (pivotIndex - 1 != -1)
                leftSum += nums[pivotIndex - 1];
            rightSum -= nums[pivotIndex];
            if (leftSum == rightSum)
                return pivotIndex;
        }
        return -1;
    }
}