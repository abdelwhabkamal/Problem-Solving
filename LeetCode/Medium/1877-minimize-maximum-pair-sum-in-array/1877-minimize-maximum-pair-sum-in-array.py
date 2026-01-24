class Solution:
    def minPairSum(self, nums: List[int]) -> int:
        nums=sorted(nums)
        m=nums[-1]
        p=[]
        p.append(m+nums[0])
        for i in range(1,len(nums)-2,2):
                p.append(nums[i]+nums[-i-1])
        return max(p)
