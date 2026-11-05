public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int, double> distances = new();
        for (int i = 0; i < points.Length; i++) {
            double distance = Math.Sqrt(Math.Pow(points[i][0], 2) + Math.Pow(points[i][1], 2));
            distances.Enqueue(i, -1 * distance);
            if (distances.Count > k) {
                distances.Dequeue();
            }
        }

        int[][] closest = new int[k][];
        for (int i = 0; i < k; i++) {
            int index = distances.Dequeue();
            closest[i] = new int[2] { points[index][0], points[index][1] };
        }
        return closest;
    }
}
