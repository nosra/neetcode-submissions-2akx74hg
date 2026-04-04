public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var seen = new Dictionary<int, int>();
        var freq = new List<int>[nums.Length + 1];
        for(int i = 0; i < freq.Length; i++)
        {
            freq[i] = new List<int>();
        }
        for(int i = 0; i < nums.Length; i++)
        {
            if(seen.ContainsKey(nums[i]))
            {
                seen[nums[i]]++;
            }
            else
            {
                seen[nums[i]] = 1;
            }
        }
        foreach(var entry in seen)
        {
            freq[entry.Value].Add(entry.Key);
        }

        int[] sol = new int[k];
        int idx = 0;
        for(int i = freq.Length - 1; i > 0 && idx < k; i--)
        {
            foreach(int n in freq[i])
            {
                sol[idx] = n;
                idx++;
                if(idx == k)
                    return sol;
            }
        }
        return sol;
    }
}
