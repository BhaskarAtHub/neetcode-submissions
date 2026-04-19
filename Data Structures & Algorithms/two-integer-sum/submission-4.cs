public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++) {
            int index = Array.IndexOf(nums, target - nums[i], i + 1);
            if (index != -1 && index != i)
                return new int[] { i, index };
        }
        return null;
    }
}