public class TimeMap {
    private Dictionary<string, SortedList<int, string>> timeMap;
    public TimeMap() {
        timeMap = new Dictionary<string, SortedList<int, string>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!timeMap.ContainsKey(key)) {
            timeMap.Add(key, new SortedList<int, string>());
        }
        timeMap[key][timestamp] = value;
    }
    
    public string Get(string key, int timestamp) {
        if (!timeMap.ContainsKey(key)) {
            return "";
        }

        var records = timeMap[key];
        int left = 0, right = records.Count - 1;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (records.Keys[mid] == timestamp) {
                return records.Values[mid];
            }
            else if (records.Keys[mid] > timestamp) {
                right = mid - 1;
            } else {
                left = mid + 1;
            }
        }

        if (right >= 0) {
            return records.Values[right];
        }
        return "";
    }
}
