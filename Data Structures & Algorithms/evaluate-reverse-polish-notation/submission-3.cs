public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        foreach(string token in tokens)
        {
            switch(token)
            {
                case "+":
                    stack.Push(stack.Pop() + stack.Pop());
                    break;
                case "-":
                    // not communicative
                    int dif = stack.Pop();
                    stack.Push(stack.Pop() - dif);
                    break;
                case "*":
                    stack.Push(stack.Pop() * stack.Pop());
                    break;
                case "/":
                    int quot = stack.Pop();
                    stack.Push(stack.Pop() / quot);
                    break;
                default:
                    stack.Push(int.Parse(token));
                    break;
            }
        }
        return stack.Peek();
    }
}
