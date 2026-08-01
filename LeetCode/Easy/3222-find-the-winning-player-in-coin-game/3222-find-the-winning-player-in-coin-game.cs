public class Solution {
    public string WinningPlayer(int x, int y) {
        int num = 0;
        while(x > 0 && y > 3){
            num++;
            x--;
            y -= 4;
        }
        if(num % 2 == 0 || num == 0) return "Bob";
        return "Alice";
    }
}