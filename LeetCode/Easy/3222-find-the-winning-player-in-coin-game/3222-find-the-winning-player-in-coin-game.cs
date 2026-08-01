public class Solution {
    public string WinningPlayer(int x, int y) {
        if(Math.Min(x, y/4) % 2 == 0) return "Bob";
        return "Alice";
    }
}