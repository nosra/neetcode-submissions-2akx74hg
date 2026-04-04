public class Solution {
    public int Trap(int[] height) {
        // start by finding a formula for the amount of water at an index i
        // waterHeight = math.min(height[left], height[right])
        // waterHeight -= height[i];
        // o(n^2)
        // keep moving until we encounter a height that is equal to our current
        int totalWater = 0;
        for(int i = 1; i < height.Length; i++)
        {
            int curHeight = height[i];
            int left = i-1;
            int right = i+1;
            // Console.WriteLine(i);
            // Console.WriteLine($"left: {left}, right: {right}");
            int leftMax = 0;
            while(left >= 0){
                if(height[left] > leftMax) leftMax = height[left];
                left--;
            }
            int rightMax = 0;
            while(right < height.Length){
                if(height[right] > rightMax) rightMax = height[right];
                right++;
            }
            int trappedWater = Math.Min(leftMax, rightMax) - curHeight;
            // Console.WriteLine($"trappedWater: {trappedWater}");
            if(trappedWater < 0) continue;
            totalWater += trappedWater;
        }
        return totalWater;
    }
}
