public class NumArray {
    int[] arr;
    public NumArray(int[] nums) {
        arr=nums;
    }
    
    public int SumRange(int left, int right) {
        int sum=0;
        for(int i=left;i<=right;i++){
            sum+=arr[i];
        }
        return sum;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */