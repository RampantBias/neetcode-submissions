public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> patterns = new();
        foreach(var str in strs) {
            // calculate letter array
            int[] characters = new int[26];
            foreach(char c in str) {
                characters[c - 'a']++;
            }
            StringBuilder keyBuilder = new();
            foreach(int c in characters) {
                keyBuilder.Append(c + "|");
            }
            string key = keyBuilder.ToString();

            if (patterns.ContainsKey(key)) {
                patterns[key].Add(str);
            } else {
                patterns[key] = new List<string>() { str };
            }
        }

        List<List<string>> groupedAnagrams = new();
        foreach(var kvp in patterns) {
            groupedAnagrams.Add(kvp.Value);
        }
        return groupedAnagrams;
    }
}
