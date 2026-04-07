public class Solution {
    public int EvalRPN(string[] tokens) {
        var numStack = new Stack<int>();
        foreach(string token in tokens)
        {
            bool operation = false;
            if(numStack.Count != 0)
            {
                switch(token)
                {
                    case "+":
                        operation = true;
                        int sum = numStack.Pop();
                        if(numStack.Count != 0)
                            sum += numStack.Pop();
                        numStack.Push(sum);
                        break;
                    case "-":
                        // not communicative
                        operation = true;
                        int dif = numStack.Pop();
                        if(numStack.Count != 0)
                            dif = numStack.Pop() - dif;
                        numStack.Push(dif);
                        break;
                    case "*":
                        operation = true;
                        int prod = numStack.Pop();
                        if(numStack.Count != 0)
                            prod *= numStack.Pop();
                        numStack.Push(prod);
                        break;
                    case "/":
                        // not communicative
                        operation = true;
                        int quot = numStack.Pop();
                        if(numStack.Count != 0)
                            quot = numStack.Pop() / quot;
                        numStack.Push(quot);
                        break;
                }
            }
            if(!operation)
            {
                int num = int.Parse(token);
                numStack.Push(num);
            }
            
        }
        return numStack.Peek();
    }
}
