public class Solution {
    public int MajorityElement(int[] nums) {
        nums.Sort();
        return nums[nums.Length / 2];

    }
}