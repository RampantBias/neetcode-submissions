public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> queue = new();
        foreach(int stone in stones) {
            queue.Enqueue(-1 * stone, stone * -1);
        }

        while (queue.Count > 1) {
            int x = queue.Dequeue();
            int y = queue.Dequeue();
            if (y - x > 0) {
                queue.Enqueue(x - y, x - y);
            }
        }

        if (queue.Count == 1) {
            return Math.Abs(queue.Dequeue());
        }
        else {
            return 0;
        }
    }
}
