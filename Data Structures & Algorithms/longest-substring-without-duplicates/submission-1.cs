public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // god, tell me how many times i've done this problem lol
        int left = 0;
        int right = 0;
        int maxLen = 0;
        var hm = new Dictionary<char, int>();
        while(right < s.Length)
        {
            if(hm.TryGetValue(s[right], out int idx))
            {
                left = Math.Max(left, idx + 1);
            }
            maxLen = Math.Max(right - left + 1, maxLen);
            hm[s[right]] = right;
            right++;
        }
        return maxLen;
    }
}
