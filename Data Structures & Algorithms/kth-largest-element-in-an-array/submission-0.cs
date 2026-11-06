public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> heap = new();
        for (int i = 0; i < nums.Length; i++) {
            heap.Enqueue(nums[i], nums[i]);
            if (heap.Count > k) {
                heap.Dequeue();
            }
        }
        return heap.Dequeue();
    }
}
