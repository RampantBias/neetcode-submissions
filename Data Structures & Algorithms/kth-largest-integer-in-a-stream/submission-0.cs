public class KthLargest {
    private PriorityQueue<int, int> queue;
    int maxElements;

    public KthLargest(int k, int[] nums) {
        queue = new();
        maxElements = k;
        foreach(int num in nums) {
            this.Add(num);
        }
    }
    
    public int Add(int val) {
        queue.Enqueue(val, val);
        if (queue.Count > maxElements) {
            queue.Dequeue();
        }

        int kthLargest = queue.Dequeue();
        queue.Enqueue(kthLargest, kthLargest);
        return kthLargest;
    }
}
