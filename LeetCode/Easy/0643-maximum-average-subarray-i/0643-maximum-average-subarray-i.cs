public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double cur=0;
        double avg=double.MinValue;
        int l=0;
        int r=k-1;
        double sum=0;
        for(int i=0;i<=r;i++){
            sum+=nums[i];
        }
        avg=sum/k;
        l++;
        r++;
        while(r<nums.Length){
            sum-=nums[l-1];
            sum+=nums[r];
            avg=Math.Max(avg,sum/k);
            r++;
            l++;
        }
        return avg;
    }
}