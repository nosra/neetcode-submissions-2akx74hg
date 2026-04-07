public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        // for quickly finding the cooresponding closing paranthesis
        var closings = new Dictionary<char, char>
        {
            {'(', ')'},
            {'[', ']'},
            {'{', '}'},
        };
        foreach(char c in s)
        {
            if(c == '(' || c == '[' || c == '{') 
                stack.Push(c);
            else if(c == ')' || c == ']' || c == '}')
            {
                if(stack.Count == 0) return false;
                if(closings[stack.Pop()] != c) return false;
            }
        }
        return stack.Count == 0;
    }
}
