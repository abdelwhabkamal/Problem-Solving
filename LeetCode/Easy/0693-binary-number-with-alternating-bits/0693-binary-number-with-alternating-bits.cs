public class Solution {
    public bool HasAlternatingBits(int n) => (n & (n >> 1)) == 0 && (n | (n >> 2)) == n;
}