public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);
        List<int> result = new List<int>();

        for (int i = 1; i <= nums.Length; i++)
        {
            if (!set.Contains(i))
            {
                result.Add(i);
            }
        }

        return result;
    }
}