class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        for index,num in enumerate(nums):
            remaining = target - num
            if remaining in nums[index+1:]:
                targetIndex = nums.index(remaining,index+1)
                return [index,targetIndex]

        return null



        