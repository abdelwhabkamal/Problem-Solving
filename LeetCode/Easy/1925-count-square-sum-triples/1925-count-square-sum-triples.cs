public class Solution {
    public int CountTriples(int n) {
        int ans =0;
        for(int a=1;a<=n;a++){
            for(int b=1;b<=n;b++){
                int ab=a*a+b*b;
                for(int c=1;c<=n;c++){
                    if(ab == c*c){
                        ans+=1;
                    } 
                }
            }
        }
        return ans;
    }
}