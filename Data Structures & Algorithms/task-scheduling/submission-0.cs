public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int[] frequency = new int[26];
        foreach(char c in tasks) {
            frequency[c - 'A']++;
        }

        // prep queue with -frequency to always get 
        // next most frequent
        PriorityQueue<int, int> queue = new();
        for(int i = 0; i < frequency.Length; i++) {
            if (frequency[i] > 0) {
                queue.Enqueue(0, -frequency[i]);
            }
        }

        // track cooldown with waitQueue, add elements when
        // cooldown reaches 0
        Queue<(int count, int readyTime)> waitQueue = new();

        int totalCycles = 0;
        while (queue.Count > 0 || waitQueue.Count > 0) {
            totalCycles++;

            // Enqueue any ready elements
            if (waitQueue.Count > 0 && waitQueue.Peek().readyTime <= totalCycles) {
                var task = waitQueue.Dequeue();
                // Enqueue task with priority
                queue.Enqueue(task.count, -task.count);
            }

            // get next element to use
            if (queue.Count > 0) {
                queue.TryDequeue(out int index, out int freq);
                freq++;

                if (freq < 0) {
                    waitQueue.Enqueue((-freq, totalCycles + n + 1));
                }
            }
        }

        return totalCycles;
    }
}
