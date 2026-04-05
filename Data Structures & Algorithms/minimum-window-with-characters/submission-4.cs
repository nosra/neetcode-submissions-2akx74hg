public class Solution {
    public string MinWindow(string s, string t) {
        // get freqs
        var tFreqs = new int[128];
        foreach(char c in t) tFreqs[c]++;

        // get unique characters in t
        int required = 0;
        foreach(int count in tFreqs) 
            if (count > 0) required++;


        // sliding window
        int left = 0;
        int right = 0;
        int formed = 0;
        var res = (0, 0);
        int minLen = int.MaxValue;
        var sFreqs = new int[128];
        while(right < s.Length)
        {
            // add the frequency of this char
            char c = s[right];
            sFreqs[c]++;
            if(tFreqs[c] > 0 && sFreqs[c] == tFreqs[c])
                formed++;
            // as long is window is valid, try to make it smaller
            while(left <= right && formed == required)
            {
                int window = right - left + 1;
                if (window < minLen)
                {
                    minLen = window;
                    res = (left, right - left + 1);
                }
                // shrink
                char leftChar = s[left];
                sFreqs[leftChar]--;
                if (tFreqs[leftChar] > 0 && sFreqs[leftChar] < tFreqs[leftChar])
                {
                    // window broke
                    formed--;
                }
                left++;
            }
            right++;
        }

        return s.Substring(res.Item1, res.Item2);
    }
}
