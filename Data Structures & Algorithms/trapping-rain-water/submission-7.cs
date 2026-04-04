public class Solution {
    public int Trap(int[] height) {
        if (height == null || height.Length == 0) return 0;

        int left = 0;
        int right = height.Length - 1;
        
        int leftMax = height[left];
        int rightMax = height[right];
        
        int totalWater = 0;

        // one pass, closing in on the middle
        while (left < right) {
            if (leftMax < rightMax) {
                left++;
                leftMax = Math.Max(leftMax, height[left]);
                totalWater += leftMax - height[left];
            } else {
                right--;
                rightMax = Math.Max(rightMax, height[right]);
                totalWater += rightMax - height[right];
            }
        }

        return totalWater;
    }
}