public class MinStack {
    int minValue;
    Stack<int> stack;
    Stack<int> pfxStack;

    public MinStack() {
        minValue = int.MaxValue;
        stack = new Stack<int>();
        pfxStack = new Stack<int>();
        pfxStack.Push(int.MinValue);
    }
    
    public void Push(int val) {
        if(stack.Count == 0)
            minValue = val;
        else if(val < minValue)
           minValue = val;
        // finally, push the value and minvalue
        pfxStack.Push(minValue);
        stack.Push(val);
    }
    
    public void Pop() {
        // if we pop the min value
        stack.Pop();
        pfxStack.Pop();
        minValue = pfxStack.Peek();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return pfxStack.Peek();
    }
}
