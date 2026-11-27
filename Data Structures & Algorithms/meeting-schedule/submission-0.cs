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
    public bool CanAttendMeetings(List<Interval> intervals) {
        // sort by starting time
        intervals.Sort((a, b) => a.start.CompareTo(b.start));

        // now we have intervals sorted by starting time
        // we can now compare each interval
        // on first collison we exit
        for (int i = 1; i < intervals.Count; i++) {
            // next meeting starts during prior meeting
            if (intervals[i].start < intervals[i - 1].end) {
                return false;
            }
        }
        return true;
    }
}
