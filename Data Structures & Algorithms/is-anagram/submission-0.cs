public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        

        int[] s_alphabet = new int[26];
        int[] t_alphabet = new int[26];
        for(int i = 0; i < s.Length; i++)
        {
            s_alphabet[s[i] - 'a']++;
            t_alphabet[t[i] - 'a']++;
        }
        // check if equal
        for(int i = 0; i < 26; i++)
        {
            if(s_alphabet[i] != t_alphabet[i])
                return false;
        }
        return true;
    }
}
