public class Solution {
    public int[] CircularGameLosers(int n, int k) {
        if(n == 1) return [];
        bool[] recieved = new bool[n];
        recieved[0] = true;
        int next = (k + n) % n;
        int c = 2;
        while(!recieved[next]){
            recieved[next] = true;
            next =  (next + c*k) % n ;
            c++;
        }
        int[] res = new int[n - c + 1];
        int index = 0;
        for(int i = 1; i < n; i++){
            if(!recieved[i]){
                res[index] = i+1;
                index++;
            } 
        }
        return res;
    }
}