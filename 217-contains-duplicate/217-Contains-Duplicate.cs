public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        nums.Sort();
        for (int i = 1; i<nums.Length; i++)
        {
            if (nums[i]==nums[i-1])
            {
                return true;
            }
           
        }
        return false;
    }
}