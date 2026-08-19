public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] result = new int[temperatures.Length];
        Stack<int[]> stack = new Stack<int[]>();
        for (int i = 0; i < temperatures.Length; i++) {
            int temp = temperatures[i];
            while (stack.Count > 0 && stack.Peek()[0] < temp) {
                var lastLowerDay = stack.Pop();
                result[lastLowerDay[1]] = i - lastLowerDay[1];
            }
            stack.Push(new int[] { temp, i });
        }
        return result;
    }
}
