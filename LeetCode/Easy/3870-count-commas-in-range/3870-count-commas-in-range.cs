public class Solution {
    public int CountCommas(int n) => (n < 1000) ? 0 : n - 999;
}