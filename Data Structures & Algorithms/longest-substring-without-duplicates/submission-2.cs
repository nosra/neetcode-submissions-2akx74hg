public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // creating an array for the 128 ASCII characters
        int[] lastSeen = new int[128];
        
        // fill with -1 because index 0 is a valid position in the string
        Array.Fill(lastSeen, -1); 
        
        int left = 0;
        int maxLen = 0;
        
        for (int right = 0; right < s.Length; right++) {
            char currentChar = s[right];
            
            // if we've seen it, and it's inside our current window, shrink the window
            if (lastSeen[currentChar] >= left) {
                left = lastSeen[currentChar] + 1;
            }
            
            // update the last seen position of the character
            lastSeen[currentChar] = right;
            
            // calc max length
            maxLen = Math.Max(maxLen, right - left + 1);
        }
        
        return maxLen;
    }
}