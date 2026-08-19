public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        Stack<double> timeStack = new Stack<double>();
        
        // Sort position, copy that sort to speed
        Array.Sort(position, speed);
        
        double nextFleetTime = 0;
        for(int i = position.Length - 1; i >= 0; i--) {
            nextFleetTime = (double)(target - position[i]) / speed[i];
            
            if (timeStack.Count > 0 && timeStack.Peek() >= nextFleetTime) {
                continue;
            }
            timeStack.Push(nextFleetTime);
        }
        return timeStack.Count;
    }
}