public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder result = new();
        foreach(var str in strs) {
            result.Append(str.Length);
            result.Append("|");
            result.Append(str);
        }
        return result.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new();
        int left = 0, right = 0;
        while (right < s.Length) {
            // first expand window until we reach our marker
            while (s[right] != '|') {
                right++;
            }

            // parse the string size
            int size = int.Parse(s.Substring(left, right - left));

            // Process and add string
            result.Add(s.Substring(right + 1, size));

            // adjust window
            left = right + 1 + size;
            right = left + 1;
        }

        return result;
   }
}
