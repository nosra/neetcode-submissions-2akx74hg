public class Solution {
    public bool IsPalindrome(string s) {
        if(string.IsNullOrEmpty(s)) return true;
        int left = 0;
        int right = s.Length - 1;
        while(left < right)
        {
            
            while(left < right && !Char.IsLetterOrDigit(s[left])) left++;
            while(left < right && !Char.IsLetterOrDigit(s[right])) right--;

            if(left >= right) break;

            if(Char.ToLower(s[right]) != Char.ToLower(s[left])) return false;
            left++;
            right--;
        }
        return true;
    }
}
