public class Solution {
    public int MaxArea(int[] heights) {
        int maxAmount = 0;
        int left = 0;
        int right = heights.Length - 1;
        while(left < right)
        {
            // hmm...
            // dude, FUCK greedy problems
            int level = (right - left) * Math.Min(heights[left], heights[right]);
            if(level > maxAmount) maxAmount = level;
            if(heights[left] < heights[right]) left++;
            else right--;


        }
        return maxAmount;
    }
}
