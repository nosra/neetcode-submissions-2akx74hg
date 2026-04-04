public class Solution {

    public string Encode(IList<string> strs) {
        // going to do run-length encoding
        StringBuilder encoded = new StringBuilder();
        foreach(string s in strs)
        {
            encoded.Append(s.Length);
            encoded.Append("#");
            encoded.Append(s);
        }
        return encoded.ToString();
    }

    public List<string> Decode(string s) {
        int idx = 0;
        var strs = new List<string>();
        while(idx < s.Length)
        {
            // read length into string
            int hashIndex = s.IndexOf('#', idx);
            int length = int.Parse(s.Substring(idx, hashIndex - idx));
            idx = hashIndex + 1;
            string toAdd = s.Substring(idx, length);
            strs.Add(toAdd);
            idx += length;
            //6#Carson6#Caelyn
        }
        return strs;
   }
}
