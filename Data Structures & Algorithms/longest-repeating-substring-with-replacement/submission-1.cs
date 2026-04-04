public class Solution {
    public int CharacterReplacement(string s, int k) {
        // stupid
        int[] counts = new int[128]; 
        int left = 0;
        int maxLen = 0;
        int maxFreq = 0;

        for (int right = 0; right < s.Length; right++) {
            // add the new character to our windows count
            counts[s[right]]++;
            
            // update our record for the highest frequency seen in the window
            maxFreq = Math.Max(maxFreq, counts[s[right]]);

            // scam. window length - most frequent character count
            int windowLen = right - left + 1;
            if (windowLen - maxFreq > k) {
                // if it costs too many replacements, the window is invalid.
                // we must shrink it from the left. 
                
                // FIRST, remove the character at the left pointer from our counts
                counts[s[left]]--;
                // THEN move the left pointer
                left++; 
            }
            maxLen = Math.Max(maxLen, right - left + 1);
        }

        return maxLen;
    }
}