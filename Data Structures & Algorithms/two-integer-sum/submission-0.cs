public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // keep a running sum
        var seen = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(seen.TryGetValue(target - nums[i], out int val))
                return [val, i];
            else
                seen[nums[i]] = i;
        }
        return [-1, -1];
    }
}
