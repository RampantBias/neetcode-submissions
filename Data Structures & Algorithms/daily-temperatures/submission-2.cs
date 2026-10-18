public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] result = new int[temperatures.Length];
        Stack<Tuple<int, int>> temperatureStack = new();

        for (int i = 0; i < temperatures.Length; i++) {
            int temperature = temperatures[i];
            while (temperatureStack.Count > 0 && temperatureStack.Peek().Item2 < temperature) {
                var prior = temperatureStack.Pop();
                result[prior.Item1] = i - prior.Item1;
            }
            temperatureStack.Push(new Tuple<int, int>(i, temperature));
        }
        return result;
    }
}
