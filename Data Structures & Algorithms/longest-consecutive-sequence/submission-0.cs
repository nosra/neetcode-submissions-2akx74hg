public class Solution {
    public int LongestConsecutive(int[] nums) {
        var buckets = new HashSet<int>(nums);
        int longest = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            int curNum = nums[i];
            // you can actually TRAVERSE the hashset
            if(!buckets.Contains(curNum - 1))
            {
                int len = 1;
                while(buckets.Contains(curNum + len)) len++;
                longest = Math.Max(longest, len);
            }
        }
        return longest;
    }
}
