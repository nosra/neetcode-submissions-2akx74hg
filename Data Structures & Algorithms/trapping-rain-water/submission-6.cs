public class Solution {
    public int Trap(int[] height) {
        // let's try the O(n) solution
        var pfx = new int[height.Length];
        var sfx = new int[height.Length];
        int totalWater = 0;

        // first pass -- getting the prefix array
        int max = 0;
        for(int i = 0; i < height.Length; i++)
        {
            max = Math.Max(max, height[i]);
            pfx[i] = max;
        }
        // suffix array
        max = 0;
        for(int i = height.Length - 1; i >= 0; i--)
        {
            max = Math.Max(max, height[i]);
            sfx[i] = max;
        }
        
        // finally, get total trapped water
        for(int i = 0; i < height.Length; i++){
            totalWater += Math.Min(pfx[i], sfx[i]) - height[i];
        }

        return totalWater;
    }
}
