public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        // quick sort
        Array.Sort(nums);
        int n = nums.Length;
        var res = new List<List<int>>();
        // o(n^2) loop
        for(int i = 0; i < n; i++)
        {
            // skip duplicates
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            int curNum = nums[i];
            int left = i+1;
            int right = n-1;
            while(left < right)
            {
                // hm...
                // nums[i] = -nums[j] -nums[k];
                // -nums[i] = nums[j] + nums[k] !!!
                // our target is -nums[i];
                // [-4, -1, -1, 0, 1, 2]
                int sum = nums[left] + nums[right];
                if(sum == -curNum)
                {
                    res.Add(new List<int>{nums[left], curNum, nums[right]});
                    left++;
                    right--;

                    // if the new number is the same as the old one
                    while(left < right && nums[left] == nums[left - 1]) left++;

                    // if the new number is the same as the old one
                    while(left < right && nums[right] == nums[right + 1]) right--;
                } 
                else if(sum > -curNum) right--;
                else left++;
            }
        }
        return res;
    }
}
