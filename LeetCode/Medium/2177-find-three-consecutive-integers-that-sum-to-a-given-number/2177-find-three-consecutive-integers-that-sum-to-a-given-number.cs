public class Solution {
    public long[] SumOfThree(long num) => (num % 3 == 0) ? [num/3 -1 , num/3, num/3 +1] : [];
}