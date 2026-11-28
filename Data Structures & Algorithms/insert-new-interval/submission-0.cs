public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        
        List<int[]> newIntervals = new();
        int[] lastInterval;
        for (int i = 0; i < intervals.Length; i++) {
            // Check for gap with no overlap 
            if (newInterval[1] < intervals[i][0]) {
                newIntervals.Add(newInterval);
                for (int j = i; j < intervals.Length; j++) {
                    newIntervals.Add(intervals[j]);
                }
                return newIntervals.ToArray();
            }
            // Check for no overlap, but no gap yet
            else if (newInterval[0] > intervals[i][1]) {
                newIntervals.Add(intervals[i]);
            }
            // have overlap
            else {
                // overwrite new interval with expanded range
                newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
                newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
            }
        }
        
        // We can only reach this point if we haven't added newInterval
        newIntervals.Add(newInterval);

        return newIntervals.ToArray();
    }
}
