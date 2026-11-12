public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        List<string> permutations = new();
        Backtrack(n, "", ref permutations);
        return permutations;
    }

    private void Backtrack(int n, string current, ref List<string> permutations) {
        // There's definitely a simple property I can take advantage of, like
        // maybe tracking open ( count. But start simple...
        if (current.Length / 2 == n) {
            if (!IsWellFormed(current)) {
                return;
            }
            string newPerm = new string(current);
            permutations.Add(newPerm);
            return;
        }
        
        Backtrack(n, current + "(", ref permutations);
        Backtrack(n, current + ")", ref permutations);
    }

    // Simple well formed parantheses validator
    private bool IsWellFormed(string parantheses) {
        Stack<char> elements = new();
        foreach(char c in parantheses) {
            if (c == '(') {
                elements.Push(c);
            }
            else {
                if (elements.Count == 0) {
                    return false;
                }

                elements.Pop();
            }
        }
        return elements.Count == 0;
    }
}
