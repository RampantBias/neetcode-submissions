public class Solution {
    public int[][] Merge(int[][] intervals) {
        // sort makes this trivial
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> result = new();
        int[] merge = intervals[0];
        for (int i = 1; i < intervals.Length; i++) {
            // zero overlap
            if (merge[1] < intervals[i][0]) {
                result.Add(new int[2] { merge[0], merge[1] });
                merge[0] = intervals[i][0];
                merge[1] = intervals[i][1];
            }
            else {
                merge[0] = Math.Min(merge[0], intervals[i][0]);
                merge[1] = Math.Max(merge[1], intervals[i][1]);
            }
        }
        result.Add(new int[2] { merge[0], merge[1] });
        return result.ToArray();
    }
}
