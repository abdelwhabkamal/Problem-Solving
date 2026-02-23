public class Solution {
    public bool HasAllCodes(string s, int k) {
    int totalNeeded = 1 << k; 
    if (s.Length < k + totalNeeded - 1) return false;

    bool[] found = new bool[totalNeeded];
    int count = 0;
    int currentNum = 0;
    
    int mask = totalNeeded - 1;

    for (int i = 0; i < s.Length; i++) {
        currentNum = ((currentNum << 1) & mask) | (s[i] - '0');

        if (i >= k - 1) {
            if (!found[currentNum]) {
                found[currentNum] = true;
                count++;
                if (count == totalNeeded) return true;
            }
        }
    }

    return count == totalNeeded;
}
}