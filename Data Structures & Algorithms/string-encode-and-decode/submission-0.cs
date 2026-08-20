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
            string unparsedSize = s[left].ToString();
            right++;

            // first expand window until we reach our marker
            while (s[right] != '|') {
                unparsedSize += s[right].ToString();
                right++;
            }

            // parse the string size
            int size = int.Parse(unparsedSize);

            // Process and add string
            result.Add(s.Substring(right + 1, size));

            // adjust window
            left = right + 1 + size;
            right = left;
        }

        return result;
   }
}
