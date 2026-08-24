public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var hashedNums = new HashSet<int>(nums);

        if (nums.Length == hashedNums.Count)
        {
            return false;
        }
        return true;
    }
}