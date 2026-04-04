public class Solution {
    // this assume |x| = |y|;
    private bool IsArrayEqual(int[] x, int[] y)
    {
        for(int i = 0; i < x.Length; i++)
        {
            if(x[i] != y[i])
                return false;
        }
        return true;
    }

    private string GenerateAnagramKey(string s)
    {
        int[] res = new int[26];
        foreach(char c in s)
        {            
            res[c - 'a']++;
        }
        return string.Join(",", res);
    }

    public List<List<string>> GroupAnagrams(string[] strs) {
        // first pass -- generate buckets for each anagram
        var seen = new Dictionary<string, List<string>>();
        foreach(string s in strs)
        {
            // this is the key to the dictionary
            string anagramKey = GenerateAnagramKey(s);
            if(seen.TryGetValue(anagramKey, out List<string> bucket))
            {                
                // add it to the bucket
                bucket.Add(s);
            }
            else
            {
                // create a new bucket
                seen[anagramKey] = new List<string>{s};
            }
        }
        // second pass -- return the formatted dictionary
        var sol = new List<List<string>>();
        foreach (KeyValuePair<string, List<string>> entry in seen)
        {
            sol.Add(entry.Value);
        }

        return sol;
    }
}