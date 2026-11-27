/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public int MinMeetingRooms(List<Interval> intervals) {
        intervals.Sort((a, b) => a.start.CompareTo(b.start));
        // can track min end times against start times
        PriorityQueue<int, int> heap = new();

        foreach(var interval in intervals) {
            if (heap.Count > 0 && heap.Peek() <= interval.start) {
                heap.Dequeue();
            }
            heap.Enqueue(interval.end, interval.end);
        }

        return heap.Count;
    }
}
