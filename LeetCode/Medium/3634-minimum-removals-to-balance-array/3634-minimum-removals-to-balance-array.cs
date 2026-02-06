public class Solution {
    public int BinarySearch(int minInd,int[] nums,int k)
    {
        int n=nums.Length;
        int lo=minInd+1;
        int hi=n-1;
        int  ans=-1;

        while(lo<=hi)
        {
            int mid=(lo+hi)/2;

            long min=nums[minInd];
            long max=nums[mid];
            long prod=min*k;
            if(max<=prod)
            {
                ans=mid;
                lo=mid+1;
            }
            else
            {
                hi=mid-1;
            }
            
        }

        return ans;
    }
     
    public int MinRemoval(int[] nums, int k) 
    {
        int n=nums.Length;

        Array.Sort(nums);

        long min=nums[0];
        long max=nums[n-1];
        long prod=min*k;
      
        if(max<=prod)
        {
            return 0;
        }
        
        int ans=int.MaxValue;
        for(int i=0;i<n;i++)
        {
            int maxInd=BinarySearch(i,nums,k);

            if(maxInd==-1)
            {
                continue;
            }
            
            int removals=(n-maxInd-1)+i;
            ans=Math.Min(ans,removals);
        }
 
        return ans==int.MaxValue?n-1:ans;
    }
}