public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var stack = new Stack<int>();
        // resizing so the monotonic stack doesn't fail at edge cases
        heights = [0, ..heights, 0];
        int maxArea = heights[0];
        for(int i = 0; i < heights.Length; i++)
        {
            // [3, 6, 7, 1, 2, ...]
            while(stack.Count > 0 && heights[i] < heights[stack.Peek()])
            {
                // our right boundary is i.
                // our left boundary is pastIdx.
                // our height is heights[pastIdx]
                int pastIdx = stack.Pop();
                int leftBoundary = stack.Peek(); 
                int area = (i - leftBoundary - 1) * heights[pastIdx];
                maxArea = Math.Max(maxArea, area);
            }
            stack.Push(i);
        }
        return maxArea;
    }
}
