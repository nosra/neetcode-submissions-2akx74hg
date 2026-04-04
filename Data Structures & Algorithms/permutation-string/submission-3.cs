public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        // this seems much easier
        // first, gets freqs of s1
        var s1Freqs = new int[128];
        foreach(char c in s1) s1Freqs[c]++;

        int left = 0;
        int right = 0;
        int maxLen = 0;
        var s2Freqs = new int[128];
        while(right < s2.Length)
        {
            // Console.WriteLine($"{left}, {right}");
            char curChar = s2[right];
            s2Freqs[curChar]++;
            
            while(left <= right && s2Freqs[curChar] > s1Freqs[curChar])
            {
                //Console.WriteLine($"SHIFTING char: {curChar}");
                //Console.WriteLine($"{s2Freqs[curChar]} || {s1Freqs[curChar]}");
                s2Freqs[s2[left]]--;
                left++;
            }
            right++;
            
            if(right - left == s1.Length)
                return true;

        }
        return false;
    }
}
