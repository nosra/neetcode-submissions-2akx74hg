class Solution {
    /**
     * @param {number[]} heights
     * @return {number}
     */

    maxArea(heights) {
        let left = 0;
        let right = heights.length - 1;
        let maxArea = 0;
        while(left < right)
        {
            let bottleneck = Math.min(heights[left], heights[right]);
            let area = bottleneck * (right - left);
            maxArea = Math.max(maxArea, area);

            // move the pointer of the smaller height
            if(heights[left] < heights[right]){
                left = left + 1;
            }
            else{
                right = right - 1;
            }
        }
        return maxArea;
    }
}
