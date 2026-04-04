public class Solution {
    private int[] generatePrefix(int[] nums)
    {
        // [1, 2, 4, 6] -> [1, 2, 8, 48]
        int runningProduct = 1;
        var res = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            runningProduct *= nums[i];
            res[i] = runningProduct;
        }
        
        return res;
    }

    // product is passed in from the prefix array
    private int[] generateSuffix(int[] nums, int product)
    {
        // [1, 2, 4, 6] -> [48, 48, 24, 6]
        int n = nums.Length;
        var res = new int[n];
        res[n-1] = nums[n-1];
        // iterate from second to last to first
        // this feels a little clunky
        for(int i = n - 2; i > -1; i--)
            res[i] = nums[i] * res[i + 1];
        
        return res;
    }
    public int[] ProductExceptSelf(int[] nums) {
        // this is 100% a prefix / suffix problem
        int[] pfx = generatePrefix(nums);
        int[] sfx = generateSuffix(nums, pfx[nums.Length-1]);
        int[] res = new int[nums.Length];
        // nums =[-1, 0, 1, 2, 3]
        // pfx = [-1, 0, 0, 0, 0]
        // sfx = [0, 0, 6, 6, 3]
        for(int i = 0; i < nums.Length; i++)
        {
            if(i - 1 < 0)
            {
                // we're at the start -- ignore pfxs
                res[i] = sfx[i + 1];
            }
            else if(i + 1 > nums.Length - 1)
            {
                // we're at the end -- ignores sfxs
                res[i] = pfx[i - 1];
            }
            else
            {
                res[i] = sfx[i + 1] * pfx[i - 1];
            }
        }
        return res;
    }
}
