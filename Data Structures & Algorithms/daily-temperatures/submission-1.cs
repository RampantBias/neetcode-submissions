public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] result = new int[temperatures.Length];
        Stack<Tuple<int, int>> temperatureStack = new Stack<Tuple<int, int>>();
        
        for(int i = 0; i < temperatures.Length; i++) {
            int currentTemp = temperatures[i];
            while (temperatureStack.Count > 0 && temperatureStack.Peek().Item2 < currentTemp) {
                var priorTemp = temperatureStack.Pop();
                result[priorTemp.Item1] = (i - priorTemp.Item1);
            }
            temperatureStack.Push(new Tuple<int, int>(i, currentTemp));
        }
        return result;
    }
}
