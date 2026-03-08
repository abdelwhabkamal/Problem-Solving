public class Solution {
    public string FindDifferentBinaryString(string[] nums) {
        string ans = "";
        for(int i=0;i<nums.Length;i++){
            if(nums[i][i]=='0') ans+='1';
            else ans+='0';
        }
        return ans;
    }
}