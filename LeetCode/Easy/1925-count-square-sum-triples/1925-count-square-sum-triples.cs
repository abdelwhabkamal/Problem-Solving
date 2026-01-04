public class Solution {
    public int CountTriples(int n) {
        int ans =0;
        for(int a=1;a<=n;a++){
            for(int b=a+1;b<=n;b++){
                int ab=a*a+b*b;
                for(int c=Math.Max(a,b);c<=n;c++){
                    if(ab == c*c){
                        ans+=2;
                    } 
                }
            }
        }
        return ans;
    }
}