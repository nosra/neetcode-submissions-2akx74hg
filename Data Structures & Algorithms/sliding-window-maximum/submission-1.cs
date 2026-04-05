public class Solution {
    // this seems like a simple heap problem
    public int[] MaxSlidingWindow(int[] nums, int k) {
        // start populating the heap / moving the sliding window
        var maxHeap = new PriorityQueue<int, int>(
            Comparer<int>.Create((a, b) => b.CompareTo(a))
        );
        for(int i = 0; i < k; i++) 
            maxHeap.Enqueue(i, nums[i]);

        var res = new List<int>{ nums[maxHeap.Peek()] };
        for(int i = k; i < nums.Length; i++)
        {
            // [1, 2, 1] -> [2, 1, 1]
            maxHeap.Enqueue(i, nums[i]);
            while(maxHeap.Peek() <= i - k) 
                maxHeap.Dequeue();
            
            res.Add(nums[maxHeap.Peek()]);
            
        }
        return res.ToArray();
    }
}
