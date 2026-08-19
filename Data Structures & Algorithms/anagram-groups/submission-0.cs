public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groupedAnagrams = new Dictionary<string, List<string>>();
        foreach(string str in strs) {
            // Build frequency
            int[] frequency = new int[26];
            foreach(char c in str) {
                frequency[c - 'a']++;
            }

            // Build key
            StringBuilder keyBuilder = new StringBuilder();
            foreach(int freq in frequency) {
                keyBuilder.Append("#");
                keyBuilder.Append(freq);
            }
            string key = keyBuilder.ToString();

            if (!groupedAnagrams.ContainsKey(key)) {
                groupedAnagrams[key] = new List<string>();
            }
            groupedAnagrams[key].Add(str);
        }
        
        return new List<List<string>>(groupedAnagrams.Values);
    }
}
