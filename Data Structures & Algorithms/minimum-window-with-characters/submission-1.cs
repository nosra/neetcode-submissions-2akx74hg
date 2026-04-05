public class Solution {
    private bool CheckIfValid(int[] sFreqs, int[] tFreqs, string t)
    {
        foreach(char c in t)
            if(sFreqs[c] < tFreqs[c]) return false;
        return true;
    }
    public string MinWindow(string s, string t) {
        // get freqs
        var tFreqs = new int[128];
        foreach(char c in t) tFreqs[c]++;

        // sliding window
        int left = 0;
        int right = 0;
        string res = "";
        int minLen = int.MaxValue;
        var sFreqs = new int[128];
        while(right < s.Length)
        {
            // add the frequency of this char
            sFreqs[s[right]]++;
            
            // we finally get a substring
            while(CheckIfValid(sFreqs, tFreqs, t))
            {
                Console.WriteLine("VALID WINDOW");
                int window = right - left + 1;

                if(window < minLen)
                {
                    minLen = window;
                    res = s.Substring(left, window);
                    Console.WriteLine(res);
                }
                // move the window
                sFreqs[s[left]]--;
                left++;
                Console.WriteLine($"{left}, {right}");
                while(left <= right && tFreqs[s[left]] == 0)
                {
                    
                    sFreqs[s[left]]--;
                    left++;
                    Console.WriteLine($"{left}, {right}");
                }
            }
            right++;
        }

        return res;
    }
}
