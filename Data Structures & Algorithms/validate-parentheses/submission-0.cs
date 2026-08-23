public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> parantheses = new Dictionary<char, char>()
        { { '(', ')' }, { '[', ']' }, { '{', '}' } };

        Stack<char> open = new Stack<char>();
        foreach(char c in s) {
            if (parantheses.ContainsKey(c)) {
                open.Push(c);
            } else {
                if (open.Count == 0) {
                    return false;
                }
                
                char opener = open.Pop();
                if (parantheses[opener] != c)
                    return false;
            }
        }

        return open.Count == 0;
    }
}
