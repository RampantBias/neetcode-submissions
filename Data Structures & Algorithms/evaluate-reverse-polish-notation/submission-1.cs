public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        List<string> symbols = new List<string>() { "+", "-", "*", "/" };
        for (int i = 0; i < tokens.Length; i++) {
            if (symbols.Contains(tokens[i])) {
                int b = stack.Pop();
                int a = stack.Pop();
                int result = ApplyOperation(tokens[i], a, b);
                stack.Push(result);
            } else {
                stack.Push(int.Parse(tokens[i]));
            }
        }
        return stack.Pop();
    }

    private int ApplyOperation(string operation, int a, int b) {
        switch(operation) {
            case "+":
                return a + b;
            case "-":
                return a - b;
            case "*":
                return a * b;
            case "/":
                return a / b;
        }
        return 0;
    }

}
